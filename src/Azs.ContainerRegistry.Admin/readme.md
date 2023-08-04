<!-- region Generated -->
# Azs.ContainerRegistry.Admin
This directory contains the PowerShell module for the ContainerRegistryAdmin service.

---
## Status
[![Azs.ContainerRegistry.Admin](https://img.shields.io/powershellgallery/v/Azs.ContainerRegistry.Admin.svg?style=flat-square&label=Azs.ContainerRegistry.Admin "Azs.ContainerRegistry.Admin")](https://www.powershellgallery.com/packages/Azs.ContainerRegistry.Admin/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Module Requirements
- [Az.Accounts module](https://www.powershellgallery.com/packages/Az.Accounts/), version 2.12.5

## Authentication
AutoRest does not generate authentication code for the module. Authentication is handled via Az.Accounts by altering the HTTP payload before it is sent.

## Development
For information on how to develop for `Azs.ContainerRegistry.Admin`, see [how-to.md](how-to.md).
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
  - $(repo)/specification/azsadmin/resource-manager/containerregistry/readme.azsautogen.md

metadata:
  description: 'Microsoft AzureStack PowerShell: ContainerRegistry Admin cmdlets'

### PSD1 metadata changes
subject-prefix: ''
module-version: 0.2.0
service-name: ContainerRegistryAdmin

### File Renames
### IMPORTANT - Note that the following settings are case sensitive ###
module-name: Azs.ContainerRegistry.Admin
csproj: Azs.ContainerRegistry.Admin.csproj
psd1: Azs.ContainerRegistry.Admin.psd1
psm1: Azs.ContainerRegistry.Admin.psm1
```

### Parameter default values
``` yaml
directive:
    # Prepend ContainerRegistry for the Quota cmdlets
  - where:
      subject: Quota
    set:
      subject-prefix: ContainerRegistry

    # Rename cmdlet parameter name and set default value in ContainerRegistryQuota
  - where:
      verb: New
      subject: Quota
      parameter-name: capacityPerRegistryInGiB
    set:
      default:
        script: '100'
  - where:
      subject: Quota
      parameter-name: NumberOfRegistry
    set:
      parameter-name: NumberOfRegistries
  - where:
      verb: New
      subject: Quota
      parameter-name: NumberOfRegistries
    set:
      default:
        script: '20'
        
    # Rename cmdlet parameter name in ContainerRegistryConfiguration
  - where:
      subject: ContainerRegistryConfiguration
      parameter-name: ConfigurationName
    set:
      parameter-name: Name
  - where:
      verb: Remove
      subject: ContainerRegistryConfiguration
      parameter-name: Name
    hide: true
    set:
      default:
        script: Write-Output "default"
  - where:
      verb: Set
      subject: ContainerRegistryConfiguration
      parameter-name: Name
    hide: true
    set:
      default:
        script: Write-Output "default"
  - where:
      verb: Remove
      subject: ContainerRegistryConfiguration
    hide: true
    
    # Rename cmdlet parameter name in ContainerRegistrySetup
  - where:
      subject: ContainerRegistrySetup
      parameter-name: SslCertBase64
    set:
      parameter-name: Certificate

    # Rename model property names
  - where:
      model-name: ContainerRegistryQuota
      property-name: NumberOfRegistry
    set:
      property-name: NumberOfRegistries
      
    # Hide the auto-generated New-AzsContainerRegistryQuota and expose it through customized one
    # The customization makes the Quota parameters optional and add default values in case if parameter skiped
  - where:
      verb: New
      subject: Quota
    hide: true

    # Hide the auto-generated Set-AzsContainerRegistryQuota and expose it through customized one
    # The customization makes the Quota parameters optional and add existed values in case if parameter skiped
  - where:
      verb: Set
      subject: Quota
    hide: true
 
    # Hide the auto-generated Start-AzsContainerRegistrySetup and expose it through customized one
    # The customization adds basic validation for PFX file
  - where:
      verb: Start
      subject: ContainerRegistrySetup
    hide: true
    
# Add release notes
  - from: Azs.ContainerRegistry.Admin.nuspec
    where: $
    transform: $ = $.replace('<releaseNotes></releaseNotes>', '<releaseNotes>AzureStack Hub Admin module generated with https://github.com/Azure/autorest.powershell.</releaseNotes>');

# Add Az.Accounts/Az.Resources as dependencies
  - from: Azs.ContainerRegistry.Admin.nuspec
    where: $
    transform: $ = $.replace('<dependency id="Az.Accounts" version="2.2.3" />', '<dependency id="Az.Accounts" version="[2.12.5]" />\n      <dependency id="Az.Resources" version="[6.9.0]" />');

# PSD1 changes for ReleaseNotes
  - from: source-file-csharp
    where: $
    transform: $ = $.replace('sb.AppendLine\(\$@\"\{Indent\}\{Indent\}\{Indent\}ReleaseNotes = \'\'\"\);', 'sb.AppendLine\(\$@\"\{Indent\}\{Indent\}\{Indent\}ReleaseNotes = \'AzureStack Hub Admin module generated with https://github.com/Azure/autorest.powershell\'\"\);' );
```
