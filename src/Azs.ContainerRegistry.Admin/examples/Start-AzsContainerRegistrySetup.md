### Example 1: Start Azs ContainerRegistry Setup
```powershell
PS C:\> Start-AzsContainerRegistrySetup -Password $password -SslCertInputFile $pfx_cert_path | ConvertTo-Json

{
    "Id":  "/subscriptions/7e41090c-4aa7-40bc-856a-a993f8fbd215/providers/Microsoft.ContainerRegistry.Setup/locations/redmond/setup/value",
    "Name":  "redmond/value",
    "StatusUri":  "https://containerregistrysetup.ascu.azs:4335/providers/Microsoft.ContainerRegistry.Setup/subscriptions/7e41090c-4aa7-40bc-856a-a993f8fbd215/providers/Microsoft.ContainerRegistry.Setup/locations/redmond/setup?api-version=2019-11-01-preview",
    "Type":  "Microsoft.ContainerRegistry.Setup/locations/setup"
}
```

Invokes container registry certificate uploading and service deployment.

### Example 2: Start Azs ContainerRegistry Setup when another instance of Setup is already started
```powershell
PS C:\> Start-AzsContainerRegistrySetup -Password $password -SslCertInputFile $pfx_cert_path | ConvertTo-Json

Start-AzsContainerRegistrySetup : Container registry deployment is still running. It is not allowed to repeat deployment at this stage.
At line:1 char:1
+ Start-AzsContainerRegistrySetup -Password $password -SslCertInputFile ...
+ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    + CategoryInfo          : InvalidOperation: ({ SubscriptionI...SetupProperty }:<>f__AnonymousType7`3) [Start-AzsContai...p_StartExpanded], Exception
    + FullyQualifiedErrorId : AcrDeploymentStillRunning,Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistryAdmin.Cmdlets.StartAzsContainerRegistrySetup_StartExpanded
```

Returns the error if another instance of Setup is already started.
