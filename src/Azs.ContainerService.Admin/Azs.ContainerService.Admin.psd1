@{
  GUID = '5b79b501-5779-4ad2-bf51-bc11ac4f7f7f'
  RootModule = 'Azs.ContainerService.Admin.psm1'
  ModuleVersion = '0.1.0'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft AzureStack PowerShell: ContainerService Admin cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Azs.ContainerService.Admin.private.dll'
  RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '2.2.8'; }, @{ModuleName = 'Az.Resources'; RequiredVersion = '1.11.0'; })
  FormatsToProcess = './Azs.ContainerService.Admin.format.ps1xml'
  FunctionsToExport = 'Get-AzsContainerService', 'Get-AzsContainerServiceQuota', '*'
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
