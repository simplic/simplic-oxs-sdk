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


def collect_functions(path_to_file: str) -> list[FunctionMeta]:
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
    functions = []

    # get all functions
    with open(path_to_file, "r") as file:
        content = file.read()
        matches = re.findall(pattern, content, re.MULTILINE)

        for match in matches:
            functions.append(match)

    metas = []

    # parse meta
    for signature in functions:
        # remove parens and split args
        params_strings = signature[6][1:-1].split(',')
        params = []
        for ps in params_strings:
            parts = ps.split(' ')
            params.append(ParamMeta(parts[0], parts[1]))

        metas.append(FunctionMeta(signature[2], signature[5], params))

    return metas


def parse_pretty(fn: FunctionMeta, controller_name: str) -> str:
    """
    Returns the decluttered function name 
    """
    if len(fn.params) > 0:
        log(f"{fn=}")
        first_param = fn.params[0].name
        # make pascal case
        first_param = f"{first_param[0].upper()}{first_param[1:]}"
        # remove first param from name
        fn.name = fn.name.replace(first_param, "")

    pattern = rf"({controller_name})([A-Za-z]+)?(Get|Post|Put|Delete|Head|Options|Patch)([A-Za-z]*)?"
    matches = re.findall(pattern, fn.name)

    # get parts for function name
    parts = []
    for match in matches:
        log(f"{match=}")
        operation = match[1]
        http_method = match[2]
        suffix = match[3]
        if not suffix:
            suffix = ""

        if operation:
            parts.append(f"{operation}{suffix}")
        else:
            parts.append(f"{http_method}{suffix}")

    # concat parts
    return ''.join(parts)


def main(args: Namespace):
    for fn in collect_functions(args.file):
        log("___:", fn.name)
        pretty_name = parse_pretty(fn, args.controller)
        with open(args.file, 'r') as file:
            file_content = file.read()

        # replace old name
        file_content = file_content.replace(fn.name, pretty_name)
        with open(args.file, 'w') as file:
            file.write(file_content)

        log("-->:", pretty_name, "\n")


argparser = ArgumentParser()
argparser.add_argument("-f", "--file", required=True,
                       help="File in which the function names shall be beautified")
argparser.add_argument("-c", "--controller", required=True,
                       help="Name of the controller")
main(argparser.parse_args())
