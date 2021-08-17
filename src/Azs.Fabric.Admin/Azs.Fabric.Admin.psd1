@{
  GUID = '7f137177-0606-4ade-a55a-6377ed086a4a'
  RootModule = 'Azs.Fabric.Admin.psm1'
  ModuleVersion = '1.0.1'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft AzureStack PowerShell: Fabric Admin cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Azs.Fabric.Admin.private.dll'
  RequiredModules = @(@{ModuleName = 'Az.Accounts'; RequiredVersion = '2.2.8'; }, @{ModuleName = 'Az.Resources'; RequiredVersion = '0.11.0'; })
  FormatsToProcess = './Azs.Fabric.Admin.format.ps1xml'
  FunctionsToExport = 'Add-AzsScaleUnitNode', 'Disable-AzsScaleUnitNode', 'Enable-AzsScaleUnitNode', 'Get-AzsDrive', 'Get-AzsEdgeGateway', 'Get-AzsEdgeGatewayPool', 'Get-AzsInfrastructureLocation', 'Get-AzsInfrastructureRole', 'Get-AzsInfrastructureRoleInstance', 'Get-AzsInfrastructureShare', 'Get-AzsIPPool', 'Get-AzsLogicalNetwork', 'Get-AzsLogicalSubnet', 'Get-AzsMacAddressPool', 'Get-AzsScaleUnit', 'Get-AzsScaleUnitNode', 'Get-AzsSlbMuxInstance', 'Get-AzsStorageSubSystem', 'Get-AzsVolume', 'New-AzsIPPool', 'Repair-AzsScaleUnitNode', 'Restart-AzsInfrastructureRole', 'Set-AzsScaleUnit', 'Start-AzsInfrastructureRoleInstance', 'Start-AzsScaleUnitNode', 'Stop-AzsScaleUnitNode', '*'
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
