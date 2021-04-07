## Run Generation
In this directory, run AutoRest:
> `autorest`

## Installing Module
Simply run:

```
Install-Module -Name Az.Bootstrapper -Repository <REPOSITORY_CONTAINING_AZ_BOOTSTRAPPER>
```

## Installing Profiles
- To install from online or cached profile, simply run:

```
Set-BootStrapRepo -Repo <REPOSITORY>
Install-AzProfile -Profile <PROFILE_VERSION>
```

- To install local profile, set the environment variable AzBootStrapperLocalProfile with the full path to the local profile on your system.

```
Set-Item -Path Env:AzBootStrapperLocalProfile -Value <FULL_PATH_TO_PROFILE_JSON>
Set-BootStrapRepo -Repo <REPOSITORY>
Install-AzProfile -Profile <PROFILE_VERSION>
```

---
### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../readme.azurestack.md

input-file:
  - $(this-folder)/dummy.json

output-folder: $(this-folder)/toss/
```
