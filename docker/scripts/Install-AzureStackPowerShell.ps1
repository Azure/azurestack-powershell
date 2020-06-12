# Install Azure Stack PowerShell Modules

param
(
  [string] $REPOSITORY,
  [string] $AZURESTACK_PROFILE,
  [string] $AZURESTACK_VERSION
)


# Change directory to the home directory.
Set-Location

Set-PSRepository -Name $REPOSITORY -InstallationPolicy Trusted 

Install-Module -Name Az.BootStrapper -Force -AllowPrerelease 
Install-AzProfile -Profile $AZURESTACK_PROFILE -Force -Confirm:$false 
Install-Module -Name AzureStack -RequiredVersion $AZURESTACK_VERSION -AllowPrerelease 
