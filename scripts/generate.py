from argparse import ArgumentParser, Namespace
from typing import Any
import fsutil
import json
import yaml
import requests
import subprocess
import sys

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


def cmd(cmd: str):
    """
    Runs a command.
    """
    if DEBUG:
        print(f"> {cmd}")
    if sys.platform.startswith('linux') or sys.platform.startswith('darwin'):
        subprocess.run(cmd, shell=True)
    else:
        subprocess.run(cmd)


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


def generate_solution(src_dir: str, name: str, dependencies: list[str], framework: str):
    """
    Generates solution along with base project and its dependencies.
    """
    sln_file = f"{src_dir}/{name}.sln"
    base_proj_folder = f"{src_dir}/{name}"
    base_proj_file = f"{base_proj_folder}/{name}.csproj"

    # remove existing
    fsutil.remove(sln_file)
    fsutil.remove(base_proj_folder)

    # generate solution & project
    cmd(f"dotnet new sln -n {name} -o {src_dir}")
    cmd(f"dotnet new classlib -o {base_proj_folder} --framework {framework} --langVersion latestMajor")
    fsutil.remove(f"{base_proj_folder}/Class1.cs")
    cmd(f"dotnet sln {sln_file} add {base_proj_file}")

    # add dependencies
    for pkg in dependencies:
        cmd(f"dotnet add {base_proj_file} package {pkg}")


def generate_project(src_dir: str, name: str, sln_name: str, framework: str):
    """
    Generates and adds project to solution and adds reference to base project.
    """
    sln_file = f"{src_dir}/{sln_name}.sln"
    base_proj_folder = f"{src_dir}/{sln_name}"
    base_proj_file = f"{base_proj_folder}/{sln_name}.csproj"
    proj_folder = f"{src_dir}/{name}"
    proj_file = f"{proj_folder}/{name}.csproj"

    # remove existing
    fsutil.remove(proj_folder)

    # generate project
    cmd(f"dotnet new classlib -o {proj_folder} --framework {framework} --langVersion latestMajor")
    fsutil.remove(f"{proj_folder}/Class1.cs")

    # add to solution
    cmd(f"dotnet sln {sln_file} add {proj_file}")

    # add assembly ref
    cmd(f"dotnet add {proj_file} reference {base_proj_file}")


def generate_service(service: str, base_name: str, src_dir: str, url: str, library: str, config_file: str, template_dir: str, api_name_suffix: str, framework: str):
    spec_json = get_specification(url)

    # need title for project name
    title = spec_json["info"]["title"]

    # but only last part
    last_part = title.split('.')[-1]

    # turn any hyphen-case to Dotted.Capitalized
    sdk_proj_suffix = hyphen_to_dotted_capitalized(last_part)
    sdk_proj_name = f"{base_name}.{sdk_proj_suffix}"
    sdk_proj_folder = f"{src_dir}/{sdk_proj_name}"
    gen_proj_folder = f"{GEN_OUT}/src/{sdk_proj_name}"

    # generate
    cmd(f"npx {GEN_CLI} generate" +
        f" -g csharp" +
        f" -c {config_file}" +
        f" -o {GEN_OUT}" +
        f" -t {template_dir}" +
        f" --api-name-suffix {api_name_suffix}" +
        f" --package-name {sdk_proj_name}" +
        f" --additional-properties=service={service}" +
        f" -i {url}")

    # generate target project in src dir
    if library == "unityWebRequest":
        fsutil.remove(sdk_proj_folder)
        fsutil.create_directory(sdk_proj_folder)
        fsutil.move(
            f"{gen_proj_folder}/{sdk_proj_name}.asmdef",
            sdk_proj_folder
        )
    else:
        generate_project(src_dir, sdk_proj_name, base_name, framework)

    gen_proj_folder = f"{GEN_OUT}/src/{sdk_proj_name}"
    base_proj_folder = f"{src_dir}/{base_name}"
    proj_folder = f"{src_dir}/{sdk_proj_name}"

    # move generated files to proper project(s) and update references
    # Boiler Plate
    fsutil.rec_replace(gen_proj_folder, sdk_proj_name, base_name)
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
        f"namespace {base_name}",
        f"using {base_name};\n\nnamespace {sdk_proj_name}",
        "cs"
    )
    fsutil.move(
        f"{gen_proj_folder}/Api/*",
        f"{src_dir}/{sdk_proj_name}"
    )

    fsutil.create_directory(f"{proj_folder}/Model")
    fsutil.move(
        f"{gen_proj_folder}/Model/*",
        f"{proj_folder}/Model"
    )


def main(args: Namespace):
    workspace = args.workspace
    src_dir = f"{workspace}/src"
    doc_dir = args.doc_dir or f"{workspace}/docs"

    # read config.yaml for specified library
    config_yaml = fsutil.read_yaml(args.config_file)
    library = config_yaml["additionalProperties"]["library"]
    framework = config_yaml["additionalProperties"]["targetFramework"]

    if library != "unityWebRequest":
        generate_solution(src_dir, args.name, LIB_DEPS[library], framework)

    cmd(f"npm install {GEN_CLI} -D")
    cmd(f"npx {GEN_CLI} version-manager set 7.0.1")

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
        generate_service(
            service,
            args.name,
            src_dir,
            url,
            library,
            args.config_file,
            args.template_dir,
            args.api_name_suffix,
            framework
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
