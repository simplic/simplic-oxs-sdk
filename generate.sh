#!/bin/bash

# Colors
RED="\033[31m"
GREEN="\033[32m"
YELLOW="\033[33m"
LGREEN="\033[92m"
LYELLOW="\033[93m"
LMAGENTA="\033[95m"
NC="\033[0m"

WORKSPACE="$(dirname "$0")"

SRC_DIR="$WORKSPACE/src"
DOC_DIR="$WORKSPACE/docs"
TMPL_DIR="$WORKSPACE/templates/csharp"
CFG_FILE="$WORKSPACE/config.yaml"
SVC_FILE="$WORKSPACE/services"

API_NAME_SUFFIX="Client"

BASE_PROJ_NAME="Simplic.OxS.SDK"
SLN_FILE="$SRC_DIR/$BASE_PROJ_NAME.sln"

#############################################
#               SCRIPT START                #
#############################################
set -e
mkdir -p "$SRC_DIR"
mkdir -p "$DOC_DIR"

# generate api clients
echo -e "\n\n$LMAGENTA> $YELLOW Generating $LMAGENTA..$NC\n\n"
python scripts/generate.py \
    --workspace "$WORKSPACE" \
    --name "$BASE_PROJ_NAME" \
    -c "$CFG_FILE" \
    -t "$TMPL_DIR" \
    --api-name-suffix "$API_NAME_SUFFIX" \
    -i "$SVC_FILE" \
    || (echo -e "$RED! Error in generate.py !$NC" && exit 1)
echo -e "\n\n$LMAGENTA..$YELLOW done $LMAGENTA$NC\n\n"

# fix function names
echo -e "\n\n$LMAGENTA> $YELLOW Fixing bad function names $LMAGENTA..$NC\n\n"
for proj_folder in "$SRC_DIR"/*; do
    proj_folder_name=$(basename "$proj_folder")
    if [[ "$proj_folder_name" == "$BASE_PROJ_NAME" ]]; then
        continue
    fi

    for file in "$proj_folder"/*; do
        file_name=$(basename "$file")
        if [[ "$file_name" != *"$API_NAME_SUFFIX.cs" ]]; then
            continue
        fi

        controller_name="${file_name%%$API_NAME_SUFFIX*}"
        echo -e "\n$LMAGENTA>>$controller_name..$NC"
        python scripts/beautifier.py \
            -f "$file" \
            -c "$controller_name" \
            || (echo -e "$RED! Error in beautifier.py !$NC" && exit 1)
        echo -e "\n$LMAGENTA..done$NC"
    done
done
echo -e "\n\n$LMAGENTA..$YELLOW done $LMAGENTA$NC\n\n"

echo -e "\n\n$LMAGENTA**$YELLOW All done! $LMAGENTA**$NC\n\n"

