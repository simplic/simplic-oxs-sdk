from enum import Enum
import core
import fsutil
import os
import xml.etree.ElementTree as ET


class Configuration(Enum):
    RELEASE = 1
    DEBUG = 2

    def __str__(self) -> str:
        return "Release" if self == Configuration.RELEASE else "Debug"


def get_assembly_version(proj_file: str, configuration: Configuration) -> str | None:
    """Gets the assembly version from a C# project file.

    Args:
        proj_file (str): full path to the project file
        configuration (Configuration): release configuration (Release | Debug)

    Returns:
        str | None: assembly version or None if no version was found
    """
    tree = ET.parse(proj_file)
    root = tree.getroot()

    # Find the PropertyGroup for the Release configuration (you can change it for other configurations)
    release_property_group = root.find(
        f".//PropertyGroup[Configuration='{configuration}']"
    )

    if release_property_group is not None:
        # Find the AssemblyVersion element
        assembly_version_element = release_property_group.find(
            ".//AssemblyVersion"
        )

        if assembly_version_element is not None:
            # Get the assembly version
            assembly_version = assembly_version_element.text
            return assembly_version
        else:
            return None


def set_assembly_version(proj_file: str, version: str, configuration: Configuration):
    """Sets the assembly version of a C# project file.

    Args:
        proj_file (str): full path to the project file
        version (str): version to be set
        configuration (Configuration): release configuration (Release | Debug)
    """
    tree = ET.parse(proj_file)
    root = tree.getroot()

    # Find the PropertyGroup for the Release configuration
    release_property_group = root.find(
        f".//PropertyGroup[Configuration='{configuration}']"
    )

    if release_property_group is not None:
        # Update the AssemblyVersion
        assembly_version_element = release_property_group.find(
            ".//AssemblyVersion"
        )
        if assembly_version_element is not None:
            assembly_version_element.text = version

        # Save the changes back to the .csproj file
        tree.write(proj_file)


def create_solution(src_dir: str, name: str):
    """
    Generates solution along with base project and its dependencies.
    """
    sln_file = f"{src_dir}/{name}.sln"

    # remove existing
    fsutil.remove(sln_file)

    # create solution
    core.cmd(f"dotnet new sln -n {name} -o {src_dir}")


def create_project(type: str, path: str, framework: str, dependencies: list[str] | None = None):
    proj_name = os.path.basename(path)
    proj_file = os.path.join(path, f"{proj_name}.csproj")

    # remove existing
    fsutil.remove(path)

    # create project
    core.cmd(f"dotnet new {type} -o {path} --framework {framework}" +
             f" --langVersion latestMajor")
    if os.path.exists(f"{path}/Class1.cs"):
        fsutil.remove(f"{path}/Class1.cs")

    # add dependencies
    if dependencies is not None:
        for dep in dependencies:
            core.cmd(f"dotnet add {proj_file} package {dep}")


def add_project_to_solution(sln_file: str, proj_file: str):
    """Adds project to solution"""
    core.cmd(f"dotnet sln {sln_file} add {proj_file}")


def add_project_reference(proj_file: str, ref_proj_file: str):
    """Adds assembly reference to project"""
    core.cmd(f"dotnet add {proj_file} reference {ref_proj_file}")
