# Install Azure Stack Tools

# Change directory to the root directory.
Set-Location

# Download the tools archive.
[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12 
Invoke-WebRequest `
  https://github.com/Azure/AzureStack-Tools/archive/az.zip `
  -OutFile master.zip

# Expand the downloaded files.
Expand-Archive master.zip `
  -DestinationPath . `
  -Force

# Change to the tools directory.
Set-Location AzureStack-Tools-az

# temporary workarounds
if($PSVersionTable['Os'] -ilike '*Linux*') 
{
    ln -s /root/.local/share/powershell/Modules/Azs.Azurebridge.Admin /root/.local/share/powershell/Modules/Azs.AzureBridge.Admin 
    ln -s /root/.local/share/powershell/Modules/Azs.Keyvault.Admin /root/.local/share/powershell/Modules/Azs.KeyVault.Admin 
    ln -s /root/.local/share/powershell/Modules/Azs.Infrastructureinsights.Admin /root/.local/share/powershell/Modules/Azs.InfrastructureInsights.Admin
}

