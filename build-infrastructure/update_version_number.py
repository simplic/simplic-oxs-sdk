import git
import os
import json
import glob
from pathlib import Path
import re
import DatabaseStatements
from datetime import date
import pyodbc
import argparse
import subprocess
import sys
import lxml.etree as ET
from lxml import etree
import uuid
from github import Github
import github
from packaging.version import parse
import unicodedata
import itertools

class KillPipelineException(Exception):
    pass


class Changes:
    """
    Data holder class for changes in a commit
    """
    def __init__(self):
        self.additions = []
        self.deletions = []

    def __repr__(self):
        return f'Additions: {len(self.additions)}, Deletions: {len(self.deletions)}'
 

def remove_control_chars(s):
    all_chars = (chr(i) for i in range(sys.maxunicode))
    categories = {'Cc'}
    control_chars = ''.join(c for c in all_chars if unicodedata.category(c) in categories)
    # or equivalently and much more efficiently
    control_chars = ''.join(map(chr, itertools.chain(range(0x00,0x20), range(0x7f,0xa0))))
    control_char_re = re.compile('[%s]' % re.escape(control_chars))
    return control_char_re.sub('', s)
    
    

def get_changed_files(git_diff):
    """
    Returns the git diff between HEAD and HEAD^1 commit as a dict of form: {WindowsPath: Changes object}
    """
    _changed_files = {}
    for change in git_diff.split('diff --git ')[1:]:
        file_name = re.search(r'b/.*\n', change).group(0).split('b/')[1].strip('\n') # in case of rename only the new file name
        changes = Changes()
        _changed_files[Path(file_name)] = changes

        for changed_line in change.split('\n'):
            if changed_line: # Empty lines will throw exception in line below
                if all(x not in changed_line[:3] for x in ['---', '+++', '+-', '-+']):
                    if changed_line[0] == '+':
                        changes.additions.append(re.sub(r'[+\t\r\ufeff]', '', changed_line))
                    elif changed_line[0] == '-':
                        changes.deletions.append(re.sub(r'[-\t\r\ufeff]', '', changed_line))

    return _changed_files


def get_dirs_with_changes(last_commit_changes):
    """
    Returns the project root directories whos source files (*.cs) were in the HEAD commit
    """
    _dirs_with_changes = set()
    for change in last_commit_changes:
        if ' => ' in change:
            split = re.split(r'{|}', change)
            file_extension = split[-1].split('.')[-1]

            if file_extension == 'cs':
                rest_path = re.search(r'(.*)(/.+\.cs)', split[-1]).group(1)
                old_dir = split[0] + split[1].split(' => ')[0] + rest_path
                _dir = split[0] + split[1].split(' => ')[1] + rest_path

                _dirs_with_changes.add(Path(old_dir))
                _dirs_with_changes.add(Path(_dir))
        else:
            file_extension = change.split('.')[-1]
            if file_extension == 'cs':
                _dir = re.search(r'(.*)(/.+\.cs)', change).group(1)

                _dirs_with_changes.add(Path(_dir))
    
    return _dirs_with_changes


def dir_contains_AssemblyInfo(project_dir):
    """
    Checks whether the dircectory contains an assembly info.
    """
    AssemblyInfo_path = Path(f'{project_dir}/Properties/AssemblyInfo.cs')
    return os.path.exists(AssemblyInfo_path)


def manual_AssemblyInfo_change(project_dir):
    """
    Checks if the AssemblyInfo.cs for the given project directory was updated in the HEAD commit
    """
    AssemblyInfo_path = Path(f'{project_dir}/Properties/AssemblyInfo.cs')

    if AssemblyInfo_path in changed_files:
        for addition in changed_files[AssemblyInfo_path].additions:
            if re.search(assembly_version_regex, addition) or re.search(assembly_file_version_regex, addition): # if there is a addition change for the version number
                return True
    return False


def manual_Csproj_change(project_dir):
    """
    Checks if the .csproj for the given project directory was updated in the HEAD commit
    """
    filter = f'Filter: {project_dir}/*.csproj'
    print(filter)
    files = glob.glob(f"{project_dir}/*.csproj")
    
    if files[0] in changed_files:
        for addition in changed_files[files[0]].additions:
            if re.search(csproj_version_regex, addition): # if there is a addition change for the version number
                return True
    return False


def manual_Init_change(Init_path):
    """
    Checks if Init.cs was manually updated in the HEAD commit
    """
    if Init_path in changed_files:
        for addition in changed_files[Init_path].additions:
            if re.search(plugin_desc_regex, addition): # if there is a addition change for the version number
                return True
    return False


def manual_InternAssemblyVersion_change():
    """
    Checks if InternAssemblyVersion.cs was manually updated in the HEAD commit
    """
    InternAssemblyVersion_path = Path('src/Shared/InternAssemblyVersion.cs')

    if InternAssemblyVersion_path in changed_files:
        for addition in changed_files[InternAssemblyVersion_path].additions:
            if re.search(intern_assembly_file_version_regex, addition):
                return True
    return False


def updated_version_number(regex_result, commit_type):
    """
    Returns the updated version number as a two tuple of form: 
    (list of new numbers, complete version string to replace the current one with)
    """
    major_version = int(regex_result.group(2))
    minor_version = int(regex_result.group(4))
    patch_version = int(regex_result.group(6)[:-2]) if int(regex_result.group(6)) >= 100 else 0

    if commit_type == 'major':
        major_version += 1
        minor_version = 0
        patch_version = 0
    elif commit_type == 'minor':
        minor_version += 1
        patch_version = 0
    elif commit_type == 'patch':
        patch_version += 1

    new_version_number = [major_version, minor_version]
    new_version_number.append(int(str(patch_version) + str(today_year))) # Build
    new_version_number.append(int(str(today_month) + str(today_day))) # Revision

    new_version_string = f'{regex_result.group(1)}{major_version}.{minor_version}.'
    new_version_string += str(patch_version) if patch_version != 0 else ''
    new_version_string += f'{today_year}.{today_month}{today_day}{regex_result.group(9)}'

    return new_version_number, new_version_string


def update_AssemblyInfo(project_dir):
    """
    Updates the versions in AssemblyInfo.cs
    """
    AssemblyInfo_path = Path(f'{project_dir}/Properties/AssemblyInfo.cs')
    with open(AssemblyInfo_path, 'r+', encoding='utf-8-sig') as f:
        s = f.read()

        assembly_version = re.search(assembly_version_regex, s)
        assembly_file_version = re.search(assembly_file_version_regex, s)

        if assembly_version and assembly_file_version:
            _, new_assembly_version_string = updated_version_number(assembly_version, commit_type)
            _, new_assembly_file_version_string = updated_version_number(assembly_file_version, commit_type)

            s = re.sub(assembly_version_regex, new_assembly_version_string, s)
            s = re.sub(assembly_file_version_regex, new_assembly_file_version_string, s)

            f.seek(0)
            f.write(s)
            f.truncate()

            print(f'Updated assembly version @ {AssemblyInfo_path}!')
            print(f'{assembly_version.group(0)} => {new_assembly_version_string}')
            print_with_seperation(f'{assembly_file_version.group(0)} => {new_assembly_file_version_string}')
        else:
            print_with_seperation(f'Couldent identify current version_numbers via regex. Check {AssemblyInfo_path}.')


def update_Init(Init_path, productname):
    """
    Updates the version in Init.cs and writes the new version to the Database
    """
    with open(Init_path, 'r+', encoding='utf-8-sig') as f:
        s = f.read()

        plugin_desc = re.search(plugin_desc_regex, s)
        if plugin_desc:
            new_plugin_desc_version, new_plugin_desc_version_string = updated_version_number(plugin_desc, commit_type)

            s = re.sub(plugin_desc_regex, new_plugin_desc_version_string, s)

            conn = None
            cur = None
            if(active_branch_name in ('master', 'dev')):
                conn = pyodbc.connect(args['conn_string'])
                cur = conn.cursor()

            DatabaseStatements.insert_version_number(conn, cur, productname, new_plugin_desc_version)
            if(cur != None):
                cur.close()
    
            if(conn != None):
                conn.close()

            f.seek(0)
            f.write(s)
            f.truncate()

            print(f'Updated version @ {Init_path}!')
            print_with_seperation(f'{plugin_desc.group(0)} => {new_plugin_desc_version_string}')

            return new_plugin_desc_version
        else:
            print_with_seperation(f'Couldent identify current version number via regex. Check {Init_path}.')


def update_InternAssemblyVersion():
    """
    Updates the versions in InternAssemblyVersion.cs and writes the new version to the Database
    """
    InternAssemblyVersion_path = Path('src/Shared/InternAssemblyVersion.cs')
    with open(InternAssemblyVersion_path, 'r+', encoding='utf-8-sig') as f:
        s = f.read()

        intern_assembly_file_version = re.search(intern_assembly_file_version_regex, s)
        if intern_assembly_file_version:
            new_intern_assembly_file_version, new_intern_assembly_file_version_string = updated_version_number(intern_assembly_file_version, commit_type)

            s = re.sub(intern_assembly_file_version_regex, new_intern_assembly_file_version_string, s)
            
            conn = None
            cur = None

            if(active_branch_name in ('master', 'dev')):
                conn = pyodbc.connect(args['conn_string'])
                cur = conn.cursor()

            DatabaseStatements.insert_version_number(conn, cur, productname, new_intern_assembly_file_version)
            
            if(cur != None):
                cur.close()
    
            if(conn != None):
                conn.close()

            f.seek(0)
            f.write(s)
            f.truncate()

            print(f'Updated shared Version @ {InternAssemblyVersion_path}!')
            print_with_seperation(f'{intern_assembly_file_version.group(0)} => {new_intern_assembly_file_version_string}')

            return new_intern_assembly_file_version
        else:
            print_with_seperation(f'Couldent identify current version number via regex. Check {InternAssemblyVersion_path}.')


def update_CsprojVersion(project_dir):
    """
    Updates the version in the .csproj file.
    Used to set the version of .net standard and .net 5/6 projects.
    """
    files = glob.glob(f"{project_dir}/*.csproj")
    if not files:
        return

    with open(files[0], 'r+', encoding='utf-8-sig') as f:
        s = f.read()
        version = re.search(csproj_version_regex, s)
        if(version):
            _, new_version = updated_version_number(version, commit_type)
        
            s = re.sub(csproj_version_regex, new_version, s)
            f.seek(0)
            f.write(s)
            f.truncate()
            print(f'Updated csproj version @ {files[0]}')
            print(f'{version.group(0)} => {new_version}')


def find_release_number(path, repository_is_framework):
    """
    Returns the current release number if the repository contains one.
    Release numbers are found in either the a Init.cs file for all main repositories but simplic-framework.
    For simplic-framework it is found in src/Shared/InternAssemblyVersion.cs instead.
    """
    release_number = None
    with open(path, 'r', encoding='utf-8-sig') as f:
        if repository_is_framework:
            release_number = extract_release_number(intern_assembly_file_version_regex, f.read())
        else:
            release_number = extract_release_number(plugin_desc_regex, f.read())
    
    return release_number


def extract_release_number(regex, file_content):
    """
    Extracts the release number as a list from given file content
    """
    release_number = None
    
    result = re.search(regex, file_content)

    if result:
        try:
            major = int(result.group(2))
            minor = int(result.group(4))
            build = int(result.group(6)) # patch + year
            revision = int(result.group(8)) # month + day

            release_number = [major, minor, build, revision]
        except Exception as e: # Some regex error
            print(f'Exception whilst finding release number. {e}')

    return release_number


def set_guids(release_notes_path):
    """
    Sets missing guids in release notes
    """
    tree = ET.parse(release_notes_path)

    for change_set in tree.getroot():
        if 'guid' not in change_set.attrib:
            new_guid = str(uuid.uuid4())
            print ("Set guid for: " + str(change_set) + " = " + new_guid)
            change_set.set('guid', new_guid)

    tree.write(release_notes_path)


def get_release_notes_with_versions(release_notes, version_number):
    """
    Sets missing versions and dates in release notes
    """
    root = ET.fromstring(release_notes)

    for change_set in root:
        if 'version' not in change_set.attrib:
            change_set.set('version', '.'.join([str(x) for x in version_number]))
            change_set.set('date', f'{date.today()}')

    return ET.tostring(root, encoding='unicode', pretty_print=True)


def get_release_notes_texts(release_notes):
    """
    Sets missing versions and dates in release notes
    """
    root = ET.fromstring(release_notes)

    result = ['Change sets:\r\n']

    for change_set in root:
        if 'version' not in change_set.attrib:
            for change in change_set:
                change_type = change.attrib['type']
                change_text = change.text
                result.append(f'* [{change_type}] {change_text}')

    return '\r\n'.join(result)


def set_package_version(path, current_release_number):
    """
    Sets the version number of the package.json.
    Imidiatly returns when the file does not exist or does not contain a 'Version' key.
    """
    if not Path(path).exists():
        print_with_seperation(f'Could not find package json at: {path}.')
        return

    _json = ''
    with open(path, 'r', encoding='utf-8-sig') as file:
        _json = json.load(file)
      
    if "Version" not in _json.keys():
        print_with_seperation('Package json does not contain a "Version" property.')
        return
   
    version_string = '.'.join([str(x) for x in current_release_number])
    print_with_seperation(f'Updating package version to: { version_string}')

    _json['Version']['Major'] = current_release_number[0]
    _json['Version']['Minor'] = current_release_number[1]
    _json['Version']['Build'] = current_release_number[2]
    _json['Version']['Revision'] = current_release_number[3]

    with open(path, 'w') as file:
        file.write(json.dumps(_json, indent=4, sort_keys=False))
    
    print_with_seperation('Package version set.')

def print_with_seperation(string):
    print(f'{string}\n---')

if __name__ == '__main__':
    parser = argparse.ArgumentParser()
    parser.add_argument('--git-user', help='Your GitHub username')
    parser.add_argument('--git-pass', help='Your GitHub password')
    parser.add_argument('-c', '--conn-string',
                        help='The database connection string.')
    parser.add_argument('--git-token', help='Your GitHub token')
    args = vars(parser.parse_args())

    git_user = args['git_user']
    git_pass = args['git_pass']

    git_token = ""
    if 'git_token' in args:
        git_token = args['git_token']

    connection_string = args['conn_string']

    if all([git_token, connection_string]):
        print ("Use api-token and connection-string.")
    elif not all([git_user, git_pass, connection_string]):
        print(
            'Enter a connection string. Get a list of the arguments by adding --help to the script call. e.g. python update_version_number.py --help')
        # raise KillPipelineException('No connection string was entered.')
        sys.exit(0)

    assembly_version_regex = r'(\[assembly: AssemblyVersion\(")([0-9]+)(\.)([0-9]+)(\.)([0-9]+)(\.)([0-9]+)("\)\])'
    assembly_file_version_regex = r'(\[assembly: AssemblyFileVersion\(")([0-9]+)(\.)([0-9]+)(\.)([0-9]+)(\.)([0-9]+)("\)\])'
    plugin_desc_regex = r'(\[PlugInDesc\("[0-9a-zA-Z ]+", ")([0-9]+)(\.)([0-9]+)(\.)([0-9]+)(\.)([0-9]+)(.+\)\])'
    intern_assembly_file_version_regex = r'(public const string AssemblyFileVersion = ")([0-9]+)(\.)([0-9]+)(\.)([0-9]+)(\.)([0-9]+)(";)'
    csproj_version_regex = r'(<Version>)([0-9]+)(\.)([0-9]+)(\.)([0-9]+)(\.)([0-9]+)(<\/Version>)'

    today = date.today()
    today_day = today.day if today.day >= 10 else f'0{today.day}'
    today_month = today.month
    today_year = today.year - 2000

    repo = git.Repo('.')
    active_branch_name = repo.active_branch.name
    last_commit = list(repo.iter_commits(repo.active_branch))[0]
    dirs_with_changes = get_dirs_with_changes(last_commit.stats.files)

    commit_message = last_commit.message
    generic_commit_message = 'Updated version number [skip ci]'

    print(f'Working on commit {last_commit.hexsha[:8]} into {active_branch_name} made by {last_commit.author} on the {last_commit.committed_datetime.date()}.')
    print_with_seperation(f'Commit Message: {last_commit.message}')

    commit_type = re.search(r'(?i)(type: )(major|minor|patch|ignore)', commit_message).group(2) if re.search(r'(?i)(Type: )(major|minor|patch|ignore)', commit_message) else 'patch'

    remote_repo_name = repo.remotes[0].url.split('/simplic/')[1]
    print(remote_repo_name)

    if git_token:
        g = Github(git_token)
    else:
        g = Github(git_user, git_pass)

    org = g.get_organization('simplic')
    gh_repo = org.get_repo(remote_repo_name)

    if len(last_commit.parents) == 2:

        try:
            last_closed_pr = gh_repo.get_pulls(state='closed', sort='updated', direction='desc')[0]
        except Exception as e:
            last_closed_pr = None
            print(f'There are no closed pullrequests in this repo. {str(e)}')

        print(f'Pr head SHA: {last_closed_pr.head.sha}')
        print(f'Last commit parents: {[c.hexsha for c in last_commit.parents]}')

        if last_closed_pr and not commit_type == 'ignore' and last_closed_pr.head.sha == last_commit.parents[1].hexsha:
            print(f'All labels: {last_closed_pr.labels}')
            update_labels = [label.name for label in last_closed_pr.labels if label.name in ('major', 'minor', 'patch', 'ignore')]
            print(update_labels)
            if update_labels:
                commit_type = update_labels[0]

    print(commit_type)

    if str(last_commit.author) == 'simplic-bot':
        raise KillPipelineException('Commit is made by Pipeline.')
    elif active_branch_name not in ('dev', 'master'):
        print('Commmit is not into dev or master. Wont do anything.')
        sys.exit(0)
    elif commit_type == 'ignore':
        print('Commit type was set to ignore. Wont do anthing.')
        sys.exit(0)
    # Potentially handeling of merge conflict commits
    # elif active_branch_name == 'dev':
    #     try:
    #         repo.git.checkout('master')
    #         if [repo.git.branch('--contains', commit.hexsha) for commit in commit.parents]:
    #             print('Commit is from master into dev and will be skipped')
    #             sys.exit(0)
    #         repo.git.checkout('dev')
    #     except:
    #         pass

    is_main_repository = False
    productname = ""
    subrepositories = []
    init_path = ""
    package_json_path = ""

    if Path('infrastructure.json').exists():
        with open('infrastructure.json', 'r', encoding='utf-8-sig') as file:
            _json = json.load(file)
            if "subrepositories" in _json.keys():
                is_main_repository = True
                productname = _json['productname']
                subrepositories = _json['subrepositories']
                init_path = _json['init_path']
            else:
                print("Remove legacy infrastructure.json from repository!")

            if "package_json_path" in _json.keys():
                package_json_path = _json['package_json_path']
                print_with_seperation(f'Package JSON path set to: {package_json_path}')
    else:
        print(f'Infrastructure.json not found in root of branch {active_branch_name} of repository. If this is a main repository make sure to add it.')

    project_dirs = [_dir for _dir in Path('.').rglob('') for f in os.listdir(_dir) if f.endswith('.csproj')]
    print((repo.git.diff('HEAD~1..HEAD')).encode('ascii', 'ignore'))
    changed_files = get_changed_files(repo.git.diff('HEAD~1..HEAD'))
    project_dirs_with_changes = []
    
    for _dir in project_dirs:
        dir_is_changed = False
        for _file in changed_files:
            if _dir in _file.parents:
                dir_is_changed = True
                break
        if dir_is_changed and _dir not in project_dirs_with_changes:
            project_dirs_with_changes.append(_dir)    

    print_with_seperation(f'Found project dirs: {project_dirs}')
    print_with_seperation(f'Found project dirs with changes: {project_dirs_with_changes}')
    print_with_seperation(f'Files changed in Commit: {changed_files}')

    current_release_number = None
    """
    Update all non manually updated AssemblyInfo.cs versions.
    """
    for _dir in project_dirs_with_changes:
        if dir_contains_AssemblyInfo(_dir):
            if not manual_AssemblyInfo_change(_dir):
                update_AssemblyInfo(_dir)
            else:
                print(f'Ignored AssemblyInfo update @ {_dir}, because it was manually updated in commit.')
        else:
            if not manual_Csproj_change(_dir):
                update_CsprojVersion(_dir)
            else:
                print(f'Ignored Csproj update @ {_dir}, becuase it was manually updated in commit.')
    """
    Set guids for all release notes
    """
    if active_branch_name == 'dev':
        if Path('release-notes.xml').exists():
            set_guids('release-notes.xml')
        if Path('user-release-notes.xml').exists():
            set_guids('user-release-notes.xml')


    if productname == 'Simplic Studio':
        """
        simplic-framework handeling
        """
        current_release_number = find_release_number(init_path ,True)

        if project_dirs_with_changes and active_branch_name == 'master':
            if not manual_InternAssemblyVersion_change():
                current_release_number = update_InternAssemblyVersion()
            else:
                print_with_seperation(f'Ignored shared version update, because it was manually updated in commit.')
        
        if active_branch_name == 'master':
            # Set enviornment variable for advanced installer
            env_variable = '.'.join([str(x) for x in current_release_number])
            subprocess.call(['setx', 'INTERN_ASSEMBLY_VERSION', env_variable, '-m'], shell=True)
            print(env_variable)

    elif is_main_repository:
        """
        Other main repository handeling
        """
        current_release_number = find_release_number(init_path, False)
        
        if project_dirs_with_changes and active_branch_name == 'master':
            if not manual_Init_change(init_path):
                current_release_number = update_Init(init_path, productname)
            else:
                print_with_seperation(f'Ignored Init update @ {_dir}, because it was manually updated in commit.')
    

    """ 
    Update package json when the path is given in the build infastructure json.
    """
    if package_json_path != "":
        print_with_seperation("Calling method to update package json version")
        set_package_version(package_json_path, current_release_number)

    """
    Update release note versions
    """
    new_release_notes_text = ''

    if is_main_repository and active_branch_name == 'master':
        if Path('release-notes.xml').exists():
            with open('release-notes.xml', 'r+', encoding='utf-8-sig') as f:
                # Get release notes as text
                new_release_notes_text = get_release_notes_texts(f.read())
                f.seek(0)

                # Get new release notes
                main_release_notes = get_release_notes_with_versions(f.read(), current_release_number)
                f.seek(0)
                f.write(main_release_notes)
                f.truncate()

        if Path('user-release-notes.xml').exists():
            with open('user-release-notes.xml', 'r+', encoding='utf-8-sig') as f:
                user_release_notes = get_release_notes_with_versions(f.read(), current_release_number)
                f.seek(0)
                f.write(user_release_notes)
                f.truncate()


        for subrepository in subrepositories:
            if git_token:
                g = Github(git_token)
            else:
                g = Github(git_user, git_pass)

            org = g.get_organization('simplic')
            print (subrepository)
            remote_repo_name = subrepository.split('/simplic/')[1].replace('.git','')
            print (remote_repo_name)
            sub_repo = org.get_repo(remote_repo_name)
                        
            try:
                file = sub_repo.get_contents('release-notes.xml', branch='master')
                current_release_notes = file.decoded_content
                updated_release_notes = get_release_notes_with_versions(current_release_notes, current_release_number)
                sub_repo.update_file(file.path, f'Set versions because of new {productname} release', updated_release_notes, file.sha, branch='master')
            except:
                print(f'{subrepository} has no release-notes.xml file in master.')
    
    """
    Commit the changed version numbers
    """
    print (str(repo.git.remote('-v')))
    print (str(repo.git.config('-l')))

    repo.git.add('--all', '--', ':!build-infrastructure')
    try:
        repo.git.commit('-m', generic_commit_message)
        repo.git.push()
        
        if active_branch_name == 'master':
            # Create release tag
            try:
                version_nr = '.'.join([str(x) for x in current_release_number])

                print (f'Try to create release tag v{version_nr}')
                gh_repo.create_git_tag_and_release(tag=f'v{version_nr}', tag_message=f'release {version_nr}', release_name=version_nr, release_message=new_release_notes_text, object=repo.head.object.hexsha, type='commit', tagger=github.GithubObject.NotSet, draft=False, prerelease=False)
            except Exception as ex:
                print (ex)
                        
        else:
            print ('No release tag will be created - not in master branch')

    except git.exc.GitCommandError as gce:
        print(f'There was nothing added to be comitted.\ngit.exc.GitCommandError: {gce}')
