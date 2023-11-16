#!/bin/bash

#####################
#     Colors        #
RED="\033[31m"
GREEN="\033[32m"
YELLOW="\033[33m"
LGREEN="\033[92m"
LYELLOW="\033[93m"
LMAGENTA="\033[95m"
NC="\033[0m"
#####################

# Workspace is where this script is at
WORKSPACE="$(dirname "$0")"

######################
# Change as you like #
SRC_DIR="$WORKSPACE/src"
DOC_DIR="$WORKSPACE/docs"
TMPL_DIR="$WORKSPACE/templates/csharp"
CFG_FILE="$WORKSPACE/config.yaml"
SVC_FILE="$WORKSPACE/services.yaml"
SCRIPT_DIR="$WORKSPACE/scripts"

API_NAME_SUFFIX="Client"

BASE_PROJ_NAME="Simplic.OxS.SDK"
######################

SLN_FILE="$SRC_DIR/$BASE_PROJ_NAME.sln"
# following common simplic solution pattern:
# |_ Some.Proj.A/
# |_ Some.Proj.B/
# |_ Some.sln

#############################################
#               SCRIPT START                #
#############################################
set -e
mkdir -p "$SRC_DIR"
mkdir -p "$DOC_DIR"

########################
# generate api clients #
echo -e "\n\n$LMAGENTA> $YELLOW Generating $LMAGENTA..$NC\n\n"

SCRIPT_GENERATE="$SCRIPT_DIR/generate.py"

python "$SCRIPT_GENERATE" \
    --workspace "$WORKSPACE" \
    --name "$BASE_PROJ_NAME" \
    -c "$CFG_FILE" \
    -t "$TMPL_DIR" \
    --src-dir "$SRC_DIR" \
    --doc-dir "$DOC_DIR" \
    --api-name-suffix "$API_NAME_SUFFIX" \
    -i "$SVC_FILE" ||
    (echo -e "$RED! Error in $SCRIPT_GENERATE !$NC" && exit 1)

echo -e "\n\n$LMAGENTA..$YELLOW done $LMAGENTA$NC\n\n"
########################

########################
#  fix function names  #
echo -e "\n\n$LMAGENTA> $YELLOW Fixing bad function names $LMAGENTA..$NC\n\n"

SCRIPT_BEAUTIFIER="$SCRIPT_DIR/beautifier.py"

for proj_folder in "$SRC_DIR"/*; do
    proj_folder_name=$(basename "$proj_folder")
    if [[ "$proj_folder_name" == "$BASE_PROJ_NAME" ]]; then
        continue
    fi

    for file in "$proj_folder"/*; do
        file_name=$(basename "$file")
        file_name_noext="${file_name%.*}"
        if [[ "$file_name" != *"$API_NAME_SUFFIX.cs" ]]; then
            continue
        fi

        controller_name="${file_name%%$API_NAME_SUFFIX*}"
        echo -e "\n$LMAGENTA>>$controller_name..$NC"
        proj_title=$(echo "$proj_folder_name" | sed "s/^$BASE_PROJ_NAME.//")
        doc_file="$DOC_DIR/$proj_title/$file_name_noext.md"
        # fix correlating documentation as well
        if [ -e "$doc_file" ]; then
            python "$SCRIPT_BEAUTIFIER" \
                -f "$file" \
                -d "$doc_file" \
                -c "$controller_name" ||
                (echo -e "$RED! Error in $SCRIPT_BEAUTIFIER !$NC" && exit 1)
        else
            echo "NO DOC >$doc_file<"
            python "$SCRIPT_BEAUTIFIER" \
                -f "$file" \
                -c "$controller_name" ||
                (echo -e "$RED! Error in $SCRIPT_BEAUTIFIER !$NC" && exit 1)
        fi

        echo -e "\n$LMAGENTA..done$NC"
    done
done
echo -e "\n\n$LMAGENTA..$YELLOW done $LMAGENTA$NC\n\n"
########################

echo -e "\n\n$LMAGENTA**$YELLOW All done! $LMAGENTA**$NC\n\n"
