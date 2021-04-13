<!-- region Generated -->
# Azs.Gallery.Admin
This directory contains the PowerShell module for the Gallery service.

---
## Status
[![Azs.Gallery.Admin](https://img.shields.io/powershellgallery/v/Azs.Gallery.Admin.svg?style=flat-square&label=Azs.Gallery.Admin "Azs.Gallery.Admin")](https://www.powershellgallery.com/packages/Azs.Gallery.Admin/)

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
For information on how to develop for `Azs.Gallery.Admin`, see [how-to.md](how-to.md).
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

input-file:
  - $(repo)/specification/azsadmin/resource-manager/gallery/Microsoft.Gallery.Admin/preview/2015-04-01/Gallery.json
  - $(repo)/specification/azsadmin/resource-manager/gallery/Microsoft.Gallery.Admin/preview/2015-04-01/GalleryItem.json

metadata:
  description: 'Microsoft AzureStack PowerShell: Gallery Admin cmdlets'

### PSD1 metadata changes
subject-prefix: ''
module-version: 1.0.0
service-name: GalleryAdmin

```

### File Renames
### IMPORTANT - Note that the following settings are case sensitive ###
```yaml
module-name: Azs.Gallery.Admin
csproj: Azs.Gallery.Admin.csproj
psd1: Azs.Gallery.Admin.psd1
psm1: Azs.Gallery.Admin.psm1
```

### Parameter default values

``` yaml
directive:
## variant removal (parameter InputObject) from all New cmdlets -- parameter sets CreateViaIdentity and CreateViaIdentityExpanded
  - where:
      verb: New
      variant: ^CreateViaIdentity(.*)
    remove: true
  - where:
      model-name: GalleryItem
    set:
      format-table:
        properties:
          - Name
          - Publisher
          - PublisherDisplayName
          - ItemName
          - ItemDisplayName
          - Version
          - Summary
  - where:
      verb: New
      subject: GalleryItem
    set:
      verb: Add
      subject: GalleryItem

# Add release notes
  - from: Azs.Gallery.Admin.nuspec
    where: $
    transform: $ = $.replace('<releaseNotes></releaseNotes>', '<releaseNotes>AzureStack Hub Admin module generated with https://github.com/Azure/autorest.powershell.</releaseNotes>');

# Add Az.Accounts/Az.Resources as dependencies
  - from: Azs.Gallery.Admin.nuspec
    where: $
    transform: $ = $.replace('<dependency id=\"Az.Accounts\" version=\"1.6.0\" />', '<dependency id="Az.Accounts" version="2.2.8" />\n      <dependency id="Az.Resources" version="[1.10.0]" />');

# PSD1 changes for RequiredModules
  - from: source-file-csharp
    where: $
    transform: $ = $.replace('sb.AppendLine\(\$@\"\{Indent\}RequiredAssemblies = \'\{\"./bin/Azs.Gallery.Admin.private.dll\"\}\'\"\);', 'sb.AppendLine\(\$@\"\{Indent\}RequiredAssemblies = \'\{\"./bin/Azs.Gallery.Admin.private.dll\"\}\'\"\);\n      sb.AppendLine\(\$@\"\{Indent\}RequiredModules = @\(@\{\{ModuleName = \'Az.Accounts\'; ModuleVersion = \'2.2.8\'; \}\}, @\{\{ModuleName = \'Az.Resources\'; RequiredVersion = \'1.10.0\'; \}\}\)\"\);');

# PSD1 changes for ReleaseNotes
  - from: source-file-csharp
    where: $
    transform: $ = $.replace('sb.AppendLine\(\$@\"\{Indent\}\{Indent\}\{Indent\}ReleaseNotes = \'\'\"\);', 'sb.AppendLine\(\$@\"\{Indent\}\{Indent\}\{Indent\}ReleaseNotes = \'AzureStack Hub Admin module generated with https://github.com/Azure/autorest.powershell\'\"\);' );
