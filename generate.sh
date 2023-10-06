#!/bin/bash

# Colors
GREEN="\033[32m"
YELLOW="\033[33m"
LGREEN="\033[92m"
LYELLOW="\033[93m"
LMAGENTA="\033[95m"
NC="\033[0m"

SRC_DIR="./src"
DOC_DIR="./docs"
GEN_OUT="./openapi-out"
GEN_CFG="./config.yaml"

SVC_FILE="services"
BASE_URL="https://dev-oxs.simplic.io/"
POST_URL="-api/v1/swagger/v1/swagger.json"

BASE_PROJ_NAME="Simplic.OxS.SDK"
BASE_PROJ_FOLDER="$SRC_DIR/$BASE_PROJ_NAME"
BASE_PROJ_FILE="$BASE_PROJ_FOLDER/$BASE_PROJ_NAME.csproj"
BASE_PROJ_DEPS=("Newtonsoft.Json" "RestSharp" "Polly")
SLN_FILE="$SRC_DIR/$BASE_PROJ_NAME.sln"

CLI="npx @openapitools/openapi-generator-cli"
TMPL_DIR="./templates/csharp"

# Logging
log() {
    msg="$1"
    variation=$2

    case $variation in
        0)
            echo -e "$LMAGENTA[[$LYELLOW $msg $LMAGENTA]]$NC"
            ;;
        1)
            echo -e "$LMAGENTA>>$YELLOW $msg$NC"
            ;;
        2)
            echo -e "$LMAGENTA[[$LGREEN $msg $LMAGENTA]]$NC"
            ;;
        *)
            echo -e "$LMAGENTA[[$YELLOW $msg $LMAGENTA]]$NC"
            ;;
    esac
}

# Recursively replace a term
rec_replace() {
    local path="$1"
    local old_term="$2"
    local new_term="$3"
    local file_extension="$4"

    if [[ ! -d "$path" ]]; then
        # not a directory -> just replace for this file
        sed -i "s#$old_term#$new_term#g" "$path"
    else
        for __i in "$path"/*; do
            local entry=$__i
            if [[ -d "$entry" ]]; then
                # recurse
                rec_replace "$entry" "$old_term" "$new_term" "$file_extension"
                continue
            fi

            if [[ ! -z "$file_extension" ]] && [[ "${entry##*.}" != "$file_extension" ]]; then
                # only replace for file having given extension
                continue
            fi

            sed -i "s#$old_term#$new_term#g" "$entry"
        done
    fi
}

# Fixes function names
fix_function_names() {
    local path="$1"
    local controller="$2"

    for __i in "$path"/*; do
        local entry=$__i
        if [[ -d "$entry" ]]; then
            # recurse
            fix_function_names "$entry" "$controller"
            continue
        fi

        if [[ "${entry##*.}" != "cs" ]]; then
            # ignore non .cs files
            continue
        fi

        python beautifier.py -f "$entry" -c "$controller"
    done
}

# Generate code for services
generate() {   
    while IFS= read -r line; do
        # ignore empty lines and comments
        if [[ -z "$line" || "$line" == "#"* ]]; then
            continue
        fi

        log "$line.." 1

        local specification="$BASE_URL$line$POST_URL"

        # get the project name
        local api_proj_name=$(curl -s $specification | jq -r '.info.title')

        # only need the last part for sdk proj name
        local last_part=$(echo "$api_proj_name" | sed 's/.*\.//')

        local sdk_proj_name="$BASE_PROJ_NAME.$last_part"

        # generate code
        $CLI generate \
            -g csharp \
            -c "$GEN_CFG" \
            -o "$GEN_OUT" \
            -t "$TMPL_DIR" \
            --package-name "$sdk_proj_name" \
            -i "$specification"

        # generate project in src dir
        local sdk_proj_folder="$SRC_DIR/$sdk_proj_name"
        local sdk_proj_file="$sdk_proj_folder/$sdk_proj_name.csproj"
        rm -rf "$sdk_proj_folder"
        dotnet new classlib -o "$sdk_proj_folder"
        rm -rf "$sdk_proj_folder/Class1.cs"
        
        # add project to solution
        dotnet sln "$SLN_FILE" add "$sdk_proj_file"
        # add assembly ref -> base proj
        dotnet add "${sdk_proj_file}" reference "${BASE_PROJ_FILE}"

        # move generated files to proper project(s)
        # Boiler Plate
        rec_replace "$GEN_OUT/src/$sdk_proj_name"                           "$sdk_proj_name"    "$BASE_PROJ_NAME"
        mv -f "$GEN_OUT/src/$sdk_proj_name/Model/ProblemDetails.cs"         "$BASE_PROJ_FOLDER"
        mv -f "$GEN_OUT/src/$sdk_proj_name/Model/AbstractOpenAPISchema.cs"  "$BASE_PROJ_FOLDER"
        mv -f "$GEN_OUT/src/$sdk_proj_name/Client"/*                        "$BASE_PROJ_FOLDER"

        # SDK specific
        # insert using for base project
        rec_replace "$GEN_OUT/src/$sdk_proj_name" "namespace $BASE_PROJ_NAME"   "using $BASE_PROJ_NAME;\n\nnamespace $sdk_proj_name" "cs"
        mv -f "$GEN_OUT/src/$sdk_proj_name/Api"/*   "$sdk_proj_folder"
        mkdir -p "$sdk_proj_folder/Model"
        mv -f "$GEN_OUT/src/$sdk_proj_name/Model"/* "$sdk_proj_folder/Model"

        # fix function names
        log "Fixing bad function names.." 0
        fix_function_names "$sdk_proj_folder" "$last_part"
        log "..done" 2


        # move docs to doc dir
        mv -f "$GEN_OUT/docs"/* "$DOC_DIR"
    done < "$SVC_FILE"

    rm -rf "$GEN_OUT"
}


#############################################
#               SCRIPT START                #
#############################################
npm install $CLI -D
npx $CLI version-manager set 7.0.1

mkdir -p "$SRC_DIR"
mkdir -p "$DOC_DIR"

# generate solution and base project
dotnet new sln -n "$BASE_PROJ_NAME" -o "$SRC_DIR"
dotnet new classlib -o "$SRC_DIR/$BASE_PROJ_NAME"
dotnet sln "$SLN_FILE" add "$BASE_PROJ_FILE"
rm -rf "$BASE_PROJ_FOLDER/Class1.cs"

# add required packages
for pkg in "${BASE_PROJ_DEPS[@]}"; do
    dotnet add "$BASE_PROJ_FILE" package "$pkg"
done

log "Generating SDKs.." 0
generate
log "..done" 2

# npm remove $CLI -D
log "All done!" 2
