<!-- region Generated -->
# Azs.Subscriptions
This directory contains the PowerShell module for the Subscription service.

---
## Status
[![Azs.Subscriptions](https://img.shields.io/powershellgallery/v/Azs.Subscriptions.svg?style=flat-square&label=Azs.Subscriptions "Azs.Subscriptions")](https://www.powershellgallery.com/packages/Azs.Subscriptions/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Module Requirements
- [Az.Accounts module](https://www.powershellgallery.com/packages/Az.Accounts/), version 1.6.0 or greater

## Authentication
AutoRest does not generate authentication code for the module. Authentication is handled via Az.Accounts by altering the HTTP payload before it is sent.

## Development
For information on how to develop for `Azs.Subscriptions`, see [how-to.md](how-to.md).
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

# Azure PowerShell AutoRest Configuration

> Values
``` yaml
azure: true
powershell: true
branch: stackadmin
repo: https://github.com/Azure/azure-rest-api-specs/tree/$(branch)
metadata:
  authors: Microsoft Corporation
  owners: Microsoft Corporation
  description: 'Microsoft Azure PowerShell: User subscription cmdlets'
  copyright: Microsoft Corporation. All rights reserved.
  tags: Azure ResourceManager ARM PSModule
  companyName: Microsoft Corporation
  requireLicenseAcceptance: true
  licenseUri: https://aka.ms/azps-license
  projectUri: https://github.com/Azure/azure-powershell
```

> Names
``` yaml
prefix: Azs
namespace: Microsoft.Azure.PowerShell.Cmdlets.$(service-name)

subject-prefix: ''
module-version: 1.0.0
sanitize-names: false
service-name: Subscription

### File Renames
### IMPORTANT - Note that the following settings are case sensitive ###
module-name: Azs.Subscriptions
csproj: Azs.Subscriptions.csproj
psd1: Azs.Subscriptions.psd1
psm1: Azs.Subscriptions.psm1
```

> Folders
``` yaml
clear-output-folder: true
output-folder: .

input-file:
    - $(repo)/specification/azsadmin/resource-manager/user-subscriptions/Microsoft.Subscriptions/preview/2015-11-01/Subscriptions.json
    - $(repo)/specification/azsadmin/resource-manager/user-subscriptions/Microsoft.Subscriptions/preview/2015-11-01/Offer.json

directive:
  ## rename/alias parameters
  - where:
      verb: Get
      subject: DelegatedProviderOffer
      parameter-name: OfferName
    set:
      alias: Name
  ## Set default parameter value
  - where:
      verb: New
      subject: Subscription
      parameter-name: State
    set:
      default:
        script: Write-Output "Enabled"
  - where:
      verb: New
      subject: Subscription
      parameter-name: SubscriptionId
    set:
      default:
        script: "$([Guid]::NewGuid().ToString())"
  ## variant removal (parameter *Definition*) from New cmdlet -- parameter set Create
  - where:
      verb: New
      variant: Create
    remove: true
  ## variant removal (parameter InputObject) from New cmdlet -- parameter sets CreateViaIdentity and CreateViaIdentityExpanded
  - where:
      verb: New
      variant: ^CreateViaIdentity(.*)
    remove: true
  ## hide autorest generated cmdlet to use the custom one
  - where:
      verb: New|Set|Remove
      subject: Subscription
    hide: true
    ## output format
  - where:
      model-name: Offer
    set:
      suppress-format: true

# Add release notes
  - from: Azs.Subscriptions.nuspec
    where: $
    transform: $ = $.replace('<releaseNotes></releaseNotes>', '<releaseNotes>AzureStack Hub Admin module generated with https://github.com/Azure/autorest.powershell - see https://aka.ms/azpshmigration for breaking changes.</releaseNotes>');

# Add Az.Accounts/Az.Resources as dependencies
  - from: Azs.Subscriptions.nuspec
    where: $
    transform: $ = $.replace('<dependency id=\"Az.Accounts\" version=\"1.6.0\" />', '<dependency id="Az.Accounts" version="[2.0.1-preview]" />\n      <dependency id="Az.Resources" version="[0.10.0-preview]" />');

# PSD1 changes for RequiredModules
  - from: source-file-csharp
    where: $
    transform: $ = $.replace('sb.AppendLine\(\$@\"\{Indent\}RequiredAssemblies = \'\{\"./bin/Azs.Subscriptions.private.dll\"\}\'\"\);', 'sb.AppendLine\(\$@\"\{Indent\}RequiredAssemblies = \'\{\"./bin/Azs.Subscriptions.private.dll\"\}\'\"\);\n      sb.AppendLine\(\$@\"\{Indent\}RequiredModules = @\(@\{\{ModuleName = \'Az.Accounts\'; ModuleVersion = \'2.0.1\'; \}\}, @\{\{ModuleName = \'Az.Resources\'; RequiredVersion = \'0.10.0\'; \}\}\)\"\);');

# PSD1 changes for ReleaseNotes
  - from: source-file-csharp
    where: $
    transform: $ = $.replace('sb.AppendLine\(\$@\"\{Indent\}\{Indent\}\{Indent\}ReleaseNotes = \'\'\"\);', 'sb.AppendLine\(\$@\"\{Indent\}\{Indent\}\{Indent\}ReleaseNotes = \'AzureStack Hub Admin module generated with https://github.com/Azure/autorest.powershell - see https://aka.ms/azpshmigration for breaking changes\'\"\);' );

# PSD1 Changes for preview module
  - from: source-file-csharp
    where: $
    transform: $ = $.replace('sb.AppendLine\(\$@\"\{Indent\}\{Indent\}\{Indent\}Prerelease = \{previewVersion\}\"\);', 'sb.AppendLine\(\$@\"\{Indent\}\{Indent\}\{Indent\}Prerelease = \'\{previewVersion\}\'\"\);' );

```
