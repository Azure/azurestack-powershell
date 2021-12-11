@{
  GUID = '2e202983-13f3-4bc9-a5fb-98911e8d1a12'
  RootModule = 'Azs.Backup.Admin.psm1'
  ModuleVersion = '1.0.2'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft AzureStack PowerShell: Backup Admin cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '2.2.8'}, @{ModuleName = 'Az.Resources'; ModuleVersion = '0.12.0'})
  RequiredAssemblies = './bin/Azs.Backup.Admin.private.dll'
  FormatsToProcess = './Azs.Backup.Admin.format.ps1xml'
  FunctionsToExport = 'Get-AzsBackup', 'Get-AzsBackupConfiguration', 'Invoke-AzsPruneBackupLocationExternalStore', 'Restore-AzsBackup', 'Set-AzsBackupConfiguration', 'Start-AzsBackup', '*'
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
