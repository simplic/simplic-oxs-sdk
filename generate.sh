ORANGE="\033[0;33m"
YELLOW="\033[1;33m"
GREEN="\033[0;32m"
LGREEN="\033[1;32m"
DGRAY="\033[1;30m"
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
        # not a pathectory -> just replace for this file
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

    if [[ "${proj_name}" != "${BASE_PROJ_NAME}" ]]; then
        if [ -d "${path}/Client" ]; then
            mkdir -p "${BASE_PROJ_FOLDER}/Client"
            mkdir -p "${BASE_PROJ_FOLDER}/Model"
            mv -f "${path}/Client"/* "${BASE_PROJ_FOLDER}/Client/"
            mv -f "${path}/Model/ProblemDetails.cs" "${BASE_PROJ_FOLDER}/Model/"
            mv -f "${path}/Model/AbstractOpenAPISchema.cs" "${BASE_PROJ_FOLDER}/Model/"
            rm -rf "${path}/Client"
        fi

        # update namespace refs
        rec_replace "${path}" "${proj_name}.Client" "${BASE_PROJ_NAME}" "cs"

        local proj_file="${SRC_DIR}/${proj_name}/${proj_name}.csproj"

        # and ofc add assembly ref
        dotnet add "${proj_file}" reference "${BASE_PROJ_FILE}"

        # remove no longer necessary packages
        dotnet remove "${proj_file}" package RestSharp
        dotnet remove "${proj_file}" package Polly
    fi
}

main() {
    openapi-generator-cli version-manager set 7.0.1

    # maybe switch to an approach where we check whats generated first and specificly remove that
    rm -rf "${SRC_DIR}"
    rm -rf "${DOC_DIR}"

    mkdir -p "${SRC_DIR}"
    mkdir -p "${DOC_DIR}"

    
    echo -e "<<${YELLOW}GENERATING SDKS..${NC}>>"
    
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

        echo -e ">>${ORANGE}GENERATING SDK FOR ${line}..${NC}<<"
        generate "${BASE_URL}${line}${POST_URL}"
        echo -e ">>${LGREEN}GENERATING SDK FOR ${line}..DONE${NC}<<"
    done < "${SVC_FILE}"

    echo -e "<<${GREEN}GENERATING SDKS..DONE${NC}>>"


    echo -e "<<${YELLOW}MOVING CONTENTS..${NC}>>"
    rm -rf "${GEN_OUT}/src"/*.Test
    mv -f "${GEN_OUT}/docs"/* "${DOC_DIR}"
    mv -f "${GEN_OUT}/src"/* "${SRC_DIR}"
    rm -rf "${GEN_OUT}"
    echo -e "<<${YELLOW}MOVING1 CONTENTS..DONE${NC}>>"

    echo -e "<<${YELLOW}APPLYING POST MODIFICATIONS..${NC}>>"
    for __i in "${SRC_DIR}"/*; do
        local entry=$__i
        echo -e ">>>${YELLOW}${entry}${NC}"
        local proj_name=$(basename "${entry}")
        local proj_file="${entry}/${proj_name}.csproj"

        if [[ ! -f "${proj_file}" ]]; then
            # ignore non-projects
            continue
        fi

        if [[ "${proj_name}" == "${BASE_PROJ_NAME}" ]]; then
            # base proj is to be handled afterwards
            continue
        fi

        # add generated project to solution
        dotnet sln "${SLN_FILE}" add "${proj_file}"

        # move shared boiler plate to base project
        move_boiler_plate "${entry}"

        # fix namespaces due to api-package trick
        rec_replace "${entry}" "${proj_name}\.\." "${proj_name}" "cs"
    done

    # fix namespaces in base project
    rec_replace "${BASE_PROJ_FOLDER}/Client" "${BASE_PROJ_NAME}..*.Client" "${BASE_PROJ_NAME}" "cs"
    rec_replace "${BASE_PROJ_FOLDER}/Client" "${BASE_PROJ_NAME}..*.Model" "${BASE_PROJ_NAME}" "cs"
    rec_replace "${BASE_PROJ_FOLDER}/Model" "${BASE_PROJ_NAME}..*.Client" "${BASE_PROJ_NAME}" "cs"
    rec_replace "${BASE_PROJ_FOLDER}/Model" "${BASE_PROJ_NAME}..*.Model" "${BASE_PROJ_NAME}" "cs"

    # add required packages
    dotnet add "${BASE_PROJ_FILE}" package Newtonsoft.Json
    dotnet add "${BASE_PROJ_FILE}" package RestSharp
    dotnet add "${BASE_PROJ_FILE}" package Polly

    echo -e "<<${YELLOW}APPLYING POST MODIFICATIONS..DONE${NC}>>"
}

main
