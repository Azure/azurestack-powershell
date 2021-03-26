## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-AzsAzureBridgeDownloadedProduct -ActivationName "default" -ResourceGroupName "azurestack-activation" | Select -First 1


BillingPartNumber                                : 
CompatibilityDescription                         : 
CompatibilityIsCompatible                        : 
CompatibilityIssue                               : 
CompatibilityMessage                             : 
Description                                      : <p>Ghost is a publishing platform suitable for everything from personal blogs to major news websites. 
                                                   </p><p></p><p>For developers, its modern technology stack is flexible enough to integrate with other applications 
                                                   and tools. For content authors, content creation and management is extremely easy thanks to its simplified Ghost 
                                                   editor dashboard that lets authors use easy-to-learn markdown while simultaneously seeing the real-time output in a 
                                                   preview pane. </p><p></p><p>This image includes SSL auto-configuration with Let's Encrypt 
                                                   certificates.</p><p></p><p>This open source solution is packaged by Bitnami. Learn how to install, configure, and 
                                                   manage it at docs.bitnami.com. For deployment issues, reach out our support team at 
                                                   community.bitnami.com.</p><p></p><p>Why use Bitnami Certified Apps? </p><p></p><p>Bitnami certified images are 
                                                   always up-to-date, secure, and built to work right out of the box. </p><p></p><p>Bitnami packages applications 
                                                   following industry standards, and continuously monitors all components and libraries for vulnerabilities and 
                                                   application updates. When any security threat or update is identified, Bitnami automatically repackages the 
                                                   applications and pushes the latest versions to the cloud marketplaces.</p><br>Ghost 3.37.1-0 (Debian 10)
DisplayName                                      : Ghost Certified by Bitnami
GalleryItemIdentity                              : bitnami.ghostdefault.1.0.158
GalleryPackageBlobSasUri                         : 
IconUriHero                                      : 
IconUriLarge                                     : https://azstmktprodwcu001.blob.core.windows.net/icons/18d250d22e84486b8d68e196c0638e92/Large.png
IconUriMedium                                    : https://azstmktprodwcu001.blob.core.windows.net/icons/18d250d22e84486b8d68e196c0638e92/Medium.png
IconUriSmall                                     : https://azstmktprodwcu001.blob.core.windows.net/icons/18d250d22e84486b8d68e196c0638e92/Small.png
IconUriWide                                      : https://azstmktprodwcu001.blob.core.windows.net/icons/18d250d22e84486b8d68e196c0638e92/Wide.png
Id                                               : /subscriptions/4d6112db-c97e-47d6-abd9-97ce61f62f2e/resourceGroups/azurestack-activation/providers/Microsoft.AzureBri
                                                   dge.Admin/activations/default/downloadedProducts/bitnami.ghostdefault-3.37.2011041158
LegalTerm                                        : Bitnami Terms of Use can be found at <a 
                                                   href="https://www.vmware.com/help/legal.html">https://www.vmware.com/help/legal.html</a>
Link                                             : {Learn More, Documentation, License Agreement, Bitnami Support}
Location                                         : 
Name                                             : default/bitnami.ghostdefault-3.37.2011041158
Offer                                            : ghost
OfferVersion                                     : 1038
PayloadLength                                    : 32212300322
PrivacyPolicy                                    : https://www.vmware.com/help/privacy.html
ProductDetailPropertyComputeRole                 : 
ProductDetailPropertyDataDiskImage               : 
ProductDetailPropertyIsSystemExtension           : 
ProductDetailPropertyOSDiskImageOperatingSystem  : 
ProductDetailPropertyOSDiskImageSourceBlobSasUri : 
ProductDetailPropertySourceBlobUri               : 
ProductDetailPropertySupportMultipleExtension    : 
ProductDetailPropertyVMScaleSetEnabled           : 
ProductDetailPropertyVersion                     : 
ProductDetailPropertyVmosType                    : 
ProductKind                                      : virtualMachine
ProductProperties                                : 3.37.2011041158
ProvisioningState                                : Succeeded
PublisherDisplayName                             : Bitnami
PublisherIdentifier                              : Bitnami
Sku                                              : default
Tag                                              : Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ResourceTags
Type                                             : Microsoft.AzureBridge.Admin/activations/downloadedProducts
VMExtensionType                                  : 
```

Get a list of Azure Bridge Downloaded products

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Get-AzsAzureBridgeDownloadedProduct -Name 'microsoft.windowsserver2016-datacenter-payg-14393.3986.2010070045' -ActivationName 'default' -ResourceGroupName 'azurestack-activation'


BillingPartNumber                                : 
CompatibilityDescription                         : 
CompatibilityIsCompatible                        : 
CompatibilityIssue                               : 
CompatibilityMessage                             : 
Description                                      : Windows Server 2016 is a comprehensive server operating system designed to run the applications and infrastructure 
                                                   that power your business. It includes built-in layers of security and innovation to help you run traditional and 
                                                   cloud-native applications with confidence.<p><h3 class='msportalfx-text-header'>Legal Terms</h3></p><p>By clicking 
                                                   the Create button, I acknowledge that I am getting this software from Microsoft and that the <a 
                                                   href='https://go.microsoft.com/fwlink/?linkid=2014360' target='_blank'>legal terms</a> of Microsoft apply to it. 
                                                   Microsoft does not provide rights for third-party software. Also see the <a 
                                                   href='https://go.microsoft.com/fwlink/?LinkId=521839' target='_blank'>privacy statement</a> from Microsoft.</p>
DisplayName                                      : Windows Server 2016 Datacenter-Pay as you go
GalleryItemIdentity                              : Microsoft.WindowsServer2016Datacenter-ARM.14393.3986.2010070045
GalleryPackageBlobSasUri                         : 
IconUriHero                                      : 
IconUriLarge                                     : https://azstmktprodwcu001.blob.core.windows.net/icons/e3a0aa9e4c4f49e1ad94f10524499a39/Large.png
IconUriMedium                                    : https://azstmktprodwcu001.blob.core.windows.net/icons/e3a0aa9e4c4f49e1ad94f10524499a39/Medium.png
IconUriSmall                                     : https://azstmktprodwcu001.blob.core.windows.net/icons/e3a0aa9e4c4f49e1ad94f10524499a39/Small.png
IconUriWide                                      : https://azstmktprodwcu001.blob.core.windows.net/icons/e3a0aa9e4c4f49e1ad94f10524499a39/Wide.png
Id                                               : /subscriptions/4d6112db-c97e-47d6-abd9-97ce61f62f2e/resourceGroups/azurestack-activation/providers/Microsoft.AzureBri
                                                   dge.Admin/activations/default/downloadedProducts/microsoft.windowsserver2016-datacenter-payg-14393.3986.2010070045
LegalTerm                                        : https://go.microsoft.com/fwlink/?linkid=2014360
Link                                             : 
Location                                         : 
Name                                             : default/microsoft.windowsserver2016-datacenter-payg-14393.3986.2010070045
Offer                                            : windowsserver
OfferVersion                                     : 14393.3986.2010070045
PayloadLength                                    : 136367658454
PrivacyPolicy                                    : https://go.microsoft.com/fwlink/?LinkId=521839
ProductDetailPropertyComputeRole                 : 
ProductDetailPropertyDataDiskImage               : 
ProductDetailPropertyIsSystemExtension           : 
ProductDetailPropertyOSDiskImageOperatingSystem  : 
ProductDetailPropertyOSDiskImageSourceBlobSasUri : 
ProductDetailPropertySourceBlobUri               : 
ProductDetailPropertySupportMultipleExtension    : 
ProductDetailPropertyVMScaleSetEnabled           : 
ProductDetailPropertyVersion                     : 
ProductDetailPropertyVmosType                    : 
ProductKind                                      : virtualMachine
ProductProperties                                : 14393.3986.2010070045
ProvisioningState                                : Succeeded
PublisherDisplayName                             : Microsoft
PublisherIdentifier                              : MicrosoftWindowsServer
Sku                                              : 2016-Datacenter
Tag                                              : Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ResourceTags
Type                                             : Microsoft.AzureBridge.Admin/activations/downloadedProducts
VMExtensionType                                  : 
```

Get an Azure Bridge Downloaded Product by Name