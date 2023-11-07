from argparse import ArgumentParser, Namespace
from typing import Any
import core
import dotnet
import fsutil
import json
import requests

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


def hyphen_to_dotted_capitalized(s: str) -> str:
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


def get_specification(url: str) -> Any:
    """
    Gets the api specification and returns it as a json.
    """
    response = requests.get(url)
    response.raise_for_status()

    return json.loads(response.text)


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

    if library != "unityWebRequest":
        dotnet.create_solution(src_dir, args.name)
        dotnet.create_project(
            "classlib",
            base_proj_folder,
            framework,
            LIB_DEPS[library]
        )
        dotnet.add_project_to_solution(sln_file, base_proj_file)

    core.cmd(f"npm install {GEN_CLI} -D", DEBUG)
    core.cmd(f"npx {GEN_CLI} version-manager set 7.0.1", DEBUG)

    # read services file
    services_yaml = fsutil.read_yaml(args.input_file)
    use_prefix_and_suffix: bool = services_yaml["url"]["use_prefix_and_suffix"]
    url_prefix: str = services_yaml["url"]["prefix"]
    url_suffix: str = services_yaml["url"]["suffix"]
    services: list[str] = services_yaml["services"]

    for service in services:
        service = service.strip()
        url = f"{url_prefix}{service}{url_suffix}" if use_prefix_and_suffix else service
        print(f">> {service}..")
        spec_json = get_specification(url)

        # need title for project name
        title = spec_json["info"]["title"]

        # but only last part
        last_part = title.split('.')[-1]

        # turn any hyphen-case to Dotted.Capitalized
        sdk_proj_suffix = hyphen_to_dotted_capitalized(last_part)
        sdk_proj_name = f"{args.name}.{sdk_proj_suffix}"
        sdk_proj_folder = f"{src_dir}/{sdk_proj_name}"
        sdk_proj_file = f"{src_dir}/{sdk_proj_name}/{sdk_proj_name}.csproj"
        gen_proj_folder = f"{GEN_OUT}/src/{sdk_proj_name}"

        # generate
        core.cmd(f"npx {GEN_CLI} generate" +
                 f" -g csharp" +
                 f" -c {args.config_file}" +
                 f" -o {GEN_OUT}" +
                 f" -t {args.template_dir}" +
                 f" --api-name-suffix {args.api_name_suffix}" +
                 f" --package-name {sdk_proj_name}" +
                 f" --additional-properties=service={service}" +
                 f" -i {url}", DEBUG)

        # generate target project in src dir
        if library == "unityWebRequest":
            fsutil.remove(sdk_proj_folder)
            fsutil.create_directory(sdk_proj_folder)
            fsutil.move(
                f"{gen_proj_folder}/{sdk_proj_name}.asmdef",
                sdk_proj_folder
            )
        else:
            dotnet.create_project("classlib", sdk_proj_folder, framework)
            dotnet.add_project_to_solution(sln_file, sdk_proj_file)
            dotnet.add_project_reference(sdk_proj_file, base_proj_file)

        # move generated files to proper project(s) and update references
        # Boiler Plate
        fsutil.rec_replace(gen_proj_folder, sdk_proj_name, args.name)
        if library != "generichost":
            fsutil.move(
                f"{gen_proj_folder}/Model/ProblemDetails.cs",
                base_proj_folder
            )
        fsutil.move(
            f"{gen_proj_folder}/Model/AbstractOpenAPISchema.cs",
            base_proj_folder
        )
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
        fsutil.move(f"{GEN_OUT}/docs/*", doc_dir)

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
