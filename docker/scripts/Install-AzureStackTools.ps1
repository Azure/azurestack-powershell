# Install Azure Stack Tools

# Change directory to the root directory.
Set-Location

# Download the tools archive.
[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12 
Invoke-WebRequest `
  https://github.com/Azure/AzureStack-Tools/archive/az.zip `
  -OutFile az.zip

# Expand the downloaded files.
Expand-Archive az.zip `
  -DestinationPath . `
  -Force

# Install Syndication tools
Install-Module -Name Azs.Syndication.Admin -AllowPrerelease

# Change to the tools directory.
Set-Location AzureStack-Tools-az

