@{
  GUID = 'de71fe70-cc4c-4505-ba0d-39d433579472'
  RootModule = 'Azs.Storage.Admin.psm1'
  ModuleVersion = '1.0.1'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft AzureStack PowerShell: Storage Admin cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Azs.Storage.Admin.private.dll'
  RequiredModules = @(@{ModuleName = 'Az.Accounts'; RequiredVersion = '2.2.8'; }, @{ModuleName = 'Az.Resources'; RequiredVersion = '0.11.0'; })
  FormatsToProcess = './Azs.Storage.Admin.format.ps1xml'
  FunctionsToExport = 'Get-AzsStorageAccount', 'Get-AzsStorageAcquisition', 'Get-AzsStorageQuota', 'Get-AzsStorageSettings', 'New-AzsStorageQuota', 'Remove-AzsStorageQuota', 'Restore-AzsStorageAccount', 'Set-AzsStorageQuota', 'Set-AzsStorageSettings', 'Start-AzsReclaimStorageCapacity', '*'
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
