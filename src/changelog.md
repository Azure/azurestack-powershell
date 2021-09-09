
# Release 2.2.0
* Requires AzureStack Update 2108+
* New module Azs.ContainerRegistry.Admin has been included exposing the apis to setup container registry in AzureStack
* New module Azs.ContainerService.Admin has been included exposing quota APIs

# Release 2.1.1
* AzureStack operator module GA version 2.1.1
* Bug fix release for signing a script file
* Bug fix in Az.BootStraper module to update the cache https://github.com/Azure/azurestack-powershell/issues/103

# Release 2.1.0-preview
* Requires AzureStack Update 2102+
* AzureStack operator module GA version 2.1.0, coming out of preview
* AzureStack Operator module version 2.1.0. Requires AzureStack Hub Update 2102+,
* There are no breaking changes from the previous release 2.0.2-preview
* Compatible with AzureStack specific Az module version 1.10.0
* The individual Azs.* module versions are updated to 1.0.0, marking GA
* Fabric Admin module adds support for changing the default Gpu partition on a GPU enabled Azure Stack hub with Set-AzsScaleUnit -NumberOfGPUPartition X

# Release 2.0.2-preview
* Bug fix for the existing 2.0.1-preview release
* Included fix for the issue - https://github.com/Azure/azurestack-powershell/issues/23

# Release 2.0.1-preview
* Minor update to the existing 2.0.0-preview release
* Included fix for the issue - https://github.com/Azure/azurestack-powershell/issues/14

# Release 2.0.0-preview
* AzureStack module generated with [autorest powershell generator](https://github.com/Azure/autorest.powershell)
* This version is compatible with [Az](https://www.powershellgallery.com/packages/Az/0.10.0-preview) modules for AzureStack
* The module is supported on AzureStack versions with Update 2002 and the hotfix

