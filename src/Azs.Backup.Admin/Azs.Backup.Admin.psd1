@{
  GUID = '6b8410e2-074e-44c1-81f1-410accf696a5'
  RootModule = 'Azs.Backup.Admin.psm1'
  ModuleVersion = '0.9.0'
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
      Prerelease = 'preview'
      Tags = 'AzureStack', 'ResourceManager', 'ARM', 'PSModule'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azurestack-powershell'
      ReleaseNotes = 'AzureStack Hub Admin module generated with https://github.com/Azure/autorest.powershell - see https://aka.ms/azpshmigration for breaking changes'
    }
  }
}
