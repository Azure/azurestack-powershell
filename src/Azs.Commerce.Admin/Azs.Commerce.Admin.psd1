@{
  GUID = '6c171e78-d2a2-4790-994e-5c76d6ef4b03'
  RootModule = 'Azs.Commerce.Admin.psm1'
  ModuleVersion = '1.0.1'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft AzureStack PowerShell: Commerce Admin cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Azs.Commerce.Admin.private.dll'
  RequiredModules = @(@{ModuleName = 'Az.Accounts'; RequiredVersion = '2.2.8'; }, @{ModuleName = 'Az.Resources'; RequiredVersion = '0.11.0'; })
  FormatsToProcess = './Azs.Commerce.Admin.format.ps1xml'
  FunctionsToExport = 'Get-AzsSubscriberUsage', '*'
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
