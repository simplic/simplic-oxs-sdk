import subprocess
import sys


def cmd(cmd: str, echo: bool = False):
    """Runs a command.

    Args:
        cmd (str): command to be run
        echo (bool, optional): print command to the terminal. Defaults to False.
    """
    if echo:
        print(f"> {cmd}")
    if sys.platform.startswith('linux') or sys.platform.startswith('darwin'):
        subprocess.run(cmd, shell=True)
    else:
        subprocess.run(cmd)

