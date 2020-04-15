Welcome to AzureStack Powershell repository!

The repo holds the modules for the AzureStack Hub operator persona. The Azurestack hub admin APIs are exposed as powershell via this repo

Most of the modules are generated with the autorest tool (https://github.com/Azure/autorest.powershell) and some modules are hand written.

## Contents
### /src folder
This is for source of all the admin api modules. This could also contain the helper cmdlets over azurestack/azure integration
For many of the modules only the metadata configuration files would be present as the modules are generated as described in the following sections

### /tools folder
This contains files that are essential for devops pipelines and security scans

### /docs folder
This contains the migration guides and general information docs

## Dev Setup
### Prerequisites
1. Install NodeJs: https://nodejs.org/ (recommended v10, https://nodejs.org/download/release/v10.15.3/)
    a. Please do make sure that you have the recommended version. The latest seems to have issues in generation
2. install new autorest beta packge: npm install -g @autorest/autorest
3. Install PS core: npm install -g pwsh
4. Install .net core: npm install -g dotnet-sdk-2.2

### Build

1. Go to module directory src/Azs.Network.Admin
2. Run: 
    * autorest-beta
    * pwsh
    * .\build-module.ps1
3. All generated cmdlets will be inside 'exports' folder
4. The module can be imported using the 'Azs.<ModuleName>.Admin.psd1' (e.g. Azs.Network.Admin.psd1) from the module directory

### Customizations:
The docs for cusotmization can be found under https://github.com/Azure/autorest.powershell/tree/master/docs
* Input specs files: declare it inside the readme.md file in the azure-rest-api-specs  repo using input-file cmd
e.g. 
``` yaml
input-file:
    - "$(this-folder)/Microsoft.Network.Admin/preview/2015-06-15/Network.json"
    - "$(this-folder)/Microsoft.Network.Admin/preview/2015-06-15/LoadBalancers.json"
    - "$(this-folder)/Microsoft.Network.Admin/preview/2015-06-15/PublicIpAddresses.json" 
    - "$(this-folder)/Microsoft.Network.Admin/preview/2015-06-15/Quotas.json"
    - "$(this-folder)/Microsoft.Network.Admin/preview/2015-06-15/VirtualNetworks.json"
```
* Include the above file in the azure-powershell module directory's readme.md file using require cmd 

``` yaml 
require:
  - $(repo)/specification/azsadmin/resource-manager/network/readme.md
```
* Directives:
Built-in Directives support renaming cmdlets/parameters/properties of models, adding alias, setting default value, etc. These are declared in readme.md and would take effect for the generated module. Refer to https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md for the supported directives.
Example: https://github.com/Azure/azure-powershell/blob/stackadmin/src/StackAdmin/Azs.Network.Admin/readme.md
    i. Removing InputObject parameter from the New-* cmdlet
        ## variant removal (parameter InputObject) from all New cmdlets -- parameter sets CreateViaIdentity and CreateViaIdentityExpanded
  - where:
      verb: New
      variant: ^CreateViaIdentity(.*)
     remove: true

* Customization:
For other customizations that directives do not support, use customization instead. Refer to https://github.com/Azure/autorest/blob/master/docs/powershell/customization.md for full instruction.
A simple example is to change the param type from String to SecureString, to achieve this:
    1. Hide the cmdlet in md so that the original param with String type won't conflict with the SecureString param with same name;
    2. Generate the module and copy the .ps1 file from internal folder to custom folder;
    3. Edit the copied .ps1 file to do the customization. Change the param type to SecureString, and convert to plaintext inside cmdlet, replace the PSBoundParameters with the converted value;
    4. Call the internal cmdlet with the updated PSBoundParameters https://github.com/azure/azurestack-powershell/blob/master/src/Azs.Backup.Admin/custom/Set-AzsBackupConfiguration.ps1


