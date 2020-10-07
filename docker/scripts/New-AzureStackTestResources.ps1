# Run Login-Environment.ps1 before running this script.
# This script is to set up required testing resources for running Test-AzureStack.ps1 script.
# The user is free to create their own resources based on this script as well.

[CmdletBinding()]
param (
    [string]
    $Location = $ENV:Location
)

$ErrorActionPreference = "Stop"
$resourceGroup = "azurestack-container-rg"
$offer = "azurestack-container-offer"
$plan = "azurestack-container-plan"

function New-Quotas
{
    $serviceQuotas  = @()

    $quotaName = "azstorquota"
    $storageQuota = New-AzsStorageQuota -Name $quotaName
    $serviceQuotas += $storageQuota.Id

    $quotaName = "azcompquota"
    $computeQuota = New-AzsComputeQuota -Name $quotaName `
        -PremiumManagedDiskAndSnapshotSize 1000 `
        -StandardManagedDiskAndSnapshotSize 1000
    $serviceQuotas += $computeQuota.Id

    $quotaName = "aznetwquota"
    $networkQuota = New-AzsNetworkQuota -Name $quotaName
    $serviceQuotas += $networkQuota.Id

    $keyvaultQuota = Get-AzsKeyVaultQuota -Location $Location
    $serviceQuotas += $keyvaultQuota.Id

    $serviceQuotas
}

function Set-Offer
{
    try
    {
        $getResourceGroup = Get-AzResourceGroup -Name $resourceGroup
    }
    catch [System.Exception]
    {
        if($error[0].ToString() -match "Provided resource group does not exist.")
        {
            Write-Host "The resource group ${resourceGroup} does not exist, the script will create it..."
        }
    }

    if ($null -eq $getResourceGroup)
    {
        New-AzResourceGroup -Name $resourceGroup -Location $Location
    }

    $getPlan = Get-AzsPlan -ResourceGroupName $resourceGroup -Name $plan
    if ($null -eq $getPlan)
    {
        $serviceQuotas = New-Quotas
        $getPlan = New-AzsPlan -Name $plan `
            -DisplayName $plan `
            -Location $Location `
            -ResourceGroupName $resourceGroup `
            -QuotaIds $serviceQuotas
    }
    $getPlan | Out-String
    
    $getOffer = Get-AzsAdminManagedOffer -ResourceGroupName $resourceGroup -Name $offer
    if ($null -eq $getOffer)
    {
        $getOffer = New-AzsOffer -Name $offer `
            -DisplayName $offer `
            -BasePlanIds @($getPlan.Id) `
            -Location $Location `
            -ResourceGroupName $resourceGroup
    }
    $getOffer = Get-AzsAdminManagedOffer -ResourceGroupName $resourceGroup -Name $offer 
    $getOffer.state = "Public"
    $getOffer | Set-AzsOffer | Out-String
}

function Register-Services
{
    Write-Verbose "Registering resource providers..."
    ("Microsoft.Storage", "Microsoft.Compute", "Microsoft.Network", "Microsoft.KeyVault") | ForEach-Object {Get-AzResourceProvider -ProviderNamespace $_} | Register-AzResourceProvider | Out-Null
    $sleepTime = 0
    while ($true) {
        $sleepTime += 10
        Start-Sleep -Seconds  10
        $requiredRPs = Get-AzResourceProvider -ListAvailable | Where-Object {$_.ProviderNamespace -in ("Microsoft.Storage", "Microsoft.Compute", "Microsoft.Network", "Microsoft.KeyVault")}
        $notRegistered = $requiredRPs | Where-Object {$_.RegistrationState -ne "Registered"}
        $registered = $requiredRPs | Where-Object {$_.RegistrationState -eq "Registered"}
        if (($sleepTime -ge 120) -and $notRegistered) {
            Get-AzResourceProvider | Format-Table
            LogInfo("Exception: Resource providers did not get registered in time")
            throw [System.Exception] "Resource providers did not get registered in time."
        }
        elseif ($registered.Count -eq $requiredRPs.Count) {
            break
        }
    }
    Get-AzResourceProvider | Format-Table -AutoSize
}

function Main
{
    Set-Offer
    Register-Services
}

Main