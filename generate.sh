ORANGE="\033[0;33m"
YELLOW="\033[1;33m"
GREEN="\033[0;32m"
LGREEN="\033[1;32m"
DGRAY="\033[1;30m"
NC="\033[0m"

PKG_BASE="Simplic.OxS.SDK"

GEN_OUT="openapi-out"
GEN_CFG="./config.yaml"

SVC_FILE="services"
BASE_URL="https://dev-oxs.simplic.io/"
POST_URL="-api/v1/swagger/v1/swagger.json"

generate ()
{
    specification=$1

    # get the project name
    proj_name=$(curl -s $specification | jq -r '.info.title')
    
    # only need the last part for sdk proj name
    last_part=$(echo "$proj_name" | sed 's/.*\.//')
    sdk_proj_name="$PKG_BASE.$last_part"

    openapi-generator-cli version-manager set 7.0.1
    openapi-generator-cli generate \
        -g csharp \
        -c "$GEN_CFG" \
        -o "$GEN_OUT" \
        --package-name "$sdk_proj_name" \
        -i "$specification"
}

# maybe switch to an approach where we check whats generated first and specificly remove that
rm -rf "./docs"
rm -rf "./src"

mkdir -p "./docs"
mkdir -p "./src"

echo -e "<<$YELLOW GENERATING SDKS.. $NC>>"
# generate the solution
dotnet new sln -n "$PKG_BASE" -o "./src/"

# iterate through services
while IFS= read -r line; do
    # ignore empty lines and comments
    if [[ -z "$line" || "$line" == "#"* ]]; then
        continue
    fi

    echo -e ">>$ORANGE GENERATING SDK FOR $line.. $NC<<"
    generate "$BASE_URL$line$POST_URL"     
    echo -e ">>$LGREEN GENERATING SDK FOR $line..DONE $NC<<"
done < "$SVC_FILE"
echo -e "<<$GREEN GENERATING SDKS..DONE $NC>>"

echo -e "<<$YELLOW MOVING CONTENTS.. $NC>>"

mv -f "$GEN_OUT/docs"/* "./docs/"
mv -f "$GEN_OUT/src"/* "./src/"

rm -rf "$GEN_OUT"
echo -e "<<$YELLOW MOVING CONTENTS..DONE $NC>>"

# add generated projects to our solution
echo -e "<<$YELLOW ADDING PROJECTS TO SOLUTION.. $NC>>"
pushd src
for entry in *; do
    if [ -f "$entry/$entry.csproj" ]; then
        echo -e "$DGRAY$entry"
        dotnet sln "$PKG_BASE.sln" add "$entry/$entry.csproj"
    fi
done
popd
echo -e "<<$YELLOW ADDING PROJECTS TO SOLUTION..DONE $NC>>"

