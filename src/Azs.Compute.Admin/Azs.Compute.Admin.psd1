@{
  GUID = 'addb0a1f-16ad-492e-8cde-0fffb53e0645'
  RootModule = 'Azs.Compute.Admin.psm1'
  ModuleVersion = '1.1.1'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft AzureStack PowerShell: Compute Admin cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '2.2.8'}, @{ModuleName = 'Az.Resources'; ModuleVersion = '0.12.0'})
  RequiredAssemblies = './bin/Azs.Compute.Admin.private.dll'
  FormatsToProcess = './Azs.Compute.Admin.format.ps1xml'
  FunctionsToExport = 'Add-AzsPlatformImage', 'Add-AzsVMExtension', 'Disable-AzsComputeUserSubscriptionFeature', 'Enable-AzsComputeUserSubscriptionFeature', 'Get-AzsComputeFeature', 'Get-AzsComputeQuota', 'Get-AzsComputeScaleUnit', 'Get-AzsDisk', 'Get-AzsDiskMigrationJob', 'Get-AzsPlatformImage', 'Get-AzsVMExtension', 'New-AzsComputeQuota', 'New-AzsDiskMigrationJob', 'Remove-AzsComputeQuota', 'Remove-AzsPlatformImage', 'Remove-AzsVMExtension', 'Set-AzsComputeQuota', 'Stop-AzsDiskMigrationJob', 'Update-AzsComputeGlobalFeatureSetting', '*'
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
