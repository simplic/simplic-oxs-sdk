from dataclasses import dataclass
from datetime import datetime
from enum import Enum
from urllib.parse import urlparse
import subprocess

class Color:
    RESET = '\033[0m'
    BOLD = '\033[1m'
    UNDERLINE = '\033[4m'
    RED = '\033[91m'
    GREEN = '\033[92m'
    YELLOW = '\033[93m'
    BLUE = '\033[94m'
    MAGENTA = '\033[95m'
    CYAN = '\033[96m'

@dataclass
class Package:
    name: str
    version: str | None

    def __init__(self, name: str, version: str | None = None) -> None:
        self.name = name
        self.version = version
        
class LogLevel(Enum):
    DEBUG = 0,
    INFO = 1,
    WARN = 2,
    ERROR = 3,

class Logger:
    level: LogLevel
    prefix: str
    log_time: bool
    
    def __init__(self, level: LogLevel = LogLevel.DEBUG, prefix: str | None = None, log_time: bool = False):
        self.level = level
        self.prefix = prefix
        self.log_time = log_time
        
    def log(self, level: LogLevel, *values: object):
        """Logs a message with given loglevel.

        Args:
            level (LogLevel): log level
        """
        if (level.value < self.level.value):
            return
        
        time = f"{datetime.now().time()} " if self.log_time else ""
        prefix = f"@{self.prefix}" if self.prefix else ""
        match level:
            case LogLevel.DEBUG:
                level_prefix = f"{Color.MAGENTA}{level.name}{Color.RESET}"
            case LogLevel.INFO:
                level_prefix = f"{Color.GREEN}{level.name}{Color.RESET}"
            case LogLevel.WARN:
                level_prefix = f"{Color.YELLOW}{level.name}{Color.RESET}"
            case LogLevel.ERROR:
                level_prefix = f"{Color.RED}{level.name}{Color.RESET}"
            case _:
                level_prefix = level.name    
        print(f"{time}[{level_prefix}{prefix}]", *values)
    
    def debug(self, *values: object):
        if (LogLevel.DEBUG.value < self.level.value):
            return
        
        self.log(LogLevel.DEBUG, *values)
    
    def info(self, *values: object):
        if (LogLevel.INFO.value < self.level.value):
            return
        
        self.log(LogLevel.INFO, *values)
        
    def warn(self, *values: object):
        if (LogLevel.WARN.value < self.level.value):
            return
        
        self.log(LogLevel.WARN, *values)
        
    def error(self, *values: object):
        if (LogLevel.ERROR.value < self.level.value):
            return
        
        self.log(LogLevel.ERROR, *values)
    

def cmd(cmd: str, echo: bool = False, raise_on_error=False, show_stdout=True):
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
        if show_stdout:
            subprocess.run(cmd, shell=True, check=raise_on_error)
        else:
            subprocess.run(cmd, shell=True, check=raise_on_error, stdout=subprocess.PIPE)
            

    except Exception as e:
        print(f"Execution of command '{cmd}' failed")
        raise e

def to_pascal_case(s: str) -> str:
    """Converts string to PascalCase.

    Args:
        s (str): string

    Returns:
        str: PascalCase string
    """
    if len(s) < 2:
        return s.capitalize()

    return f"{s[0].upper()}{s[1:]}"

def hyphen_to_dcap(s: str) -> str:
    """Turns any hyphen-case into Dotted.Capitalized.
    
    Example: this-is-an-example -> This.Is.An.Example
    
    Args:
        s (str): hyphen-case-string
    
    Returns:
        str: Dotted.Capitalized.String
    """
    sections = s.split("-")
    sections = [f"{section[0].upper()}{section[1:]}" for section in sections]

    # ensure every first char after . is capital
    sections = ".".join(sections).split(".")
    sections = [f"{section[0].upper()}{section[1:]}" for section in sections]

    return ".".join(sections)

def is_url(s: str) -> bool:
    """Whether given string is a URL.

    Args:
        s (str): string

    Returns:
        bool: True if URL, False else
    """
    try:
        result = urlparse(s)
        return all([result.scheme, result.netloc])
    except ValueError:
        return False