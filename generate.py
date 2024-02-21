from argparse import ArgumentParser
from scripts.core import *
import os

argparser = ArgumentParser()
argparser.add_argument(
    "--force",
    action="store_true",
    required=False,
    help="If specified, will generate all projects no matter if anything changed in the specification"
)
argparser.add_argument(
    "-v",
    "--verbose",
    action="store_true",
    required=False,
    help="Verbose logging"
)
args = argparser.parse_args()

GEN_ARGS: list[str] = []
BTF_ARGS: list[str] = []
if args.force:
    GEN_ARGS.append("--force")
if args.verbose:
    GEN_ARGS.append("--verbose")
    BTF_ARGS.append("--verbose")
    

# Workspace is where this script is at
WORKSPACE = os.path.dirname(os.path.abspath(__file__))

######################
# Change as you like #
SRC_DIR = os.path.join(WORKSPACE, "src")
DOC_DIR = os.path.join(WORKSPACE, "docs")
TMPL_DIR = os.path.join(WORKSPACE, "templates/csharp")
CFG_FILE = os.path.join(WORKSPACE, "config.yaml")
SVC_FILE = os.path.join(WORKSPACE, "services.yaml")
SCRIPT_DIR = os.path.join(WORKSPACE, "scripts")

API_NAME_SUFFIX = "Client"
BASE_PROJ_NAME = "Simplic.OxS.SDK"
######################

SLN_FILE = os.path.join(SRC_DIR, f"{BASE_PROJ_NAME}.sln")
# following common simplic solution pattern:
# |_ Some.Proj.A/
# |_ Some.Proj.B/
# |_ Some.sln

os.makedirs(SRC_DIR, exist_ok=True)
os.makedirs(DOC_DIR, exist_ok=True)

########################
# generate api clients #
print(f"{Color.MAGENTA} > {Color.YELLOW}Generating..{Color.RESET}")
script = os.path.join(SCRIPT_DIR, "generator.py")

cmd(f"python \"{script}\""
    f" --workspace \"{WORKSPACE}\""
    f" --name \"{BASE_PROJ_NAME}\""
    f" -c \"{CFG_FILE}\""
    f" -t \"{TMPL_DIR}\""
    f" --src-dir \"{SRC_DIR}\""
    f" --doc-dir \"{DOC_DIR}\""
    f" --api-name-suffix \"{API_NAME_SUFFIX}\""
    f" -i \"{SVC_FILE}\""
    f" {' '.join(GEN_ARGS)}")

print(f"{Color.MAGENTA}..{Color.YELLOW}done{Color.RESET}")
########################

########################
#  fix function names  #
print(f"{Color.MAGENTA} > {Color.YELLOW}Fixing bad function names{Color.MAGENTA}..{Color.RESET}")
script = os.path.join(SCRIPT_DIR, "beautifier.py")

for proj_folder in os.listdir(SRC_DIR):
    proj_folder_path = os.path.join(SRC_DIR, proj_folder)
    if proj_folder == BASE_PROJ_NAME or not os.path.isdir(proj_folder_path):
        continue

    for file_name in os.listdir(proj_folder_path):
        file_path = os.path.join(proj_folder_path, file_name)
        file_name_noext, file_ext = os.path.splitext(file_name)

        if API_NAME_SUFFIX not in file_name or file_ext != ".cs":
            continue

        controller_name = file_name.split(API_NAME_SUFFIX)[0]
        print(f"\n{Color.MAGENTA}>>{controller_name}..{Color.RESET}")

        proj_title = proj_folder.replace(f"{BASE_PROJ_NAME}.", "")
        doc_file = os.path.join(DOC_DIR, proj_title, f"{file_name_noext}.md")

        # fix correlating documentation as well
        if os.path.exists(doc_file):
            BTF_ARGS.append(f"-d {doc_file}")
            
        cmd(f"python {script}"
            f" -f {file_path}"
            f" -c {controller_name}"
            f" {' '.join(BTF_ARGS)}")

        print(f"{Color.MAGENTA}..done{Color.RESET}")

print(f"{Color.MAGENTA}..{Color.YELLOW}done{Color.RESET}")
########################

print(f"{Color.MAGENTA}**{Color.YELLOW} All done! {Color.MAGENTA}**{Color.RESET}")
