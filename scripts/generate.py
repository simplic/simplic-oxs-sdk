from argparse import ArgumentParser, Namespace
import fsutil
import json
import requests
import subprocess
import sys

DEBUG = True

GEN_CLI = "@openapitools/openapi-generator-cli"
GEN_OUT = "openapi-out"
DOC_DIR = "docs"
URL_PREFIX = "https://dev-oxs.simplic.io/"
URL_SUFFIX = "-api/v1/swagger/v1/swagger.json"
BASE_PROJ_DEPS = ["RestSharp", "Newtonsoft.Json", "Polly"]


def hyphen_to_dotted_capitalized(s: str):
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
    if DEBUG:
        print(f"> {cmd}")
    if sys.platform.startswith('linux') or sys.platform.startswith('darwin'):
        subprocess.run(cmd, shell=True)
    else:
        subprocess.run(cmd)


def main(args: Namespace):
    workspace = args.workspace
    src_dir = f"{workspace}/src"
    base_proj_name = args.name
    base_proj_file = f"{src_dir}/{base_proj_name}/{base_proj_name}.csproj"
    sln_file = f"{src_dir}/{base_proj_name}.sln"

    # generate solution and base project
    fsutil.remove(f"{sln_file}")
    cmd(f"dotnet new sln -n {base_proj_name} -o {src_dir}")
    fsutil.remove(f"{src_dir}/{base_proj_name}")
    cmd(f"dotnet new classlib -o {src_dir}/{base_proj_name}")
    fsutil.remove(f"{src_dir}/{base_proj_name}/Class1.cs")
    cmd(f"dotnet sln {sln_file} add {base_proj_file}")

    # add required packages for base project
    for pkg in BASE_PROJ_DEPS:
        cmd(f"dotnet add {base_proj_file} package {pkg}")

    cmd(f"npm install {GEN_CLI} -D")
    cmd(f"npx {GEN_CLI} version-manager set 7.0.1")

    # read services file
    with open(args.input_file, 'r') as f:
        for line in f:
            line = line.strip()
            if not line or line.startswith('#'):
                continue

            print(f">> {line}..")

            # get swagger.json
            spec_url = f"{URL_PREFIX}{line}{URL_SUFFIX}"
            spec_res = requests.get(spec_url)
            spec_res.raise_for_status()
            spec_data = spec_res.text
            spec_json = json.loads(spec_data)

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
                f" -c {args.config_file}" +
                f" -o {GEN_OUT}" +
                f" -t {args.template_dir}" +
                f" --api-name-suffix {args.api_name_suffix}" +
                f" --package-name {sdk_proj_name}" +
                f" -i {spec_url}")

            # generate target project in src dir
            fsutil.remove(f"{src_dir}/{sdk_proj_name}")
            cmd(f"dotnet new classlib -o {src_dir}/{sdk_proj_name}")
            fsutil.remove(f"{src_dir}/{sdk_proj_name}/Class1.cs")

            # add to solution
            sdk_proj_file = f"{src_dir}/{sdk_proj_name}/{sdk_proj_name}.csproj"
            cmd(f"dotnet sln {sln_file} add {sdk_proj_file}")

            # add assembly ref
            cmd(f"dotnet add {sdk_proj_file} reference {base_proj_file}")

            # move generated files to proper project(s)
            # Boiler Plate
            fsutil.rec_replace(
                f"{GEN_OUT}/src/{sdk_proj_name}",
                sdk_proj_name,
                base_proj_name
            )
            fsutil.move(
                f"{GEN_OUT}/src/{sdk_proj_name}/Model/ProblemDetails.cs",
                f"{src_dir}/{base_proj_name}"
            )
            fsutil.move(
                f"{GEN_OUT}/src/{sdk_proj_name}/Model/AbstractOpenAPISchema.cs",
                f"{src_dir}/{base_proj_name}"
            )
            fsutil.move(
                f"{GEN_OUT}/src/{sdk_proj_name}/Client/*",
                f"{src_dir}/{base_proj_name}"
            )

            # SDK specific
            # insert using for base project and fix namespace
            fsutil.rec_replace(
                f"{GEN_OUT}/src/{sdk_proj_name}",
                f"namespace {base_proj_name}",
                f"using {base_proj_name};\n\nnamespace {sdk_proj_name}",
                "cs"
            )
            fsutil.move(
                f"{GEN_OUT}/src/{sdk_proj_name}/Api/*",
                f"{src_dir}/{sdk_proj_name}"
            )

            fsutil.create_directory(f"{src_dir}/{sdk_proj_name}/Model")
            fsutil.move(
                f"{GEN_OUT}/src/{sdk_proj_name}/Model/*",
                f"{src_dir}/{sdk_proj_name}/Model"
            )

            # move docs to doc dir
            fsutil.move(f"{GEN_OUT}/docs/*", DOC_DIR)

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
    "-ans",
    "--api-name-suffix",
    required=True,
    help="Suffix for generated api clients"
)

main(argparser.parse_args())
