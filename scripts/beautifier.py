#
# Script for 'beautifying' the functions of openapi generated clients.
# Currently only works for C#.
#

from dataclasses import dataclass
from argparse import ArgumentParser, Namespace
import os
import re
import shutil

DEBUG = False

# preserve old file
PRESERVE = False
PRESERVED_FILE_EXT = "ugly.cs"

# Regex patterns
RX_DECORATOR = r"\[(?:.*?)\]\s*"
RX_DEFAULT_ARG = r"[A-Za-z0-9_\(\)\?]*"
RX_FN_NAME = r"[A-Z][A-Za-z0-9_]*"
RX_FN_ARGS = r"\((?:(?!=>)[^;{}])*\)"
RX_KEYWORD = r"\b(?:in|out|ref|readonly|params)\b"
RX_NAME = r"[A-Za-z_][A-Za-z0-9_]*"
RX_TYPE = fr"(?:{RX_NAME}\.)*{RX_NAME}(?:<[^>]*>)?\??"


@dataclass
class ParamMeta:
    type: str
    name: str
    is_optional: bool
    default_value: str | None
    keywords: list[str]


@dataclass
class FunctionMeta:
    return_type: str
    name: str
    params: list[ParamMeta]


def log(*values: object):
    if DEBUG:
        print(*values)


def parse_params(s: str) -> list[ParamMeta]:
    """
    Takes a string which represents the parameter segment of a function
    such as `(string s)` and parses it into a list of `ParamMeta`.

    Args:
        s (str): parameter segment

    Raises:
        Exception: raised when given parameter string is malformed

    Returns:
        list[ParamMeta]: list of parameters
    """
    s = s[1:-1].strip()
    if s == "":
        return []

    params = s.split(',')
    pattern = fr"({RX_DECORATOR})?\s*({RX_KEYWORD}\s+)?({RX_KEYWORD}\s+)?({RX_TYPE}\s+)({RX_NAME})\s*(=)?\s*({RX_DEFAULT_ARG})?"

    metas = []
    for param in params:
        param = param.strip()
        match = re.match(pattern, param)
        if not match:
            print(f"\nno match for `{param}`\npattern: `{pattern}`\n")
            continue

        kw1 = match[2]
        kw2 = match[3]
        type = match[4].strip()
        name = match[5].strip()
        has_default = match[6] is not None
        defv = match[7].strip() if has_default else None
        meta = ParamMeta(
            type=type,
            name=name,
            is_optional=has_default,
            default_value=defv,
            keywords=[kw.strip() for kw in [kw1, kw2] if kw is not None]
        )
        metas.append(meta)

    return metas


def collect_functions(code: str) -> list[FunctionMeta]:
    """
    Gets all functions from a file.
    """
    visibility = r"public"
    accessibility = r"static"

    pattern = rf"^\s*({visibility})\s*(new)?\s*({accessibility})?\s*({RX_TYPE})\s+({RX_FN_NAME})\s*({RX_FN_ARGS})"
    metas = []

    # get all functions
    matches = re.findall(pattern, code, re.MULTILINE)

    for match in matches:
        return_type = match[3]
        # ignore constructors
        if not return_type or return_type == "" or return_type == visibility:
            continue
        try:
            param_metas = parse_params(match[5])
            metas.append(FunctionMeta(
                return_type=return_type,
                name=match[4],
                params=param_metas
            ))
        except Exception as e:
            raise Exception(f"Probably malformed match: {match=}\n" +
                            f"Used regex: '{pattern}'\n"
                            f"Inner exception: {e}")

    return metas


def parse_pretty(fn: FunctionMeta, controller_name: str) -> str:
    """
    Returns the decluttered function name 
    """
    log(f"{fn.name=}")
    log(f"{controller_name=}")

    fn_name = fn.name

    # [experimental] remove first param name from function name
    # Note: it appears that the first param name is always inserted when..
    # .. A) it has no default value (non-optional)
    # .. B) it is != operationIndex
    if len(fn.params) > 0 and fn.params[0].name != "operationIndex" and not fn.params[0].is_optional:
        log(f"{fn=}")
        first_param = fn.params[0].name
        # make pascal case
        first_param = f"{first_param[0].upper()}{first_param[1:]}"
        fn_name = fn.name.replace(first_param, "", 1)

    pattern = rf"({controller_name})([A-Za-z]+)?(Get|Post|Put|Delete|Head|Options|Patch)([A-Za-z]*)?"
    match = re.search(pattern, fn_name)

    if not match:
        log("<parse_pretty> Failed to regex match function name (already pretty?):" +
            f" `{fn.name}` -> returning given name.")
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
    controller = args.controller
    log(f"Reading file contents from `{file}`..")
    file_content = None
    with open(file, 'r') as f:
        file_content = f.read()

    if PRESERVE:
        path, full_file_name = os.path.split(file)
        file_name, file_extension = os.path.splitext(full_file_name)
        shutil.copy(
            file,
            f"{os.path.join(path, file_name)}.{PRESERVED_FILE_EXT}"
        )

    for fn in collect_functions(file_content):
        log(f"___: `{fn.name}`")
        pretty_name = parse_pretty(fn, controller)

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
