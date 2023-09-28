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
BASE_PROJ_FOLDER="${SRC_DIR}/${BASE_PROJ_NAME}"
BASE_PROJ_FILE="${BASE_PROJ_FOLDER}/${BASE_PROJ_NAME}.csproj"
SLN_FILE="${SRC_DIR}/${BASE_PROJ_NAME}.sln"

# Packages that are required for the base project 
BASE_PROJ_DEPS=("Newtonsoft.Json" "RestSharp" "Polly")

# Packages that are not required for the other projects and therefore can be removed
RM_PROJ_DEPS=("RestSharp" "Polly")

# Logging
log() {
    msg="$1"
    variation=$2

    case $variation in
        0)
            echo -e "${LMAGENTA}[[${LYELLOW} ${msg} ${LMAGENTA}]]${NC}"
            ;;
        1)
            echo -e "${LMAGENTA}>>${YELLOW} ${msg}${NC}"
            ;;
        2)
            echo -e "${LMAGENTA}[[${LGREEN} ${msg} ${LMAGENTA}]]${NC}"
            ;;
        *)
            echo -e "${LMAGENTA}[[${YELLOW} ${msg} ${LMAGENTA}]]${NC}"
            ;;
    esac
}

# Necessary pre-conditions
prepare() {
    openapi-generator-cli version-manager set 7.0.1

    # maybe switch to an approach where we check whats generated first and specificly remove that
    rm -rf "${SRC_DIR}"
    rm -rf "${DOC_DIR}"

    mkdir -p "${SRC_DIR}"
    mkdir -p "${DOC_DIR}"

}

# Generate the openapi sdk
generate() {
    local specification="$1"

    # get the project name
    local proj_name=$(curl -s ${specification} | jq -r '.info.title')

    # only need the last part for sdk proj name
    local last_part=$(echo "${proj_name}" | sed 's/.*\.//')
    local sdk_proj_name="${BASE_PROJ_NAME}.${last_part}"

    openapi-generator-cli generate \
        -g csharp \
        -c "${GEN_CFG}" \
        -o "${GEN_OUT}" \
        --package-name "${sdk_proj_name}" \
        --api-package "." \
        -i "${specification}"
}

# Recursively replace a term
rec_replace() {
    local path="$1"
    local old_term="$2"
    local new_term="$3"
    local file_extension="$4"

    if [[ ! -d "${path}" ]]; then
        # not a directory -> just replace for this file
        sed -i "s#${old_term}#${new_term}#g" "${path}"
    else
        for __i in "$path"/*; do
            local entry=$__i
            if [[ -d "${entry}" ]]; then
                # recurse
                rec_replace "${entry}" "${old_term}" "${new_term}" "${file_extension}"
                continue
            fi

            if [[ ! -z "${file_extension}" ]] && [[ "${entry##*.}" != "${file_extension}" ]]; then
                # only replace for file having given extension
                continue
            fi

            sed -i "s#${old_term}#${new_term}#g" "${entry}"
        done
    fi
}

# Move all common boiler plate to base project
move_boiler_plate() {
    local path="$1"
    local proj_name=$(basename "${path}")
    local proj_file="${SRC_DIR}/${proj_name}/${proj_name}.csproj"

    [[ "${proj_name}" == "${BASE_PROJ_NAME}" ]] && return 1 

    if [[ -d "${path}/Client" ]]; then
        mkdir -p "${BASE_PROJ_FOLDER}/Client"
        mv -f "${path}/Client"/* "${BASE_PROJ_FOLDER}/Client/"
        rm -rf "${path}/Client"
    fi

    if [[ -d "${path}/Model" ]]; then
        mkdir -p "${BASE_PROJ_FOLDER}/Model"
        mv -f "${path}/Model/ProblemDetails.cs" "${BASE_PROJ_FOLDER}/Model/"
        mv -f "${path}/Model/AbstractOpenAPISchema.cs" "${BASE_PROJ_FOLDER}/Model/"
    fi

    # update namespace refs
    rec_replace "${path}" "${proj_name}.Client" "${BASE_PROJ_NAME}" "cs"

    # and ofc add assembly ref
    dotnet add "${proj_file}" reference "${BASE_PROJ_FILE}"

    # remove no longer necessary packages
    for __i in "${RM_PROJ_DEPS[@]}"; do
        dotnet remove "${proj_file}" package "${__i}"
    done
}

main() {
    prepare
    
    log "Generating SDKs.." 0
    
    # generate the solution along with base project
    dotnet new sln -n "${BASE_PROJ_NAME}" -o "${SRC_DIR}"
    dotnet new classlib -o "${SRC_DIR}/${BASE_PROJ_NAME}"
    dotnet sln "${SLN_FILE}" add "${BASE_PROJ_FILE}"
    rm -rf "${BASE_PROJ_FOLDER}/Class1.cs"

    # iterate through services
    while IFS= read -r line; do
        # ignore empty lines and comments
        if [[ -z "${line}" || "${line}" == "#"* ]]; then
            continue
        fi

        log "${line}.." 1
        generate "${BASE_URL}${line}${POST_URL}"
    done < "${SVC_FILE}"

    log "..done" 2

    log "Moving Contents.." 0

    rm -rf "${GEN_OUT}/src"/*.Test
    mv -f "${GEN_OUT}/docs"/* "${DOC_DIR}"
    mv -f "${GEN_OUT}/src"/* "${SRC_DIR}"
    rm -rf "${GEN_OUT}"
    
    log "..done" 2

    log "Applying post modifications.." 0

    for __i in "${SRC_DIR}"/*; do
        local entry=$__i
        local proj_name=$(basename "${entry}")
        local proj_file="${entry}/${proj_name}.csproj"

        log "${entry}" 1

        # ignore non-projects
        [[ ! -f "${proj_file}" ]] && continue

        # base proj is to be handled afterwards
        [[ "${proj_name}" == "${BASE_PROJ_NAME}" ]] && continue

        # add generated project to solution
        dotnet sln "${SLN_FILE}" add "${proj_file}"

        # move shared boiler plate to base project
        move_boiler_plate "${entry}"

        # fix namespaces due to api-package trick
        rec_replace "${entry}" "${proj_name}\.\." "${proj_name}" "cs"
    done

    # fix namespaces in base project
    local subfolders=("Client" "Model")
    for __i in "${subfolders[@]}"; do
        local subfolder="${__i}"
        rec_replace "${BASE_PROJ_FOLDER}/${subfolder}" "${BASE_PROJ_NAME}..*.Client" "${BASE_PROJ_NAME}" "cs"
        rec_replace "${BASE_PROJ_FOLDER}/${subfolder}" "${BASE_PROJ_NAME}..*.Model" "${BASE_PROJ_NAME}" "cs"
    done

    # add required packages
    for __i in "${BASE_PROJ_DEPS[@]}"; do
        local pkg="${__i}"
        dotnet add "${BASE_PROJ_FILE}" package "${pkg}"
    done

    log "..done" 2

    log "All done!" 2
}

main
