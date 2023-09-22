ORANGE="\033[0;33m"
YELLOW="\033[1;33m"
GREEN="\033[0;32m"
LGREEN="\033[1;32m"
DGRAY="\033[1;30m"
NC="\033[0m"

PKG_NAME="Simplic.OxS.SDK"

GEN_OUT="openapi-out"
GEN_CFG="./config.yaml"
GEN_CMD="openapi-generator-cli generate
            -g csharp
            -c $GEN_CFG
            -o $GEN_OUT
            --api-name-suffix SDK
            --package-name $PKG_NAME
            -i"

SVC_FILE="services"
BASE_URL="https://dev-oxs.simplic.io/"
POST_URL="-api/v1/swagger/v1/swagger.json"

echo -e "<<$YELLOW GENERATING SDKS.. $NC>>"
while IFS= read -r line; do
    # ignore empty lines and comments
    if [[ -z "$line" || "$line" == "#"* ]]; then
        continue
    fi

    echo -e ">>$ORANGE GENERATING SDK FOR $line.. $NC<<"
    $GEN_CMD "$BASE_URL$line$POST_URL"
    echo -e ">>$LGREEN GENERATING SDK FOR $line..DONE $NC<<"
done < "$SVC_FILE"
echo -e "<<$GREEN GENERATING SDKS..DONE $NC>>"

echo -e "<<$YELLOW MOVING CONTENTS.. $NC>>"
# for entry in "$GEN_OUT"/*; do
#     if [ -f "$entry" ]; then
#         echo -e "$DGRAY>$entry"

# maybe switch to an approach where we check whats generated first and specificely remove that
rm -rf "./docs"
rm -rf "./src"

mkdir -p "./docs"
mkdir -p "./src"

mv -f "$GEN_OUT/docs"/* "./docs/"
mv -f "$GEN_OUT/src"/* "./src/"

# modify .sln to remove `src` prefixes
SLN_FILE="$GEN_OUT/$PKG_NAME.sln"
sed -i 's|src/||g' "$SLN_FILE"
mv -f "$SLN_FILE" "./src/"

rm -rf "$GEN_OUT"
echo -e "<<$YELLOW MOVING CONTENTS..DONE $NC>>"
