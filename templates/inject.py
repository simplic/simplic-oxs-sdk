import os

ROOT_DIR = "csharp"


def read_lines(file_path: str) -> list[str]:
    with open(file_path, "r") as file:
        return file.readlines()


def write_lines(file_path: str, lines: list[str]):
    with open(file_path, "w") as file:
        file.writelines(lines)


def find_end_of_usings(lines: list[str]) -> int:
    i = 0
    found_usings = False
    for line in lines:
        if line.startswith("using"):
            found_usings = True
        elif found_usings:
            return i

        i += 1

    return i


def get_line_num(src: str, lines: list[str]) -> int:
    src_lines = read_lines(src)
    first_line = src_lines[0]
    if first_line.startswith("//@"):
        num = int(first_line.split("@")[1])
        return num

    return find_end_of_usings(lines) + 1


def inject_partial(src: str, dst: str):
    src_name = os.path.basename(src)
    src_name_noext, _ = os.path.splitext(src_name)
    partial = f".inject/{src_name_noext}"

    lines = read_lines(dst)
    line_num = get_line_num(src, lines)

    inject_line = "{{" + f">{partial}" + "}}"
    if inject_line in lines[line_num]:
        return

    print(f">injecting '{partial}' into {dst}@{line_num}")

    lines.insert(line_num, f"{inject_line}\n\n")
    write_lines(dst, lines)


def handle_inject(path: str):
    inject_dir = os.path.join(path, ".inject")
    for _, _, files in os.walk(inject_dir):
        for name in files:
            if not name.endswith(".mustache"):
                continue

            name_noext, _ = os.path.splitext(name)
            src = os.path.join(inject_dir, name)
            dst = os.path.join(path, name)
            inject_partial(src, dst)


for root, dirs, _ in os.walk(ROOT_DIR):
    handle_inject(root)

    for name in dirs:
        handle_inject(os.path.join(root, name))
