## EXAMPLES

### -------------------------- EXAMPLE 1 --------------------------
```powershell
Get-AzsAzureBridgeDownloadedProduct -ActivationName 'myActivation' -ResourceGroupName 'activationRG'
```

Get a list of Azure Bridge Downloaded products

### -------------------------- EXAMPLE 2 --------------------------
```powershell
Get-AzsAzureBridgeDownloadedProduct -Name 'microsoft.docker-arm.1.1.0' -ActivationName 'myActivation' -ResourceGroupName 'activationRG'
```

Get an Azure Bridge Downloaded Product by Name