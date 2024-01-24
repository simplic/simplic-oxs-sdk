import subprocess
import sys


def cmd(cmd: str, echo: bool = False, raise_on_error=False):
    """Runs a command.

    Args:
        cmd (str): command to be run
        echo (bool, optional): print command to the terminal. Defaults to False.
    """
    if echo:
        print(f"> {cmd}")
    try:
        # if sys.platform.startswith('linux') or sys.platform.startswith('darwin'):
        #     subprocess.run(cmd, shell=True, check=raise_on_error)
        # else:
        #     subprocess.run(cmd, check=raise_on_error)

        # due to path problems on windows with shell=False, shell is now set to True either way
        subprocess.run(cmd, shell=True, check=raise_on_error)

    except Exception as e:
        print(f"Execution of command '{cmd}' failed")
        raise e
