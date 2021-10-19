### Example 1: Get Compute Scale Unit
```powershell
PS C:\> Get-AzsComputeScaleUnit -Name s-cluster -Location redmond -SubscriptionId "DC773456-D727-484E-8292-AE8FACFDDDF5"

Scale Unit Name   Location   Nodes
---------------   --------   -----
s-cluster         redmond    {AzSNode1,AzSNode2,AzSNode3,AzSNode4}
```