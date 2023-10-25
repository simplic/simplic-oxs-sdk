#!/bin/bash

# Normalizes all templates to simplic standard
# Just run initially for new template files

rec_replace() {
    local path="$1"
    local old_term="$2"
    local new_term="$3"
    local file_extension="$4"

    if [[ ! -d "${path}" ]]; then
        # not a directory -> just replace for this file
        if [[ ! -z "${file_extension}" ]] && [[ "${entry##*.}" != "${file_extension}" ]]; then
            # only replace for file having given extension
            return 1
        fi

        echo "> $path"
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

            echo "> $entry"
            sed -i "s#${old_term}#${new_term}#g" "${entry}"
        done
    fi
}

echo ">> Normalizing.."

DIR="./csharp"

# Files in Client/ are boiler plate and belong to the base project
# Normalize namespaces & usages to remove unwanted suffixes
rec_replace "$DIR" "namespace {{packageName}}.Client"       "namespace {{packageName}}" "mustache"
rec_replace "$DIR" "{{packageName}}.Client\."               "{{packageName}}."          "mustache"
rec_replace "$DIR" "{{packageName}}.Client;"                "{{packageName}};"          "mustache"
rec_replace "$DIR" "{{packageName}}.Test.Client"            "{{packageName}}.Test"      "mustache"
rec_replace "$DIR" "{{packageName}}.Test.Api"               "{{packageName}}.Test"      "mustache"
rec_replace "$DIR" "{{packageName}}.Test.{{apiPackage}}"    "{{packageName}}.Test"      "mustache"
rec_replace "$DIR" "{{packageName}}.{{apiPackage}}"         "{{packageName}}"           "mustache"
rec_replace "$DIR" ".{{modelPackage}}"                      ""                          "mustache"

echo ">> Done!"
