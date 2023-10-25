import re
import shutil
from dataclasses import dataclass
from argparse import ArgumentParser, Namespace

DEBUG = False

# preserve old file
PRESERVE = False


@dataclass
class ParamMeta:
    _type: str
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


def get_keywords(param: str) -> list[str]:
    """
    Gets keywords from param.
    Expects param to be of format `[<keywords..> ]<type> <name>[ = <default>]`.
    """
    keywords = ["in", "out", "ref", "readonly", "params"]
    result = []
    for part in param.split(' '):
        if part not in keywords:
            # end of keyword section
            return result
        result.append(part)

    return result


def parse_params(s: str) -> list[ParamMeta]:
    # remove surrounding parens and whitespaces
    s = s[1:-1].strip()
    if s == "":
        return []

    # -- How params can look like --
    # Pattern 1: basic
    #   Type name[[ = default(Type)]]
    #   0: Type ; 1: name [[; 2: = ; 3: default(Type)]]
    #
    # Pattern 2: additional keywords
    #   kw Type name
    #   0: kw ; 1: Type ; 2: name
    #
    # Pattern 3: additional keywords combined
    #   kw kw Type name
    #   0: kw ; 1: kw ; 2: Type ; 3: name
    #
    # Pattern 4: decorators
    #   [Decorator]Type name[[ = default(Type)]]
    #   0: [Decorator]Type ; 1: name [[; 2: = ; 3: default(Type)]]
    #
    # Pattern 5: decorators with spaces
    #   [Decorator] Type name[[ = default(Type)]]
    #   0: [Decorator] ; 1: Type ; 2: name [[; 3: = ; 4: default(Type)]]
    #
    # Pattern 6: decorators + keywords
    #   [Decorator]out|ref Type name
    #   0: [Decorator]out ; 1: Type ; 2: name
    #
    # Pattern 7: decorators with spaces + keywords
    #   [Decorator] out|ref Type name
    #   0: [Decorator] ; 1: out ; 2: Type ; 3: name

    # remove decorators to get rid off decorator patterns
    s = re.sub(r"\[(.*?)\]\s*", "", s)
    segments = s.split(", ")
    metas = []
    for segment in segments:
        keywords = get_keywords(segment)
        # remove keywords to get rid off keyword patterns
        for kw in keywords:
            segment = re.sub(rf"^({kw})\s*", "", segment)

        parts = segment.split(' ')
        try:
            _type = parts[0]
            name = parts[1]
            is_optional = False
            default_value = None
            if len(parts) > 2:
                is_optional = True
                default_value = parts[3]
        except IndexError:
            raise Exception(f"Unexpected params:\n" +
                            f"\t{segments=}\n" +
                            f"\t{segment=}\n" +
                            f"\t{parts=}\n" +
                            f"Param string was: '{s}'")

        metas.append(ParamMeta(
            _type=_type,
            name=name,
            is_optional=is_optional,
            default_value=default_value,
            keywords=keywords
        ))

    return metas


def collect_functions(code: str) -> list[FunctionMeta]:
    """
    Gets all functions from a file.
    """
    valid_name = r"[A-Za-z_][A-Za-z0-9_]*"
    return_type = rf"({valid_name}\.)*{valid_name}(<[^>]*>)?"
    fn_name = r"[A-Z][A-Za-z0-9_]*"
    visibility = r"public"
    accessibility = r"static"
    params = r"\((?:(?!=>)[^;{}])*\)"

    pattern = rf"^\s*({visibility})\s*(new)?\s*({accessibility})?\s*({return_type})\s+({fn_name})\s*({params})"
    metas = []

    # get all functions
    matches = re.findall(pattern, code, re.MULTILINE)

    for match in matches:
        return_type = match[3]
        name = match[6]
        # ignore constructors
        if not return_type or return_type == "" or return_type == visibility:
            continue
        try:
            param_metas = parse_params(match[7])
            metas.append(FunctionMeta(
                return_type=return_type,
                name=name,
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
        shutil.copy(file, f"{file}.ugly")

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
