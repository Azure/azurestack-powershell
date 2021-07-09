## Using In Azure Devops

The recommended way to test newly generated Azurestack modules in Azure Devops is to upload them to a storage accessible by your Azure Devops pipeline. For example, the following code downloads, installs, and imports the required Az.Accounts and Az.Resources modules.

```
Unregister-PSRepository -Name local -ErrorAction SilentlyContinue
$psrepo="$env:systemdrive\psrepo"
New-Item -Path $psrepo -ItemType Directory -force
Invoke-WebRequest -Uri <URI_TO_AZ_ACCOUNTS_DOWNLOAD> -OutFile <AZ_ACCOUNTS_MODULE_DOWNLOADED_FILE>
Invoke-WebRequest -Uri <URI_TO_AZ_RESOURCES_DOWNLOAD> -OutFile <AZ_RESOURCES_MODULE_DOWNLOADED_FILE>
Register-PSRepository -Name local -SourceLocation $psrepo -InstallationPolicy Trusted
Install-Module Az.Accounts -Repository Local
Install-Module Az.Resources -Repository Local
Import-Module Az.Accounts
Import-Module Az.Resources
```