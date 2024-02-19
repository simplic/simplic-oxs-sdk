from argparse import ArgumentParser, Namespace
from os.path import isfile
from re import T
from typing import Any
from core import cmd, Package
import dotnet
import fsutil
import json
import os
import requests
from urllib.parse import urlparse

DEBUG = True

# Used to check whether new specification matches old and skips if that's the case
SAVE_SPECIFICATIONS = True

GEN_CLI = "@openapitools/openapi-generator-cli"
GEN_VER = "7.2.0"
GEN_OUT = "openapi-out"

V_LATEST = "latest"
LIB_DEPS: dict[str, list[Package]] = {
    "generichost": [
        Package("Microsoft.Extensions.Http"),
        Package("Microsoft.Extensions.Hosting"),
        Package("Microsoft.Extensions.Http.Polly"),
        Package("Microsoft.Extensions.Logging"),
        Package("System.ComponentModel.Annotations"),
        Package("System.Text.Json"),
        Package("System.Threading.Channels"),
    ],
    "httpclient": [
        Package("Newtonsoft.Json"),
        Package("Polly"),
        Package("JsonSubTypes"),
        Package("System.ComponentModel.Annotations"),
    ],
    "unityWebRequest": [],
    "restsharp": [
        Package("RestSharp"),
        Package("Newtonsoft.Json"),
        Package("Polly"),
        Package("Microsoft.Extensions.Configuration.Abstractions"),
        Package("Microsoft.Extensions.DependencyInjection"),
        Package("System.Threading.Channels"),
    ],
}


def hyphen_to_dcap(s: str) -> str:
    """
    Turns any hyphen-case into Dotted.Capitalized.
    Example: this-is-an-example -> This.Is.An.Example
    """
    sections = s.split("-")
    sections = [f"{section[0].upper()}{section[1:]}" for section in sections]

    # ensure every first char after . is capital
    sections = ".".join(sections).split(".")
    sections = [f"{section[0].upper()}{section[1:]}" for section in sections]

    return ".".join(sections)


def get_specification(url_or_path: str) -> Any:
    """
    Gets the api specification and returns it as a json.
    """
    if not is_url(url_or_path):
        # interpret as path
        with open(url_or_path, "r") as f:
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
                "classlib", base_proj_folder, framework, LIB_DEPS[library]
            )
            dotnet.add_project_to_solution(sln_file, base_proj_file)
            dotnet.add_project_deps(base_proj_file, LIB_DEPS[library])
        else:
            print("* keeping pre existing base project *")
            dotnet.add_project_deps(base_proj_file, LIB_DEPS[library])

    cmd(f"npm install {GEN_CLI} -D", DEBUG)
    cmd(f"npx {GEN_CLI} version-manager set {GEN_VER}", DEBUG)

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
        last_part = title.split(".")[-1]

        # turn any hyphen-case to Dotted.Capitalized
        sdk_proj_suffix = custom_title or hyphen_to_dcap(last_part)
        sdk_proj_name = f"{args.name}.{sdk_proj_suffix}"
        sdk_proj_folder = f"{src_dir}/{sdk_proj_name}"
        sdk_proj_file = f"{sdk_proj_folder}/{sdk_proj_name}.csproj"
        gen_proj_folder = f"{GEN_OUT}/src/{sdk_proj_name}"

        sdk_proj_specification = f"{sdk_proj_folder}/{sdk_proj_name}.json"
        if SAVE_SPECIFICATIONS:
            # check if new specification matches old -> skip if true
            if not args.force and os.path.isfile(sdk_proj_specification):
                with open(sdk_proj_specification, "r") as f:
                    if os.path.getsize(sdk_proj_specification) > 0:
                        print(f"* using old specification for comparison *")
                        old_spec_json = json.load(f)
                        if json.dumps(spec_json, sort_keys=True) == json.dumps(
                            old_spec_json, sort_keys=True
                        ):
                            print(f"* specification did not change *")
                            print(f"-> skipping generation ({sdk_proj_name})")
                            continue

            # save new specification
            os.makedirs(sdk_proj_folder, exist_ok=True)
            with open(sdk_proj_specification, "w") as f:
                print(f"* saving new specification.. *")
                json.dump(spec_json, f, indent=4)

        # generate
        try:
            cmd(
                f"npx {GEN_CLI} generate"
                + f" -g csharp"
                + f" -c {args.config_file}"
                + f" -o {GEN_OUT}"
                + f" -t {args.template_dir}"
                + f" --api-name-suffix {args.api_name_suffix}"
                + f" --package-name {sdk_proj_name}"
                + f" --additional-properties=service={service}"
                + f" -i {url}",
                DEBUG,
                raise_on_error=True,
            )
        except Exception as e:
            print(f"!!! Failed generation for {service}: {e}")
            continue

        # generate target project in src dir
        if library == "unityWebRequest":
            fsutil.remove(sdk_proj_folder)
            fsutil.create_directory(sdk_proj_folder)
            fsutil.move(f"{gen_proj_folder}/{sdk_proj_name}.asmdef", sdk_proj_folder)
        else:
            if not os.path.exists(sdk_proj_file):
                dotnet.create_project("classlib", sdk_proj_folder, framework)
                dotnet.add_project_to_solution(sln_file, sdk_proj_file)
                dotnet.add_project_reference(sdk_proj_file, base_proj_file)
            else:
                print(f"* keeping pre existing project ({sdk_proj_name}) *")

            # remove code files
            fsutil.wipe_dir(
                sdk_proj_folder,
                keep=[f"{sdk_proj_name}.csproj", f"{sdk_proj_name}.json"],
            )

        # move generated files to proper project(s) and update references
        # Boiler Plate
        boiler_plate_folder = f"{base_proj_folder}/BoilerPlate"
        fsutil.create_directory(boiler_plate_folder)

        fsutil.rec_replace(gen_proj_folder, sdk_proj_name, args.name)
        problem_details = f"{gen_proj_folder}/Model/ProblemDetails.cs"
        if os.path.exists(problem_details):
            fsutil.move(problem_details, boiler_plate_folder)

        abstract_schema = f"{gen_proj_folder}/Model/AbstractOpenAPISchema.cs"
        if os.path.exists(abstract_schema):
            fsutil.move(abstract_schema, boiler_plate_folder)

        if library == "generichost":
            iapi = f"{gen_proj_folder}/Api/IApi.cs"
            if os.path.exists(iapi):
                fsutil.move(iapi, boiler_plate_folder)

            host_cfg = f"{gen_proj_folder}/Client/HostConfiguration.cs"
            if os.path.exists(host_cfg):
                fsutil.remove(host_cfg)

        fsutil.move(f"{gen_proj_folder}/Client/*", boiler_plate_folder)

        # remove service name from boiler plate comments
        print("* cleaning boiler plate.. *")
        fsutil.rec_replace(boiler_plate_folder, title, "", ".cs")

        # SDK specific
        # insert using for base project and fix namespace
        fsutil.rec_replace(
            gen_proj_folder,
            f"namespace {args.name}",
            f"using {args.name};\n\nnamespace {sdk_proj_name}",
            "cs",
        )
        fsutil.move(f"{gen_proj_folder}/Api/*", f"{src_dir}/{sdk_proj_name}")

        fsutil.create_directory(f"{sdk_proj_folder}/Model")
        fsutil.move(f"{gen_proj_folder}/Model/*", f"{sdk_proj_folder}/Model")

        # move docs to doc dir
        fsutil.create_directory(f"{doc_dir}/{sdk_proj_suffix}")
        fsutil.move(f"{GEN_OUT}/docs/*", f"{doc_dir}/{sdk_proj_suffix}")

    # cleanup
    fsutil.remove(GEN_OUT)


#####################################
#           SCRIPT START            #
#####################################
argparser = ArgumentParser()
argparser.add_argument("-w", "--workspace", required=True, help="Path to workspace")

argparser.add_argument(
    "-n",
    "--name",
    required=True,
    help="Name of the solution as well as the base project",
)

argparser.add_argument(
    "-i", "--input-file", required=True, help="Path to the services file"
)

argparser.add_argument(
    "-c", "--config-file", required=True, help="Path to the config file"
)

argparser.add_argument(
    "-t", "--template-dir", required=True, help="Path to the templates"
)

argparser.add_argument(
    "-s",
    "--src-dir",
    required=False,
    help="Where the generated projects shall go (Default: src/)",
)

argparser.add_argument(
    "-d",
    "--doc-dir",
    required=False,
    help="Where the documentation files shall go (Default: docs/)",
)

argparser.add_argument(
    "-ans", "--api-name-suffix", required=True, help="Suffix for generated api clients"
)

argparser.add_argument(
    "--force",
    action="store_true",
    required=False,
    help="If specified, will generate all projects no matter if anything changed in the specification",
)

main(argparser.parse_args())
