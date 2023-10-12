from fileinput import FileInput
from os.path import isfile
from typing import Any as MoveInfo
import os
import shutil


def move(path: str, destination: str) -> list[MoveInfo] | MoveInfo:
    # Check if destination file already exists
    if os.path.isfile(destination):
        os.remove(destination)

    if os.path.isfile(path) and os.path.isdir(destination):
        destination_file = os.path.join(destination, os.path.basename(path))
        if os.path.isfile(destination_file):
            os.remove(destination_file)

    if not path.endswith("/*"):
        return shutil.move(path, destination)

    path = path[:-2]

    # Get a list of all files in the source directory
    files_to_move = [
        f
        for f in os.listdir(path)
        if os.path.isfile(os.path.join(path, f))
    ]

    move_infos = []
    # Move each file from the source directory to the destination directory
    for file_name in files_to_move:
        source_file_path = os.path.join(path, file_name)
        destination_file_path = os.path.join(destination, file_name)
        move_infos.append(move(source_file_path, destination_file_path))

    return move_infos


def remove(path: str):
    if not os.path.exists(path):
        return

    if os.path.isdir(path):
        shutil.rmtree(path)
    else:
        os.remove(path)


def create_directory(path: str, respect_existing: bool = True):
    if respect_existing and os.path.exists(path):
        return

    os.makedirs(path)


def replace_in_file(file_path: str, search_term: str, replace_term: str):
    with FileInput(file_path, inplace=True) as file:
        for line in file:
            print(line.replace(search_term, replace_term), end='')


def has_extension(file_path: str, extension: str):
    return os.path.splitext(file_path)[1].lower() == extension.lower()


def rec_replace(path: str, old_term: str, new_term: str, file_extension: str | None = None):
    for root, _, files in os.walk(path):
        for file in files:
            file_path = os.path.join(root, file)
            if file_extension and not has_extension(file_path, file_extension):
                continue
            replace_in_file(file_path, old_term, new_term)
