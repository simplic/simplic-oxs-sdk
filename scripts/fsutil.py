from fileinput import FileInput
from typing import Any
import os
import shutil
import yaml


def move(path: str, destination: str) -> list[Any] | Any:
    """
    Moves given file(s) or directory to destination (will overwrite existing destination).
    """
    # Check if destination file already exists
    if os.path.isfile(destination):
        os.remove(destination)

    if os.path.isfile(path) and os.path.isdir(destination):
        destination_file = os.path.join(destination, os.path.basename(path))
        if os.path.isfile(destination_file):
            os.remove(destination_file)

    if not path.endswith("/*"):
        try:
            shutil.move(path, destination)
        except shutil.Error:
            # Replace the destination file if it already exists
            os.replace(path, destination)

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
    """
    Removes file or directory.
    """
    if not os.path.exists(path):
        return

    if os.path.isdir(path):
        shutil.rmtree(path)
    else:
        os.remove(path)


def wipe_dir(path: str, keep: list[str] | None = None):
    """
    Wipes a directory, keeping the directory itself but removing the contents.

    Args:
        keep (list[str] | None): names of files that shall not be deleted
    """
    for file_name in os.listdir(path):
        file_path = os.path.join(path, file_name)

        # ignore files that shall be kept
        if keep is not None and file_name in keep:
            continue

        if os.path.isfile(file_path):
            os.remove(file_path)
        elif os.path.isdir(file_path):
            shutil.rmtree(file_path)


def create_directory(path: str, respect_existing: bool = True):
    """
    Creates directory.
    """
    if respect_existing and os.path.exists(path):
        return

    os.makedirs(path)


def replace_in_file(file_path: str, search_term: str, replace_term: str):
    """
    Replaces a term in a file with given term.
    """
    with FileInput(file_path, inplace=True) as file:
        for line in file:
            print(line.replace(search_term, replace_term), end='')


def has_extension(file_path: str, extension: str):
    """
    Whether given (file)path has an extension.
    """
    if extension.startswith('.'):
        return file_path.endswith(extension)

    return file_path.endswith(f".{extension}")


def rec_replace(path: str, old_term: str, new_term: str, file_extension: str | None = None):
    """
    Replaces a term in all files of a directory and it's subdirectories.
    """
    for root, _, files in os.walk(path):
        for file in files:
            file_path = os.path.join(root, file)
            if file_extension and not has_extension(file_path, file_extension):
                continue
            replace_in_file(file_path, old_term, new_term)


def read_yaml(file: str) -> Any:
    """
    Reads a yaml file and parses the contents to an appropriate object.
    """
    with open(file, 'r') as f:
        return yaml.safe_load(f)
