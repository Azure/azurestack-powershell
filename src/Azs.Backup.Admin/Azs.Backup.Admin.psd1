@{
  GUID = '6b42d8b6-a98a-4887-862f-7ba64ec83d81'
  RootModule = 'Azs.Backup.Admin.psm1'
  ModuleVersion = '1.0.1'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft AzureStack PowerShell: Backup Admin cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
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
