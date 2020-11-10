<!-- region Generated -->
# Azs.Azurebridge.Admin
This directory contains the PowerShell module for the BridgeAdmin service.

---
## Status
[![Azs.Azurebridge.Admin](https://img.shields.io/powershellgallery/v/Azs.Azurebridge.Admin.svg?style=flat-square&label=Azs.Azurebridge.Admin "Azs.Azurebridge.Admin")](https://www.powershellgallery.com/packages/Azs.Azurebridge.Admin/)

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
For information on how to develop for `Azs.Azurebridge.Admin`, see [how-to.md](how-to.md).
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
  - $(repo)/specification/azsadmin/resource-manager/azurebridge/readme.md

metadata:
  description: 'Microsoft AzureStack PowerShell: AzureBridge Admin cmdlets'

subject-prefix: AzureBridge
module-version: 1.0.0
identity-correction-for-post: true
service-name: BridgeAdmin

### File Renames
module-name: Azs.Azurebridge.Admin
csproj: Azs.Azurebridge.Admin.csproj
psd1: Azs.Azurebridge.Admin.psd1
psm1: Azs.Azurebridge.Admin.psm1

directive:  
  - where:
        model-name: ActivationResource
    set:
        suppress-format: true
  - where:
        model-name: ProductResource
    set:
        suppress-format: true
  - where:
        model-name: DownloadedProductResource
    set:
        suppress-format: true
  
  # Add alias for ProductName to Name
  - where:
        parameter-name: ProductName
    set:
        alias: Name

# Rename Properties
  - where:
      model-name: ProductResource
      property-name: ProductPropertyVersion
    set:
      property-name: ProductProperties

  - where:
      model-name: DownloadedProductResource
      property-name: ProductPropertyVersion
    set:
      property-name: ProductProperties

  # Rename DownloadProduct to ProductDownload
  - where:
      verb: Invoke
      subject: DownloadProduct
    set:
      subject: ProductDownload

  # Remove cmdlets that don't exist in AzureRm module
  - where:
      verb: Set
    remove: true.
  - where:
      verb: New
    remove: true.
  - where:
      verb: Remove
      subject: Activation
    remove: true.

# Add release notes
  - from: Azs.Azurebridge.Admin.nuspec
    where: $
    transform: $ = $.replace('<releaseNotes></releaseNotes>', '<releaseNotes>AzureStack Hub Admin module generated with https://github.com/Azure/autorest.powershell - see https://aka.ms/azpshmigration for breaking changes.</releaseNotes>');

# Add Az.Accounts/Az.Resources as dependencies
  - from: Azs.Azurebridge.Admin.nuspec
    where: $
    transform: $ = $.replace('<dependency id=\"Az.Accounts\" version=\"1.6.0\" />', '<dependency id="Az.Accounts" version="[2.0.1-preview]" />\n      <dependency id="Az.Resources" version="[0.10.0-preview]" />');

# PSD1 changes for RequiredModules
  - from: source-file-csharp
    where: $
    transform: $ = $.replace('sb.AppendLine\(\$@\"\{Indent\}RequiredAssemblies = \'\{\"./bin/Azs.Azurebridge.Admin.private.dll\"\}\'\"\);', 'sb.AppendLine\(\$@\"\{Indent\}RequiredAssemblies = \'\{\"./bin/Azs.Azurebridge.Admin.private.dll\"\}\'\"\);\n      sb.AppendLine\(\$@\"\{Indent\}RequiredModules = @\(@\{\{ModuleName = \'Az.Accounts\'; ModuleVersion = \'2.0.1\'; \}\}, @\{\{ModuleName = \'Az.Resources\'; RequiredVersion = \'0.10.0\'; \}\}\)\"\);');

# PSD1 changes for ReleaseNotes
  - from: source-file-csharp
    where: $
    transform: $ = $.replace('sb.AppendLine\(\$@\"\{Indent\}\{Indent\}\{Indent\}ReleaseNotes = \'\'\"\);', 'sb.AppendLine\(\$@\"\{Indent\}\{Indent\}\{Indent\}ReleaseNotes = \'AzureStack Hub Admin module generated with https://github.com/Azure/autorest.powershell - see https://aka.ms/azpshmigration for breaking changes\'\"\);' );
```
