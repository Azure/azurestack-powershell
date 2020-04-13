### Example 1: Get-AzsGalleryItem
```powershell
PS C:\> Get-AzsGalleryItem -Name TestUbuntu.Test.1.0.0

Name                  Publisher  PublisherDisplayName ItemName ItemDisplayName       Version Summary
----                  ---------  -------------------- -------- ---------------       ------- -------
TestUbuntu.Test.1.0.0 TestUbuntu TestUbuntu           Test     Test.TestUbuntu.1.0.0 1.0.0   Create a simple VM
```
Gets the gallery item by name.

### Example 2: List Gallery Items
```powershell
PS C:\> Get-AzsGalleryItem

Name                                       Publisher PublisherDisplayName  ItemName                  ItemDisplayName
----                                       --------- --------------------  --------                  ---------------
Canonical.UbuntuServer1804LTS-ARM.1.0.3    Canonical Canonical             UbuntuServer1804LTS-ARM   Ubuntu Server 1...
Microsoft.AddOnRP-WindowsServer.1.1910.3   Microsoft Microsoft             AddOnRP-WindowsServer     Microsoft Azure...
Microsoft.AdminOffer.6.0.0                 Microsoft Microsoft Corporation AdminOffer                Offer
Microsoft.AvailabilitySet-ARM.1.0.1        Microsoft Microsoft             AvailabilitySet-ARM       Availability Set
Microsoft.Connection-ARM.1.2.2             Microsoft Microsoft             Connection-ARM            Connection
Microsoft.CustomScriptExtension-arm.2.0.10 Microsoft Microsoft Corp.       CustomScriptExtension-arm Custom Script E...
Microsoft.DSC-arm.2.0.7                    Microsoft Microsoft Corp.       DSC-arm                   PowerShell Desi...
Microsoft.DnsZone-ARM.1.0.1                Microsoft Microsoft             DnsZone-ARM               DNS zone
Microsoft.Image-ARM.1.0.2                  Microsoft Microsoft             Image-ARM                 Image
Microsoft.KeyVault.1.0.14                  Microsoft Microsoft             KeyVault                  Key Vault
Microsoft.LoadBalancer-ARM.1.0.2           Microsoft Microsoft             LoadBalancer-ARM          Load Balancer
Microsoft.LocalNetworkGateway-ARM.1.0.3    Microsoft Microsoft             LocalNetworkGateway-ARM   Local network g...
Microsoft.ManagedDisk-ARM.1.0.2            Microsoft Microsoft             ManagedDisk-ARM           Managed Disks
Microsoft.NetworkInterface-ARM.1.0.4       Microsoft Microsoft             NetworkInterface-ARM      Network interface
Microsoft.NetworkSecurityGroup-ARM.1.0.4   Microsoft Microsoft             NetworkSecurityGroup-ARM  Network securit...
Microsoft.Offer.6.0.0                      Microsoft Microsoft Corporation Offer                     Offer
Microsoft.Plan.6.0.0                       Microsoft Microsoft Corporation Plan                      Plan
Microsoft.PublicIPAddress-ARM.1.0.2        Microsoft Microsoft             PublicIPAddress-ARM       Public IP address
Microsoft.PublicIPPool-ARM.1.0.0           Microsoft Microsoft             PublicIPPool-ARM          Public IP pool
Microsoft.ResourceGroup.6.0.0              Microsoft Microsoft             ResourceGroup             Resource group
Microsoft.RouteTable-ARM.1.0.2             Microsoft Microsoft             RouteTable-ARM            Route table
Microsoft.ScaleUnitNode-ARM.1.0.0          Microsoft Microsoft             ScaleUnitNode-ARM         Scale Unit Node
Microsoft.Snapshot-ARM.1.0.2               Microsoft Microsoft             Snapshot-ARM              Snapshot
Microsoft.StorageAccount-ARM.101.0.1       Microsoft Microsoft             StorageAccount-ARM        Storage account
Microsoft.StorageAccount-ARM.1.0.3         Microsoft Microsoft             StorageAccount-ARM        Storage account...
Microsoft.Template.6.0.0                   Microsoft Microsoft             Template                  Template deploy...
Microsoft.TenantSubscription.6.0.0         Microsoft Microsoft Corporation TenantSubscription        Subscription
Microsoft.VirtualMachine-ARM.1.0.2         Microsoft Microsoft             VirtualMachine-ARM        Virtual machine
Microsoft.VirtualNetwork-ARM.1.0.4         Microsoft Microsoft             VirtualNetwork-ARM        Virtual network
Microsoft.VirtualNetworkGateway-ARM.1.0.3  Microsoft Microsoft             VirtualNetworkGateway-ARM Virtual network...
microsoft.antimalware-windows-arm.1.0.0    microsoft Microsoft Corp.       antimalware-windows-arm   Microsoft Antim...
microsoft.custom-script2-linux-arm.3.0.0   microsoft Microsoft Corp.       custom-script2-linux-arm  Custom Script F...
microsoft.custom-script-linux-arm.2.0.50   microsoft Microsoft Corp.       custom-script-linux-arm   Custom Script F...
microsoft.docker-arm.1.1.0                 microsoft Microsoft             docker-arm                Docker
microsoft.vmss.7.1.7                       microsoft Microsoft             vmss                      Virtual machine...

```

Lists all the items available in the Azure Stack gallery.
