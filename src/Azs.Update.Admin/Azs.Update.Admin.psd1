@{
  GUID = '93e83a53-8e2c-4a01-9e7a-daefd896e43b'
  RootModule = 'Azs.Update.Admin.psm1'
  ModuleVersion = '1.0.1'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft AzureStack PowerShell: Update Admin cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Azs.Update.Admin.private.dll'
  RequiredModules = @(@{ModuleName = 'Az.Accounts'; RequiredVersion = '2.2.8'; }, @{ModuleName = 'Az.Resources'; RequiredVersion = '0.11.0'; })
  FormatsToProcess = './Azs.Update.Admin.format.ps1xml'
  FunctionsToExport = 'Get-AzsUpdate', 'Get-AzsUpdateLocation', 'Get-AzsUpdateRun', 'Install-AzsUpdate', 'Resume-AzsUpdateRun', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'AzureStack', 'ResourceManager', 'ARM', 'PSModule'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azurestack-powershell'
      ReleaseNotes = 'AzureStack Hub Admin module generated with https://github.com/Azure/autorest.powershell'
    }
  }
}
