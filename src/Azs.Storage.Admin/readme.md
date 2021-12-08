<!-- region Generated -->
# Azs.Storage.Admin
This directory contains the PowerShell module for the StorageAdmin service.

---
## Status
[![Azs.Storage.Admin](https://img.shields.io/powershellgallery/v/Azs.Storage.Admin.svg?style=flat-square&label=Azs.Storage.Admin "Azs.Storage.Admin")](https://www.powershellgallery.com/packages/Azs.Storage.Admin/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Authentication
AutoRest does not generate authentication code for the module. Authentication is handled via Az.Accounts by altering the HTTP payload before it is sent.

## Development
For information on how to develop for `Azs.Storage.Admin`, see [how-to.md](how-to.md).
<!-- endregion -->

## Generation Requirements
Use of the beta version of `autorest.powershell` generator requires the following:
- [NodeJS LTS](https://nodejs.org) (10.15.x LTS preferred)
  - **Note**: It *will not work* with Node < 10.x. Using 11.x builds may cause issues as they may introduce instability or breaking changes.
> If you want an easy way to install and update Node, [NVS - Node Version Switcher](../nodejs/installing-via-nvs.md) or [NVM - Node Version Manager](../nodejs/installing-via-nvm.md) is recommended.
- [AutoRest](https://aka.ms/autorest) v3 beta <br>`npm install -g autorest@beta`<br>&nbsp;
- PowerShell 6.0 or greater
  - If you don't have it installed, you can use the cross-platform npm package <br>`npm install -g pwsh`<br>&nbsp;
- .NET Core SDK 2.0 or greater
  - If you don't have it installed, you can use the cross-platform npm package <br>`npm install -g dotnet-sdk-2.2`<br>&nbsp;

## Run Generation
In this directory, run AutoRest:
> `autorest`

---
### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../readme.azurestack.md
  - $(repo)/specification/azsadmin/resource-manager/storage/readme.azsautogen.md

metadata:
  description: 'Microsoft AzureStack PowerShell: Storage Admin cmdlets'

### PSD1 metadata changes
subject-prefix: ''
module-version: 1.0.1
service-name: StorageAdmin

### File Renames
### IMPORTANT - Note that the following settings are case sensitive ###
module-name: Azs.Storage.Admin
csproj: Azs.Storage.Admin.csproj
psd1: Azs.Storage.Admin.psd1
psm1: Azs.Storage.Admin.psm1
```

### Parameter default values
``` yaml
directive:
    # Remove cmdlets for AsyncOperation.
  - where:
      subject: AsyncOperation
    remove: true
    # Remove cmdlets for StorageService.
  - where:
      subject: StorageService
    remove: true
    # Remove cmdlets for StorageServiceSub.
  - where:
      subject: StorageServiceSub
    remove: true
    # Remove cmdlets for StorageServiceRg.
  - where:
      subject: StorageServiceRg
    remove: true

    # Rename Get-AzsAcquisition to Get-AzsStorageAcquisition
  - where:
      verb: Get
      subject: Acquisition
    set:
      verb: Get
      subject: StorageAcquisition
    # Rename Invoke-AzsStorageReclaimStorageAccountStorageCapacity to Start-AzsReclaimStorageCapacity
  - where:
      verb: Invoke
      subject: ReclaimStorageAccountStorageCapacity
    set:
      verb: Start
      subject: ReclaimStorageCapacity
    # Rename Get-AzsStorageSetting to Get-AzsStorageSettings
  - where:
      verb: Get
      subject: StorageSetting
    set:
      verb: Get
      subject: StorageSettings
    # Rename Set-AzsStorageSetting to Set-AzsStorageSettings
  - where:
      verb: Set
      subject: StorageSetting
    set:
      verb: Set
      subject: StorageSettings

    # Rename cmdlet parameter name and set default value in StorageAccount 
  - where:
      subject: StorageAccount
      parameter-name: AccountId
    set:
      parameter-name: Name
      alias: AccountId
  - where:
      subject: StorageAccount
      parameter-name: Summary
    set:
      default:
        script: '$false'

    # Rename cmdlet parameter name in StorageSettings
  - where:
      subject: StorageSettings
      parameter-name: RetentionPeriodForDeletedStorageAccountsInDay
    set:
      parameter-name: RetentionPeriodForDeletedStorageAccountsInDays

    # Rename cmdlet parameter name and set default value in StorageQuota
  - where:
      subject: StorageQuota
      parameter-name: QuotaName
    set:
      parameter-name: Name
      alias: QuotaName
  - where:
      verb: New
      subject: StorageQuota
      parameter-name: CapacityInGb
    set:
      default:
        script: '500'
  - where:
      subject: StorageQuota
      parameter-name: NumberOfStorageAccount
    set:
      parameter-name: NumberOfStorageAccounts
  - where:
      verb: New
      subject: StorageQuota
      parameter-name: NumberOfStorageAccounts
    set:
      default:
        script: '20'
  
    # Remove GetViaIdentity parameter set in Get-StorageSettings
  - where:
      verb: Get
      subject: StorageSettings
      variant: GetViaIdentity
    remove: true

    # Remove UndeleteViaIdentity parameter set in Restore-StorageAccount
  - where:
      verb: Restore
      subject: StorageAccount
      variant: UndeleteViaIdentity
    remove: true

    # Remove ReclaimViaIdentity parameter set in Start-AzsReclaimStorageCapacity
  - where:
      verb: Start
      subject: ReclaimStorageCapacity
      variant: ReclaimViaIdentity
    remove: true

    # Remove Update parameter set in Set-AzsStorageSettings
  - where:
      verb: Set
      subject: StorageSettings
      variant: Update
    remove: true

    # Remove UpdateViaIdentity parameter set in Set-AzsStorageSettings
  - where:
      verb: Set
      subject: StorageSettings
      variant: ^UpdateViaIdentity(.*)
    remove: true

    # Rename model property names
  - where:
      model-name: Settings
      property-name: RetentionPeriodForDeletedStorageAccountsInDay
    set:
      property-name: RetentionPeriodForDeletedStorageAccountsInDays
  - where:
      model-name: StorageQuota
      property-name: NumberOfStorageAccount
    set:
      property-name: NumberOfStorageAccounts
  - where:
      model-name: StorageAccount
      property-name: PrimaryEndpoint
    set:
      property-name: PrimaryEndpoints

    # Default to Format-List for the Settings, StorageQuota and Acquisition model as there are many important fields
  - where:
      model-name: Settings
    set:
      suppress-format: true
  - where:
      model-name: StorageQuota
    set:
      suppress-format: true
  - where:
      model-name: Acquisition
    set:
      suppress-format: true

    # Hide the auto-generated Get-AzsStorageQuota and expose it through customized one
  - where:
      verb: Get
      subject: StorageQuota
    hide: true

    # Hide the auto-generated New-AzsStorageQuota and expose it through customized one
  - where:
      verb: New
      subject: StorageQuota
    hide: true

    # Hide the auto-generated Remove-AzsStorageQuota and expose it through customized one
  - where:
      verb: Remove
      subject: StorageQuota
    hide: true

    # Hide the auto-generated Set-AzsStorageQuota and expose it through customized one
  - where:
      verb: Set
      subject: StorageQuota
    hide: true

    # Hide the auto-generated Remove-AzsStorageQuota and expose it through customized one
  - where:
      verb: Restore
      subject: StorageAccount
    hide: true

    # Hide the auto-generated Remove-AzsStorageQuota and expose it through customized one
  - where:
      verb: Start
      subject: ReclaimStorageCapacity
    hide: true

    # Hide the auto-generated Set-AzsStorageSettings and expose it through customized one
  - where:
      verb: Set
      subject: StorageSettings
    hide: true

# Add release notes
  - from: Azs.Storage.Admin.nuspec
    where: $
    transform: $ = $.replace('<releaseNotes></releaseNotes>', '<releaseNotes>AzureStack Hub Admin module generated with https://github.com/Azure/autorest.powershell.</releaseNotes>');

# Add Az.Accounts/Az.Resources as dependencies
  - from: Azs.Storage.Admin.nuspec
    where: $
    transform: $ = $.replace('<dependency id="Az.Accounts" version="2.2.3" />', '<dependency id="Az.Accounts" version="[2.2.8]" />\n      <dependency id="Az.Resources" version="[0.12.0]" />');

# PSD1 changes for RequiredModules
  - from: source-file-csharp
    where: $
    transform: $ = $.replace('sb.AppendLine\(\$@\"\{Indent\}RequiredAssemblies = \'\{\"./bin/Azs.Storage.Admin.private.dll\"\}\'\"\);', 'sb.AppendLine\(\$@\"\{Indent\}RequiredAssemblies = \'\{\"./bin/Azs.Storage.Admin.private.dll\"\}\'\"\);\n      sb.AppendLine\(\$@\"\{Indent\}RequiredModules = @\(@\{\{ModuleName = \'Az.Accounts\'; RequiredVersion = \'2.2.8\'; \}\}, @\{\{ModuleName = \'Az.Resources\'; RequiredVersion = \'0.12.0\'; \}\}\)\"\);');

# PSD1 changes for ReleaseNotes
  - from: source-file-csharp
    where: $
    transform: $ = $.replace('sb.AppendLine\(\$@\"\{Indent\}\{Indent\}\{Indent\}ReleaseNotes = \'\'\"\);', 'sb.AppendLine\(\$@\"\{Indent\}\{Indent\}\{Indent\}ReleaseNotes = \'AzureStack Hub Admin module generated with https://github.com/Azure/autorest.powershell\'\"\);' );
```
