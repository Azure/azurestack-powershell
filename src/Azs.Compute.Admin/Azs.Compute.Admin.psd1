@{
  GUID = 'fd56a725-8cf4-45b1-9c04-4e0331e778dc'
  RootModule = 'Azs.Compute.Admin.psm1'
  ModuleVersion = '1.0.1'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft AzureStack PowerShell: Compute Admin cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Azs.Compute.Admin.private.dll'
  RequiredModules = @(@{ModuleName = 'Az.Accounts'; RequiredVersion = '2.2.8'; }, @{ModuleName = 'Az.Resources'; RequiredVersion = '0.11.0'; })
  FormatsToProcess = './Azs.Compute.Admin.format.ps1xml'
  FunctionsToExport = 'Add-AzsPlatformImage', 'Add-AzsVMExtension', 'Disable-AzsTenantSubscriptionFeature', 'Enable-AzsTenantSubscriptionFeature', 'Get-AzsComputeQuota', 'Get-AzsDisk', 'Get-AzsDiskMigrationJob', 'Get-AzsFeature', 'Get-AzsPlatformImage', 'Get-AzsScaleUnit', 'Get-AzsVMExtension', 'New-AzsComputeQuota', 'New-AzsDiskMigrationJob', 'Remove-AzsComputeQuota', 'Remove-AzsPlatformImage', 'Remove-AzsVMExtension', 'Set-AzsComputeQuota', 'Stop-AzsDiskMigrationJob', 'Update-AzsGlobalFeatureSetting', '*'
  AliasesToExport = 'Start-AzsDiskMigrationJob', '*'
  PrivateData = @{
    PSData = @{
      Tags = 'AzureStack', 'ResourceManager', 'ARM', 'PSModule'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azurestack-powershell'
      ReleaseNotes = 'AzureStack Hub Admin module generated with https://github.com/Azure/autorest.powershell'
    }
  }
}
