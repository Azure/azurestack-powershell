
This document serves as both a breaking change notification and migration guide for consumers of the AzureStack powershell version 2.0.0-preview. The module AzureStack 2.0.0-preview is compatible with both powershell core and windows powershell. The modules an also be installed on MacOs and Linux in addition to Windows.

The previous version 1.8.1 is combatible only with windows powershell and does not support Mac/Linux platforms. The version 1.8.1 also requires AzureRM modules instead of Az.

The modules are generated with the autorest tool (https://github.com/Azure/autorest.powershell).

## Breaking Changes

- [Common Changes](#common-changes)
- [Azs.Backup.Admin](#azs-backup-admin)
- [Azs.Network.Admin](#azs-network-admin)
- [Azs.Fabric.Admin](#azs-fabric-admin)
- [Azs.Storage.Admin](#azs-storage-admin)
- [Azs.Subscriptions.Admin](#azs-subscriptions-admin)
- [Azs.Subscriptions](#azs-subscriptions)

## Common Changes

### Az.Accounts dependency
All AzureStack Admin modules have dependency on the Az.Accounts module version 2.0.1-preview. This version of Az.Accounts module is built with MSAL dll(https://github.com/AzureAD/microsoft-authentication-library-for-dotnet). This supports ADFS scnearios and device code authentication

### Output Model Changes
Output models of all the cmdlets have changed. Since the powershell modules are generated with the new autorest powershell extension, the outpu models have all changed considerably. If the existing scripts are accessing the output model, they likely need a change. Since the output model changes are huge and it impact each and every cmdlet, this guide does not list each of the changes

### Removal of -AsJob feature
The current version of the cmdlets do not support -AsJob paramter. It will get added in a future release as auotorest powershell generator evolves.

### Removal of -ResourceId Parameter
The ResourceId paramter got removed in all of the cmdlets. The Id is part of the InputObject parameter set now. So we could still use the piping with Id.

### Removal of -Force Parameter
The -Force paramter has been removed from the following cmdlets. The cmdlets would honor the $ConfirmPreference.  
    - `Remove-AzsAzureBridgeDownloadedProduct`
    - `Start-AzsBackup`
    - `Remove-AzsComputeQuota`
    - `Remove-AzsPlatformImage`
    - `Remove-AzsVMExtension`
    - `Remove-AzsGalleryItem`
    - `Remove-AzsNetworkQuota`
    - `Remove-AzsStorageQuota`

## Azs.Backup.Admin
### **Set-AzsBackupConfiguration**
	- Parameter -IsBackupSchedulerEnabled has been changed from [bool] to [switch] in the cmldet 
## Azs.Network.Admin
### **Set-AzsComputeQuota**
- Parameter set of updating existing compute quota only by specififying the needed fields got deprecated. To update an existing quota user needs to get the quota object, modify the properties and pipe the object to set cmldet

## Azs.Network.Admin
### **Set-AzsNetworkQuota**
- Parameter set of updating existing network quota only by specififying the needed fields got deprecated. To update an existing quota user needs to get the quota object, modify the properties and pipe the object to set cmldet

## Azs.Fabric.Admin
### **Get-AzsInfrastructureRoleInstance **
- Return property changed: The object Size (.Cores/.MemoryInGB) is flatten to NumberOfCores and SizeMemoryInGB
### **Get-AzsScaleUnit**
- Return property changed: The object TotalCapacity (.Cores/.MemoryInGB) is flatten to TotalCapacityOfCores and TotalCapacityOfMemoryInGB
### **Get-AzsScaleUnitNode**
- Return property changed: The object Capacity (.Cores/.MemoryInGB) is flatten to CapacityOfCores  and CapacityOfMemoryInGB

## Azs.Storage.Admin
### **Update-AzsStorageSettings**
- The cmdlet Update-AzsStorageSettings has been renamed to Set-AzsStorageSettings
- A new parameter -Force has also been added
## Set-AzsStorageQuota
-The pipeable parameter -InputObject has been renamed to -QuotaObject to avoid confusion. This is not a breaking change for pipeline scenario.

## Azs.Subscriptions.Admin
### **Get-AzsDelegatedProviderManagedOffer**
- Parameter DelegatedProvider has been deprecated. Please use DelegatedProviderSubscriptionId parameter or the alias DelegatedProviderId instead.

### **New-AzsSubscriptionPlan**, **Get-AzsSubscriptionPlan**, **Remove-AzsSubscriptionPlan**
- Parameter AcquisitionId has been deprecated. Please use PlanAcquisitionId parameter instead. 

### **SubscriptionId renamed to TargetSubscriptionId**
- Parameter SubscriptionId  has been deprecated. Please use the parameter TargetSubscriptionId instead. The affected cmdlets are Get-AzsUserSubscription, New-AzsOfferDelegation, New-AzsUserSubscription, Remove-AzsUserSubscription and Set-AzsUserSubscription

### **Move-AzsSubscription**
- The cmdlet Move-AzsSubscription has been renamed to Move-AzsUserSubscription

### **ArmLocation parmeter deprecated**
- Parameter ArmLocation deprecated. Please use Location parameter instead. The affected cmdlets are New-AzsOffer, New-AzsPlan, Set-AzsOffer, Set-AzsPlan

### **Set-AzsUserSubscription**
- The parameter set that takes each individial parameter has been deprecated. To update the subscription, the user object should be retrieved with the Get command, modify the needed properties in the object and then pipe it to the Set command. The parameter Location has been deprecated

## Azs.Subscriptions
### **New-AzsSubscription**
- The parameter Location has been deprecated

### Set-AzsSubscription
- The parameter Type and Tags has been deprecated
