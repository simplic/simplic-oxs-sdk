import re
from dataclasses import dataclass
from argparse import ArgumentParser, Namespace

DEBUG = True


@dataclass
class ParamMeta:
    _type: str
    name: str


@dataclass
class FunctionMeta:
    return_type: str
    name: str
    params: list[ParamMeta]


def log(*values: object):
    if DEBUG:
        print(*values)


def collect_functions(code: str) -> list[FunctionMeta]:
    """
    Gets all functions from a file.
    """
    valid_name = r"[A-Z][a-zA-Z0-9_]*"
    return_type = rf"({valid_name}\.)*{valid_name}(<[^>]*>)?"
    fn_name = valid_name
    visibility = r"public"
    accessibility = r"static"
    params = r"\([^)]*\)"

    pattern = rf"^\s*({visibility})?\s*({accessibility})?\s*({return_type})\s+({fn_name})\s*({params})\s*"
    metas = []

    # get all functions
    matches = re.findall(pattern, code, re.MULTILINE)

    for match in matches:
        # parse meta
        # remove parens and split args
        params = []
        for ps in match[6][1:-1].split(','):
            parts = ps.split(' ')
            params.append(ParamMeta(parts[0], parts[1]))

        metas.append(FunctionMeta(match[2], match[5], params))

    return metas


def parse_pretty(fn: FunctionMeta, controller_name: str) -> str:
    """
    Returns the decluttered function name 
    """
    log(f"{fn.name=}")
    log(f"{controller_name=}")

    fn_name = fn.name
    if len(fn.params) > 0:
        log(f"{fn=}")
        first_param = fn.params[0].name
        # make pascal case
        first_param = f"{first_param[0].upper()}{first_param[1:]}"
        # remove first param from name
        fn_name = fn.name.replace(first_param, "")

    pattern = rf"({controller_name})([A-Za-z]+)?(Get|Post|Put|Delete|Head|Options|Patch)([A-Za-z]*)?"
    match = re.search(pattern, fn_name)

    if not match:
        log(
            f"<parse_pretty> Failed to regex match function name (already pretty?): `{fn.name}` -> returning given name.")
        return fn.name

    groups_matched = len(match.groups())
    log(f"{groups_matched=}")
    log(f"{match.group(1)=}")
    log(f"{match.group(2)=}")
    log(f"{match.group(3)=}")
    log(f"{match.group(4)=}")

    if groups_matched != 4:
        raise Exception(
            f"<parse_pretty> Unexpected amount of groups: `{groups_matched}`")

    return f"{match.group(2) or match.group(3)}{match.group(4)}"


def main(args: Namespace):
    file = args.file
    log(f"Reading file contents from `{file}`..")
    file_content = None
    with open(file, 'r') as f:
        file_content = f.read()

    fns = collect_functions(file_content)
    for fn in fns:
        log(f"___: `{fn.name}`")
        pretty_name = parse_pretty(fn, args.controller)

        # replace old name
        file_content = file_content.replace(fn.name, pretty_name)

        log(f"-->: `{pretty_name}`\n")

    log(f"Writing changes to `{file}`..")
    with open(file, 'w') as f:
        f.write(file_content)


argparser = ArgumentParser()
argparser.add_argument("-f", "--file", required=True,
                       help="File in which the function names shall be beautified")
argparser.add_argument("-c", "--controller", required=True,
                       help="Name of the controller")
main(argparser.parse_args())
