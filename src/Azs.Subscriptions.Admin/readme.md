<!-- region Generated -->
# Azs.Subscriptions.Admin
This directory contains the PowerShell module for the SubscriptionsAdmin service.

---
## Status
[![Azs.Subscriptions.Admin](https://img.shields.io/powershellgallery/v/Azs.Subscriptions.Admin.svg?style=flat-square&label=Azs.Subscriptions.Admin "Azs.Subscriptions.Admin")](https://www.powershellgallery.com/packages/Azs.Subscriptions.Admin/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Module Requirements
- [Az.Accounts module](https://www.powershellgallery.com/packages/Az.Accounts/), version 1.7.4 or greater

## Authentication
AutoRest does not generate authentication code for the module. Authentication is handled via Az.Accounts by altering the HTTP payload before it is sent.

## Development
For information on how to develop for `Azs.Subscriptions.Admin`, see [how-to.md](how-to.md).
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
  - $(repo)/specification/azsadmin/resource-manager/subscriptions/readme.azsautogen.md

metadata:
  description: 'Microsoft AzureStack PowerShell: Subscriptions Admin cmdlets'

subject-prefix: ''
module-version: 1.0.0
sanitize-names: false
service-name: SubscriptionsAdmin

### File Renames
### IMPORTANT - Note that the following settings are case sensitive ###
module-name: Azs.Subscriptions.Admin
csproj: Azs.Subscriptions.Admin.csproj
psd1: Azs.Subscriptions.Admin.psd1
psm1: Azs.Subscriptions.Admin.psm1

directive:
## add alias for cmdlets
  - where:
      verb: Get
      subject: AcquiredPlan
    set:
      alias: Get-AzsSubscriptionPlan
  - where:
      verb: New
      subject: AcquiredPlan
    set:
      alias: New-AzsSubscriptionPlan
  - where:
      verb: Remove
      subject: AcquiredPlan
    set:
      alias: Remove-AzsSubscriptionPlan
## rename cmdlets
  - where:
      verb: Get
      subject: DelegatedProviderOffer 
    set:
      subject: DelegatedProviderManagedOffer
  - where:
      verb: Get
      subject: Offer
    set:
      subject: AdminManagedOffer
      alias: Get-AzsManagedOffer
  - where:
      verb: Get
      subject: Quota
    set:
      subject: SubscriptionQuota
      alias: Get-AzsSubscriptionsQuota
  - where:
      subject: Subscription
    set:
      subject: UserSubscription
  - where:
      verb: Invoke
      subject: LinkOffer
    set:
      verb: Add
      subject: PlanToOffer
  - where:
      verb: Invoke
      subject: UnlinkOffer
    set:
      verb: Remove
      subject: PlanFromOffer
  - where:
      verb: Test
      subject: SubscriptionIdentityHealth
    set:
      verb: Get
      subject: IdentityHealthReport
  - where:
      verb: Test
      subject: SubscriptionMoveSubscription
    set:
      subject: MoveUserSubscription
      alias: Test-AzsMoveSubscription
  - where:
      verb: Test
      subject: SubscriptionNameAvailability
    set:
      subject: NameAvailability
## remove cmdlets
  - where:
      verb: Get
      subject: LocationOperationStatus
    remove: True
  - where:
      verb: New
      subject: Location
    remove: True
  - where:
      verb: Restore
      subject: SubscriptionData
    remove: True
  - where:
      verb: Set
      subject: Location
    remove: True
  - where:
      verb: Update
      subject: SubscriptionEncryption
    remove: True
  - where:
      verb: New|Set|Remove
      subject: DirectoryTenant
    remove: True
  - where:
      verb: Get
      subject: OfferMetricDefinition
    remove: True
  - where:
      verb: Get
      subject: PlanMetricDefinition
    remove: True  
## rename parameters
  - where:
      subject: DelegatedProviderManagedOffer
      parameter-name: DelegatedProviderSubscriptionId
    set:
      alias: DelegatedProviderId
  - where:
      parameter-name: DelegatedProvider
    set:
      parameter-name: DelegatedProviderId
  - where:
      subject: (.*)Offer$
      parameter-name: Offer
    set:
      parameter-name: Name
  - where:
      subject: (.*)Tenant$
      parameter-name: Tenant
    set:
      parameter-name: Name
  - where:
      subject: Location
      parameter-name: Location
    set:
      parameter-name: Name
      alias: Location
  - where:
      verb: New
      subject: OfferDelegation
      parameter-name: PropertiesSubscriptionId
    set:
      parameter-name: TargetSubscriptionId
  - where:
      subject: (.*)OfferDelegation$
      parameter-name: OfferDelegationName
    set:
      parameter-name: Name
  - where:
      subject: ^Offer(.*)
      parameter-name: Offer
    set:
      parameter-name: OfferName
  - where:
      subject: Plan
      parameter-name: Plan
    set:
      parameter-name: Name
  - where:
      subject: ^Plan(.*)
      parameter-name: Plan
    set:
      parameter-name: PlanName
  - where:
      subject: Quota
      parameter-name: Quota
    set:
      parameter-name: Name
  - where:
      verb: Get
      subject: Subscription
    set:
      subject: UserSubscription
  - where:
      verb: Get
      subject: UserSubscription
      parameter-name: Subscription
    set:
      parameter-name: TargetSubscriptionId
  - where:
      parameter-name: Resources
    set:
      parameter-name: ResourceId
  - where:
      parameter-name: TargetDelegatedProviderOffer
    set:
      parameter-name: DestinationDelegatedProviderOffer
  - where:
      parameter-name: AddonPlans
    set:
      parameter-name: AddonPlanDefinition
  - where:
      verb: Remove
      subject: Subscription
    set:
      subject: UserSubscription
  - where:
      verb: Remove
      subject: UserSubscription
      parameter-name: Subscription
    set:
      parameter-name: UserSubscriptionId
  - where:
      verb: Add
      subject: PlanToOffer
      parameter-name: Name
    set:
      parameter-name: OfferName
  - where:
      verb: Remove
      subject: PlanFromOffer
      parameter-name: Name
    set:
      parameter-name: OfferName
## default values
  - where:
      verb: New
      subject: Offer
      parameter-name: State
    set:
      default:
        script: Write-Output "Private"
  - where:
      verb: New
      subject: UserSubscription
      parameter-name: TargetSubscriptionId
    set:
      default:
        script: "$([Guid]::NewGuid().ToString())"
  - where:
      verb: New
      subject: UserSubscription
      parameter-name: DelegatedProviderSubscriptionId
    set:
      default:
        script: '(Get-AzContext).Subscription.Id'
  - where:
      verb: New
      subject: UserSubscription
      parameter-name: State
    set:
      default:
        script: Write-Output "Enabled"
  - where:
      verb: New
      subject: UserSubscription
      parameter-name: RoutingResourceManagerType
    set:
      default:
        script: Write-Output "Default"
  - where:
      verb: New
      subject: AcquiredPlan
      parameter-name: PlanAcquisitionId
    set:
      default:
        script: "$([Guid]::NewGuid().ToString())"
  - where:
      verb: Get
      subject: DirectoryTenant
      parameter-name: ResourceGroupName
    set:
      default:
        script: '"system.$((Get-AzLocation)[0].Location)"'
## hide autorest generated cmdlet to use the custom one
  - where:
      verb: New
      subject: AcquiredPlan
    hide: true
  - where:
      verb: New
      subject: Offer
    hide: true
  - where:
      verb: New
      subject: Plan
    hide: true
  - where:
      verb: Set
      subject: Offer
    hide: true
  - where:
      verb: Set
      subject: Plan
    hide: true
  - where:
      verb: New|Set|Remove
      subject: UserSubscription
    hide: true
## output format
  - where:
      model-name: Manifest
    set:
      format-table:
        properties: 
          - Name
          - Metadata
  - where:
      model-name: Plan|Offer
    set:
      suppress-format: true

# Add release notes
  - from: Azs.Subscriptions.Admin.nuspec
    where: $
    transform: $ = $.replace('<releaseNotes></releaseNotes>', '<releaseNotes>AzureStack Hub Admin module generated with https://github.com/Azure/autorest.powershell - see https://aka.ms/azpshmigration for breaking changes.</releaseNotes>');

# Add Az.Accounts/Az.Resources as dependencies
  - from: Azs.Subscriptions.Admin.nuspec
    where: $
    transform: $ = $.replace('<dependency id=\"Az.Accounts\" version=\"1.6.0\" />', '<dependency id="Az.Accounts" version="[2.0.1-preview]" />\n      <dependency id="Az.Resources" version="[0.10.0-preview]" />');

# PSD1 changes for RequiredModules
  - from: source-file-csharp
    where: $
    transform: $ = $.replace('sb.AppendLine\(\$@\"\{Indent\}RequiredAssemblies = \'\{\"./bin/Azs.AzureBridge.Admin.private.dll\"\}\'\"\);', 'sb.AppendLine\(\$@\"\{Indent\}RequiredAssemblies = \'\{\"./bin/Azs.AzureBridge.Admin.private.dll\"\}\'\"\);\n      sb.AppendLine\(\$@\"\{Indent\}RequiredModules = @\(@\{\{ModuleName = \'Az.Accounts\'; ModuleVersion = \'2.0.1\'; \}\}, @\{\{ModuleName = \'Az.Resources\'; RequiredVersion = \'0.10.0\'; \}\}\)\"\);');

# PSD1 changes for ReleaseNotes
  - from: source-file-csharp
    where: $
    transform: $ = $.replace('sb.AppendLine\(\$@\"\{Indent\}\{Indent\}\{Indent\}ReleaseNotes = \'\'\"\);', 'sb.AppendLine\(\$@\"\{Indent\}\{Indent\}\{Indent\}ReleaseNotes = \'AzureStack Hub Admin module generated with https://github.com/Azure/autorest.powershell - see https://aka.ms/azpshmigration for breaking changes\'\"\);' );

```
