@{
  GUID = 'e373d7f2-e967-4a55-9462-4543f328bd75'
  RootModule = 'Azs.Subscriptions.Admin.psm1'
  ModuleVersion = '1.0.1'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft AzureStack PowerShell: Subscriptions Admin cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Azs.Subscriptions.Admin.private.dll'
  FormatsToProcess = './Azs.Subscriptions.Admin.format.ps1xml'
  FunctionsToExport = 'Add-AzsPlanToOffer', 'Get-AzsAcquiredPlan', 'Get-AzsAdminManagedOffer', 'Get-AzsDelegatedProvider', 'Get-AzsDelegatedProviderManagedOffer', 'Get-AzsDirectoryTenant', 'Get-AzsIdentityHealthReport', 'Get-AzsLocation', 'Get-AzsManifest', 'Get-AzsOfferDelegation', 'Get-AzsOfferMetric', 'Get-AzsPlan', 'Get-AzsPlanMetric', 'Get-AzsSubscriptionQuota', 'Get-AzsUserSubscription', 'Move-AzsUserSubscription', 'New-AzsAcquiredPlan', 'New-AzsOffer', 'New-AzsOfferDelegation', 'New-AzsPlan', 'New-AzsUserSubscription', 'Remove-AzsAcquiredPlan', 'Remove-AzsOffer', 'Remove-AzsOfferDelegation', 'Remove-AzsPlan', 'Remove-AzsPlanFromOffer', 'Remove-AzsUserSubscription', 'Set-AzsOffer', 'Set-AzsOfferDelegation', 'Set-AzsPlan', 'Set-AzsUserSubscription', 'Test-AzsMoveUserSubscription', 'Test-AzsNameAvailability', '*'
  AliasesToExport = 'Get-AzsSubscriptionPlan', 'Get-AzsManagedOffer', 'Get-AzsSubscriptionsQuota', 'New-AzsSubscriptionPlan', 'Remove-AzsSubscriptionPlan', 'Test-AzsMoveSubscription', '*'
  PrivateData = @{
    PSData = @{
      Tags = 'AzureStack', 'ResourceManager', 'ARM', 'PSModule'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azurestack-powershell'
      ReleaseNotes = 'AzureStack Hub Admin module generated with https://github.com/Azure/autorest.powershell'
    }
  }
}
