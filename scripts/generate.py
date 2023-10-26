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
    "generichost": [""],
    "httpclient": [""],
    "unityWebRequest": [""],
    "restsharp": ["RestSharp", "Newtonsoft.Json", "Polly"],
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


def get_specification(url: str) -> Any:
    """
    Gets the api specification and returns it as a json.
    """
    response = requests.get(url)
    response.raise_for_status()

    return json.loads(response.text)


def read_yaml(file: str) -> Any:
    """
    Reads a yaml file and parses the contents to an appropriate object.
    """
    with open(file, 'r') as f:
        return yaml.safe_load(f)


def prepare_solution(src_dir: str, name: str, dependencies: list[str]):
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
    cmd(f"dotnet new classlib -o {base_proj_folder}")
    fsutil.remove(f"{base_proj_folder}/Class1.cs")
    cmd(f"dotnet sln {sln_file} add {base_proj_file}")

    # add dependencies
    for pkg in dependencies:
        cmd(f"dotnet add {base_proj_file} package {pkg}")


def add_project(src_dir: str, name: str, sln_name):
    """
    Adds project to solution and adds reference to base project.
    """
    sln_file = f"{src_dir}/{sln_name}.sln"
    base_proj_folder = f"{src_dir}/{sln_name}"
    base_proj_file = f"{base_proj_folder}/{sln_name}.csproj"
    proj_folder = f"{src_dir}/{name}"
    proj_file = f"{proj_folder}/{name}.csproj"

    # remove existing
    fsutil.remove(proj_folder)

    # generate project
    cmd(f"dotnet new classlib -o {proj_folder}")
    fsutil.remove(f"{proj_folder}/Class1.cs")

    # add to solution
    cmd(f"dotnet sln {sln_file} add {proj_file}")

    # add assembly ref
    cmd(f"dotnet add {proj_file} reference {base_proj_file}")


def process_project(src_dir: str, name: str, base_proj_name: str, library: str):
    """
    Processes generated project.
    """
    gen_proj_folder = f"{GEN_OUT}/src/{name}"
    base_proj_folder = f"{src_dir}/{base_proj_name}"
    proj_folder = f"{src_dir}/{name}"

    # move generated files to proper project(s) and update references
    # Boiler Plate
    fsutil.rec_replace(gen_proj_folder, name, base_proj_name)
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
        f"namespace {base_proj_name}",
        f"using {base_proj_name};\n\nnamespace {name}",
        "cs"
    )
    fsutil.move(
        f"{gen_proj_folder}/Api/*",
        f"{src_dir}/{name}"
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
    config_file = args.config_file
    services_file = args.input_file
    base_proj_name = args.name

    # read config.yaml for specified library
    config_yaml = read_yaml(config_file)
    library = config_yaml["additionalProperties"]["library"]

    prepare_solution(src_dir, base_proj_name, LIB_DEPS[library])

    cmd(f"npm install {GEN_CLI} -D")
    cmd(f"npx {GEN_CLI} version-manager set 7.0.1")

    # read services file
    services_yaml = read_yaml(services_file)
    use_prefix_and_suffix: bool = services_yaml["url"]["use_prefix_and_suffix"]
    url_prefix: str = services_yaml["url"]["prefix"]
    url_suffix: str = services_yaml["url"]["suffix"]
    services: list[str] = services_yaml["services"]

    for service in services:
        service = service.strip()
        print(f">> {service}..")

        spec_url = f"{url_prefix}{service}{url_suffix}" if use_prefix_and_suffix else service
        spec_json = get_specification(spec_url)

        # need title for project name
        title = spec_json["info"]["title"]

        # but only last part
        last_part = title.split('.')[-1]

        # turn any hyphen-case to Dotted.Capitalized
        sdk_proj_suffix = hyphen_to_dotted_capitalized(last_part)
        sdk_proj_name = f"{base_proj_name}.{sdk_proj_suffix}"

        # generate
        cmd(f"npx {GEN_CLI} generate" +
            f" -g csharp" +
            f" -c {config_file}" +
            f" -o {GEN_OUT}" +
            f" -t {args.template_dir}" +
            f" --api-name-suffix {args.api_name_suffix}" +
            f" --package-name {sdk_proj_name}" +
            f" --additional-properties=service={service}" +
            f" -i {spec_url}")

        # generate target project in src dir
        add_project(src_dir, sdk_proj_name, base_proj_name)

        # post process
        process_project(src_dir, sdk_proj_name, base_proj_name, library)

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
