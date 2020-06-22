## Release Process
Releasing the modules to TestGallery and then further to PSGallery is currently manual and gated through Azure SDK release process.

The process will be automated with a release pipeline in devops

### Release Notes
The release notes are updated in each module's PSData secction of the Psd1. It is recommended to have a aka.ms link in each AzureStack module release so that the notes could be updated for clarity, breaking changes etc.. at a later time

### Tagging 
Each release gets tagged once the final build is verified. In future, the release pipeline will automatically create the tag. Right now the tag is created manually. The tag can be created once the bits are in TestGallery

git tag v2.0.1-preview
git push upstream v2.0.1-preview

### Draft a release
Please follow the github help link for instructions
https://help.github.com/en/github/administering-a-repository/managing-releases-in-a-repository


