### Example 1: Update the Global Feature Settings
```powershell
PS C:\> Update-AzsComputeGlobalFeatureSetting -FeatureName Microsoft.Compute.EmergencyVMAccess -GlobalFeatureState Enabled -Location local
```

A successful call to update a feature's global settings will not return any output