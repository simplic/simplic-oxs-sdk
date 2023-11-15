from argparse import ArgumentParser, Namespace
from typing import Any
import core
import dotnet
import fsutil
import json
import os
import requests
from urllib.parse import urlparse

DEBUG = True

GEN_CLI = "@openapitools/openapi-generator-cli"
GEN_OUT = "openapi-out"
LIB_DEPS = {
    "generichost": [
        "Microsoft.Extensions.Http",
        "Microsoft.Extensions.Hosting",
        "Microsoft.Extensions.Http.Polly",
        "System.ComponentModel.Annotations"
    ],
    "httpclient": [
        "Newtonsoft.Json",
        "Polly",
        "JsonSubTypes",
        "System.ComponentModel.Annotations"
    ],
    "unityWebRequest": [""],
    "restsharp": [
        "RestSharp",
        "Newtonsoft.Json",
        "Polly"
    ],
}


def hyphen_to_dcap(s: str) -> str:
    """
    Turns any hyphen-case into Dotted.Capitalized.
    Example: this-is-an-example -> This.Is.An.Example
    """
    sections = s.split('-')
    sections = [
        f"{section[0].upper()}{section[1:]}"
        for section in sections
    ]

    # ensure every first char after . is capital
    sections = '.'.join(sections).split('.')
    sections = [
        f"{section[0].upper()}{section[1:]}"
        for section in sections
    ]

    return '.'.join(sections)


def get_specification(url_or_path: str) -> Any:
    """
    Gets the api specification and returns it as a json.
    """
    if not is_url(url_or_path):
        # interpret as path
        with open(url_or_path, 'r') as f:
            return json.load(f)

    # interpret as url
    response = requests.get(url_or_path)
    response.raise_for_status()

    return json.loads(response.text)


def is_url(s: str) -> bool:
    try:
        result = urlparse(s)
        return all([result.scheme, result.netloc])
    except ValueError:
        return False


def main(args: Namespace):
    workspace = args.workspace
    src_dir = args.src_dir or f"{workspace}/src"
    doc_dir = args.doc_dir or f"{workspace}/docs"

    # read config.yaml for specified library
    config_yaml = fsutil.read_yaml(args.config_file)
    library = config_yaml["additionalProperties"]["library"]
    framework = config_yaml["additionalProperties"]["targetFramework"]

    sln_file = f"{src_dir}/{args.name}.sln"
    base_proj_folder = f"{src_dir}/{args.name}"
    base_proj_file = f"{base_proj_folder}/{args.name}.csproj"

    # create foundation if not exists yet
    if library != "unityWebRequest":
        if not os.path.exists(sln_file):
            dotnet.create_solution(src_dir, args.name)
        else:
            print("* keeping pre existing solution *")

        if not os.path.exists(base_proj_file):
            dotnet.create_project(
                "classlib",
                base_proj_folder,
                framework,
                LIB_DEPS[library]
            )
            dotnet.add_project_to_solution(sln_file, base_proj_file)
        else:
            print("* keeping pre existing base project *")
            dotnet.add_project_deps(base_proj_file, LIB_DEPS[library])

    core.cmd(f"npm install {GEN_CLI} -D", DEBUG)
    core.cmd(f"npx {GEN_CLI} version-manager set 7.0.1", DEBUG)

    # read services file
    services_yaml = fsutil.read_yaml(args.input_file)
    use_prefix_and_suffix: bool = services_yaml["url"]["use_prefix_and_suffix"]
    url_prefix: str = services_yaml["url"]["prefix"]
    url_suffix: str = services_yaml["url"]["suffix"]
    services: dict = services_yaml["services"]

    for entry in services:
        service = entry.get("x").strip()
        custom_title = entry.get("title", None)
        is_url = entry.get("is_url", False)
        if not use_prefix_and_suffix or is_url:
            url = service
        else:
            url = f"{url_prefix}{service}{url_suffix}"

        print(f">> {service}..")
        if custom_title is not None:
            print(f"--> {custom_title}")
        try:
            spec_json = get_specification(url)
        except Exception:
            print(f"!!! Failed to get specification for {service} ({url})")
            continue

        # need title for project name
        title = spec_json["info"]["title"]

        # but only last part
        last_part = title.split('.')[-1]

        # turn any hyphen-case to Dotted.Capitalized
        sdk_proj_suffix = custom_title or hyphen_to_dcap(last_part)
        sdk_proj_name = f"{args.name}.{sdk_proj_suffix}"
        sdk_proj_folder = f"{src_dir}/{sdk_proj_name}"
        sdk_proj_file = f"{sdk_proj_folder}/{sdk_proj_name}.csproj"
        gen_proj_folder = f"{GEN_OUT}/src/{sdk_proj_name}"

        # generate
        try:
            core.cmd(f"npx {GEN_CLI} generate" +
                     f" -g csharp" +
                     f" -c {args.config_file}" +
                     f" -o {GEN_OUT}" +
                     f" -t {args.template_dir}" +
                     f" --api-name-suffix {args.api_name_suffix}" +
                     f" --package-name {sdk_proj_name}" +
                     f" --additional-properties=service={service}" +
                     f" -i {url}", DEBUG, raise_on_error=True)
        except Exception as e:
            print(f"!!! Failed generation for {service}: {e}")
            continue

        # generate target project in src dir
        if library == "unityWebRequest":
            fsutil.remove(sdk_proj_folder)
            fsutil.create_directory(sdk_proj_folder)
            fsutil.move(
                f"{gen_proj_folder}/{sdk_proj_name}.asmdef",
                sdk_proj_folder
            )
        else:
            if not os.path.exists(sdk_proj_file):
                dotnet.create_project("classlib", sdk_proj_folder, framework)
                dotnet.add_project_to_solution(sln_file, sdk_proj_file)
                dotnet.add_project_reference(sdk_proj_file, base_proj_file)
            else:
                print(f"* keeping pre existing project ({sdk_proj_name}) *")

            # remove code files
            fsutil.wipe_dir(sdk_proj_folder, keep=[f"{sdk_proj_name}.csproj"])

        # move generated files to proper project(s) and update references
        # Boiler Plate
        fsutil.rec_replace(gen_proj_folder, sdk_proj_name, args.name)
        problem_details = f"{gen_proj_folder}/Model/ProblemDetails.cs"
        if library != "generichost" and os.path.exists(problem_details):
            fsutil.move(problem_details, base_proj_folder)

        abstract_schema = f"{gen_proj_folder}/Model/AbstractOpenAPISchema.cs"
        if os.path.exists(abstract_schema):
            fsutil.move(abstract_schema, base_proj_folder)

        fsutil.move(f"{gen_proj_folder}/Client/*", base_proj_folder)

        # SDK specific
        # insert using for base project and fix namespace
        fsutil.rec_replace(
            gen_proj_folder,
            f"namespace {args.name}",
            f"using {args.name};\n\nnamespace {sdk_proj_name}",
            "cs"
        )
        fsutil.move(
            f"{gen_proj_folder}/Api/*",
            f"{src_dir}/{sdk_proj_name}"
        )

        fsutil.create_directory(f"{sdk_proj_folder}/Model")
        fsutil.move(
            f"{gen_proj_folder}/Model/*",
            f"{sdk_proj_folder}/Model"
        )

        # move docs to doc dir
        fsutil.create_directory(f"{doc_dir}/{sdk_proj_suffix}")
        fsutil.move(f"{GEN_OUT}/docs/*", f"{doc_dir}/{sdk_proj_suffix}")

    # cleanup
    fsutil.remove(GEN_OUT)


#####################################
#           SCRIPT START            #
#####################################
argparser = ArgumentParser()
argparser.add_argument(
    "-w",
    "--workspace",
    required=True,
    help="Path to workspace"
)

argparser.add_argument(
    "-n",
    "--name",
    required=True,
    help="Name of the solution as well as the base project"
)

argparser.add_argument(
    "-i",
    "--input-file",
    required=True,
    help="Path to the services file"
)

argparser.add_argument(
    "-c",
    "--config-file",
    required=True,
    help="Path to the config file"
)

argparser.add_argument(
    "-t",
    "--template-dir",
    required=True,
    help="Path to the templates"
)

argparser.add_argument(
    "-s",
    "--src-dir",
    required=False,
    help="Where the generated projects shall go (Default: src/)"
)

argparser.add_argument(
    "-d",
    "--doc-dir",
    required=False,
    help="Where the documentation files shall go (Default: docs/)"
)

argparser.add_argument(
    "-ans",
    "--api-name-suffix",
    required=True,
    help="Suffix for generated api clients"
)

main(argparser.parse_args())
