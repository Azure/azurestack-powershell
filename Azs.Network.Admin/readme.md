<!-- region Generated -->
# Azs.Network.Admin
This directory contains the PowerShell module for the NetworkAdmin service.

---
## Status
[![Azs.Network.Admin](https://img.shields.io/powershellgallery/v/Azs.Network.Admin.svg?style=flat-square&label=Azs.Network.Admin "Azs.Network.Admin")](https://www.powershellgallery.com/packages/Azs.Network.Admin/)

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
For information on how to develop for `Azs.Network.Admin`, see [how-to.md](how-to.md).
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
  - $(repo)/specification/azsadmin/resource-manager/network/readme.azsautogen.md
```
  
### File Renames
``` yaml
module-name: Azs.Network.Admin
csproj: Azs.Network.Admin.csproj # C# project file
psd1: Azs.Network.Admin.psd1 # module manifest file
psm1: Azs.Network.Admin.psm1 # script module file
```

### Parameter default values
``` yaml
directive:
  - where:
      subject: Quota
    set:
      subject-prefix: Network
  - where:
      subject: (Location)
    hide: true
### New-AzsNetworkQuota.ps1
  - where:
      verb: New
      parameter-name: MaxLoadBalancersPerSubscription
    set:
      default:
        script: '50'
  - where:
      verb: New
      parameter-name: MaxNicsPerSubscription
    set:
      default:
        script: '100'
  - where:
      verb: New
      parameter-name: MaxPublicIpsPerSubscription
    set:
      default:
        script: '50'
  - where:
      verb: New
      parameter-name: MaxSecurityGroupsPerSubscription
    set:
      default:
        script: '50'
  - where:
      verb: New
      parameter-name: MaxVirtualNetworkGatewayConnectionsPerSubscription
    set:
      default:
        script: '2'
  - where:
      verb: New
      parameter-name: MaxVirtualNetworkGatewaysPerSubscription
    set:
      default:
        script: '1'
  - where:
      verb: New
      parameter-name: MaxVnetsPerSubscription
    set:
      default:
        script: '50'
		
subject-prefix: ''
module-version: 0.0.1
