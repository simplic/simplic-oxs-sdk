# Simplic.OxS.SDK

Contains tools to generate an SDK as well as the already generated projects.\
Edit services.yaml to include each of your services that you want to create an api client for.\
Run `generate.sh` to generate the SDK.

> Warning: any folder in the source directory that conflicts with the name of an SDK project that is to be generated will be entirely overridden.

Currently only works with the `restsharp` library (specified in config.yaml)

## Requirements for running it yourself:

- nodejs
- npm
- python3 along with used libraries (list may be incomplete):
  - requests
  - yaml
  - typing_extensions
- dotnet framework specified in config.yaml (Default: netstandard 2.0)
