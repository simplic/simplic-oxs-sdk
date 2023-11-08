import re, glob
import argparse

def write_version(project_dir):
    csproj_version_regex = r'(<Version>)([0-9]+)(\.)([0-9]+)(\.)([0-9]+)(\.)([0-9]+)(<\/Version>)'

    print (f"{project_dir}/*.csproj")

    files = glob.glob(f"{project_dir}/*.csproj")
    if not files:
        print ('No file found')
        return

    with open(files[0], 'r') as f:
        s = f.read()
        version = re.search(csproj_version_regex, s)

        print ('> csproj file found')

        if(version):
            version_string = f'{version.group(2)}.{version.group(4)}.{version.group(6)}.{version.group(8)}'
            with open('current_version', 'w') as f:
                f.write(version_string)
                print ('Write version file')
        else:
            with open('current_version', 'w') as f:
                f.write('0.0.0.0')
                print ('No <Version>x.x.x.x</Version> tag found in csproj file')


if __name__ == '__main__':
    parser = argparse.ArgumentParser()
    parser.add_argument('--proj', help='Project path')

    args = vars(parser.parse_args())
    p = args['proj']
    
    print('Write file version to file')
    print(glob.glob(f"{p}/*.csproj")) 

    write_version(p)