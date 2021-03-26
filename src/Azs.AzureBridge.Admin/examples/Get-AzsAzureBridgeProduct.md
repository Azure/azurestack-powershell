## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-AzsAzureBridgeProduct -ActivationName 'default' -ResourceGroupName 'azurestack-activation' | Select -First 5 | ft *

BillingPartNumber CompatibilityDescription CompatibilityIsCompatible CompatibilityIssue CompatibilityMessage Description DisplayName                                    
----------------- ------------------------ ------------------------- ------------------ -------------------- ----------- -----------                                    
                  None                                          True {}                 None                             Acronis Backup for Linux (preview)             
                  None                                          True {}                 None                             CoreOS Linux (Stable)                          
                  None                                          True {}                 None                             Custom Script Extension                        
                  None                                          True {}                 None                             BGInfo                                         
                  None                                          True {}                 None                             Free License: SQL Server 2016 SP2 Express on...

```

Get a list of Products available for download from Azure Marketplace.

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Get-AzsAzureBridgeProduct -ActivationName 'default' -ResourceGroupName 'azurestack-activation' -Name 'microsoft.sqliaasextension-1.3.20590'


BillingPartNumber         : 
CompatibilityDescription  : None
CompatibilityIsCompatible : True
CompatibilityIssue        : {}
CompatibilityMessage      : None
Description               : This extension is required for deploying SQL Server Windows-based VMs on Azure Stack
DisplayName               : SqlIaaSExtension
GalleryItemIdentity       : Microsoft.SqlIaaSExtension.1.3.20590
IconUriHero               : 
IconUriLarge              : https://azstmktprodwcu001.blob.core.windows.net/icons/dbf187f0c64c467f931482ee778e5a04/Large.png
IconUriMedium             : https://azstmktprodwcu001.blob.core.windows.net/icons/dbf187f0c64c467f931482ee778e5a04/Medium.png
IconUriSmall              : https://azstmktprodwcu001.blob.core.windows.net/icons/dbf187f0c64c467f931482ee778e5a04/Small.png
IconUriWide               : https://azstmktprodwcu001.blob.core.windows.net/icons/dbf187f0c64c467f931482ee778e5a04/Wide.png
Id                        : /subscriptions/4d6112db-c97e-47d6-abd9-97ce61f62f2e/resourceGroups/azurestack-activation/providers/Microsoft.AzureBridge.Admin/activations/d
                            efault/products/microsoft.sqliaasextension-1.3.20590
LegalTerm                 : 
Link                      : {}
Location                  : 
Name                      : default/microsoft.sqliaasextension-1.3.20590
Offer                     : 
OfferVersion              : 
PayloadLength             : 7419601
PrivacyPolicy             : 
ProductKind               : virtualMachineExtension
ProductProperties         : 1.3.20590
ProvisioningState         : Succeeded
PublisherDisplayName      : Microsoft
PublisherIdentifier       : Microsoft.SqlServer.Management
Sku                       : 
Tag                       : Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ResourceTags
Type                      : Microsoft.AzureBridge.Admin/activations/products
VMExtensionType           : 
```

Get a product info available for download from Azure Marketplace by Name.