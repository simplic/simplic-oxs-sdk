# build-infrastructure
Contains python scripts for building infrastructure such as updating version numbers

To add a repository to the auto version update, the template file version-number-update-template.yml from pipeline-template.yml has to be added to the pipeline of the repositorys branches u want to include.
To see how you would do that, refer to `pipeline-include-example.yml`.\
There also has to be a `infrastructure.json` file in each of the branches that you potentially want to have version numbers updated.\
Commits in which version numbers should be updated, have to specify the "size" of the update in their Commit message like this `Type: major|minor|patch`.
