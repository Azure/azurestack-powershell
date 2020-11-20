# Sample script to execute a set of basic tests using the Admin and User Az modules aganist provided AzureStack Environment.
# The test will fail the Az/Azs modules that require admin privileges if the $ClientObjectId is invalid. 
# These scripts are provided for your convenience:
# Login-Environment.ps1: connects to an AzureStack environment.
# New-AzureStackTestResources.ps1: creates testing resources.

[CmdletBinding()]
param (
    [Parameter(HelpMessage = "The object ID associated with the secret or certificate AzureStack login information. Admin tests will fail if invalid.")]
    [string]
    $ClientObjectId = $ENV:ClientObjectId,
    [Parameter(HelpMessage = "The location of the resources for Azure Stack.")]
    [string]
    $resourceLocation = $ENV:Location
)

$resourceGroup = "azurestack-container-rg"
$globalLogFile = "log-" + (Get-Date).ticks + ".txt"

[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12 

filter timestamp 
{
    "[$((Get-Date).ToUniversalTime().toString("o"))] $_"
}

function Log
{
    Param
    (
        [Parameter(ValueFromPipeline = $true)]
        [String]
        $Message,
        [ValidateSet("INFO", "EXCEPTION")]
        [String]
        $Type = "INFO"
    )

    if ($Type -like "INFO")
    {
        $Message = "[INFO] " + $Message
    }
    elseif ($Type -like "EXCEPTION")
    {
        $Message = "[EXCEPTION] " + $Message
    }

    $Message | timestamp | Tee-Object -FilePath $globalLogFile -Append | Write-Host
}

function Test
{
    Param
    (
        [String] $TestName,
        [ScriptBlock] $TestBlock
    )

    Log -Message "[START]: ${TestName}"
    try
    {
        $TestBlock.Invoke()
    }
    catch
    {
        Log -Message $_ -Type "EXCEPTION"
    }
    Log -Message "[END]: ${TestName}"
}

$TestAzAccounts =
{
    Log -Message "Running Get-AzContext..."
    Get-AzContext | Format-Table -AutoSize | Out-String | Log
}

$TestAzBilling =
{
    $todayDate = Get-Date
    $startDate = $todayDate.AddMonths(-1)
    $startDate = "$($startDate.Month)/$($startDate.Day)/$($startDate.Year)"
    $todayDate = "$($todayDate.Month)/$($todayDate.Day)/$($todayDate.Year)"
    Get-UsageAggregates -ReportedStartTime $startDate `
        -ReportedEndTime $todayDate | Format-Table -AutoSize | Out-String | Log
}

$TestAzCompute =
{
    Log -Message "Running New-AzAvailabilitySet..."
    New-AzAvailabilitySet -ResourceGroupName $resourceGroup -Name "avail-set" -Location "northwest"
    Log -Message "Running Get-AzAvailabilitySet..."
    Get-AzAvailabilitySet -Name "avail-set" -ResourceGroupName $resourceGroup | Format-Table -AutoSize | Out-String | Log
    Log -Message "Running Remove-AzAvailabilitySet..."
    Remove-AzAvailabilitySet -name "avail-set" -ResourceGroupName "azurestack-container-user-rg" -Force
}

$TestAzDns =
{
    $testDNS = "dns-zone.com"
    Log -Message "Running New-AzDnsZone..."
    New-AzDnsZone -Name $testDNS  -ResourceGroupName $resourceGroup
    Log -Message "Running Get-AzDnsZone..."
    Get-AzDnsZone -Name $testDNS  -ResourceGroupName $resourceGroup | Format-Table -AutoSize | Out-String | Log
    Log -Message "Running Remove-AzDnsZone..."
    Remove-AzDnsZone -Name $testDNS  -Force
}

$TestAzKeyVault =
{
    $KeyVaultName = "azurestackContainerKV"
    Log -Message "Creating new key vault... (New-AzKeyVault)"
    New-AzKeyVault -VaultName $KeyVaultName -ResourceGroupName $resourceGroup -Location $resourceLocation -Verbose -ErrorAction Stop
    Get-AzKeyVault -VaultName $KeyVaultName -ErrorAction Stop
    Set-AzKeyVaultAccessPolicy -VaultName $KeyVaultName -ResourceGroupName $resourceGroup -ObjectId $ClientObjectId -BypassObjectIdValidation -PermissionsToKeys all -PermissionsToSecrets all -ErrorAction Stop
    
    Log -Message "Adding vault key... (Add-AzKeyVaultKey)"
    $key = "azurestack-container-key"
    $key = Add-AzKeyVaultKey -VaultName $KeyVaultName -Name $key -Destination Software -ErrorAction Stop
    Get-AzKeyVaultKey -VaultName $KeyVaultName -ErrorAction Stop
    $key.id
    
    Log -Message "Setting secret... (Set-AzKeyVaultSecret)"

    $secretValue = [guid]::NewGuid()
    $secretSecureString = ConvertTo-SecureString $secretValue -AsPlainText -Force
    $secretName = "DummySecret"
    Set-AzKeyVaultSecret -VaultName $KeyVaultName -Name $secretName -SecretValue $secretSecureString -ErrorAction Stop

    $kvsecret = Get-AzKeyVaultSecret -VaultName $KeyVaultName
    $kvsecret.Id
    
    Log -Message "Backing up key... (Backup-AzKeyVaultKey)"
    $keyFile = Backup-AzKeyVaultKey -VaultName $KeyVaultName -Name $key.Name -ErrorAction Stop
    $keyFile
    
    Log -Message "Removing key vault key... (Remove-AzKeyVaultKey)"
    Remove-AzKeyVaultKey -VaultName $KeyVaultName -Name $key.Name -Force -confirm:$false -ErrorAction Stop
    
    Log -Message "Restoring key key vault key... (Restore-AzKeyVaultKey)"
    Restore-AzKeyVaultKey -VaultName $KeyVaultName -InputFile $keyFile -ErrorAction Stop
    
    Log -Message "Updating key vault key attribute... (Set-AzKeyVaultKeyAttribute)"
    $expires = (Get-Date).AddYears(2).ToUniversalTime()
    $Tags = @{'Severity' = 'high'; 'Accounting' = $null}
    Set-AzKeyVaultKeyAttribute -VaultName $KeyVaultName -Name $key.Name -Expires $expires -Enable $True -Tag $Tags -PassThru -ErrorAction Stop
    
    Log -Message "Backing up key vault secret.. (Backup-AzKeyVaultSecret)"
    $secretFile = Backup-AzKeyVaultSecret -VaultName $KeyVaultName -Name $secret -ErrorAction Stop
    $secretFile
    
    Log -Message "Removing key vault secret... (Remove-AzKeyVaultSecret)"
    Remove-AzKeyVaultSecret -VaultName $KeyVaultName -Name $secret -Force -confirm:$false -ErrorAction Stop
    
    Log -Message "Restoring key vault secret... (Restore-AzKeyVaultSecret)"
    Restore-AzKeyVaultSecret -VaultName $KeyVaultName -InputFile $secretFile -ErrorAction Stop
    
    Log -Message "Removing key vault access policy... (Remove-AzKeyVaultAccessPolicy)"
    Remove-AzKeyVaultAccessPolicy -VaultName $KeyVaultName -ObjectId $ClientObjectId -ErrorAction Stop

    Log -Message "Removing key vault ${KeyVaultName}... (Remove-AzKeyVault)"
    Remove-AzKeyVault -ResourceGroupName $resourceGroup -VaultName $KeyVaultName -Confirm:$false -Force
}

$TestAzMonitor =
{
    Log -Message "Running Get-AzAlertHistory..."
    Get-AzAlertHistory -ErrorAction Stop | Format-Table -AutoSize | Out-String | Log
}

$TestAzNetwork =
{
    $networkSecurityGroup = "network-sg"
    Log -Message "Running New-AzNetworkSecurityGroup..."
    New-AzNetworkSecurityGroup -ResourceGroupName $resourceGroup -Name $networkSecurityGroup -Location $resourceLocation
    Log -Message "Running Get-AzNetworkSecurityGroup..."
    Get-AzNetworkSecurityGroup -ResourceGroupName $resourceGroup -Name $networkSecurityGroup | Format-Table -AutoSize | Out-String | Log
    Log -Message "Running Remove-AzNetworkSecurityGroup..."
    Remove-AzNetworkSecurityGroup -ResourceGroupName $resourceGroup -Name $networkSecurityGroup -Confirm:$false -Force 
}

$TestAzResources =
{
    Log -Message "Running Get-AzResourceGroup..."
    Get-AzResourceGroup | Format-Table -AutoSize | Out-String | Log
}

$TestAzWebsites =
{
    $appName = "azcontainer-test-app" + [Random]::new().Next(1,9999)
    Log -Message "Running New-AzAppServicePlan..."
    New-AzAppServicePlan -ResourceGroupName $resourceGroup `
        -Name $appName `
        -Location $resourceLocation `
        -Tier "Free" `
        -NumberofWorkers 1 `
        -WorkerSize "Small" | Format-Table -AutoSize | Out-String | Log
    Log -Message "Running Get-AzAppServicePlan..."
    Get-AzAppServicePlan -ResourceGroupName $resourceGroup -Name $appName
    Log -Message "Running Remove-AzAppServicePlan..."
    Remove-AzAppServicePlan -ResourceGroupName $resourceGroup -Name $appName -Force
}

$TestAzsAzureBridgeAdmin =
{
    Log -Message "Running Get-AzsAzureBridgeActivation..."
    Get-AzsAzureBridgeActivation -ResourceGroupName $resourceGroup | Format-Table -AutoSize | Out-String | Log
}

$TestAzsBackupAdmin =
{
    Log -Message "Running Get-AzsBackup..."
    Get-AzsBackup | Format-Table -AutoSize | Out-String | Log
}

$TestAzsCommerceAdmin =
{
    $todayDate = Get-Date
    $startDate = $todayDate.AddMonths(-1)
    $startDate = "$($startDate.Month)/$($startDate.Day)/$($startDate.Year)"
    $todayDate = "$($todayDate.Month)/$($todayDate.Day)/$($todayDate.Year)"
    Log -Message "Running Get-AzsSubscriberUsage..."
    Log -Message "Using time-span of ${startDate} to ${todayDate}."
    Get-AzsSubscriberUsage -ReportedStartTime $startDate `
        -ReportedEndTime $todayDate | Format-Table -AutoSize | Out-String | Log
}

$TestAzsComputeAdmin =
{
    Log -Message "Running Get-AzsComputeQuota..."
    Get-AzsComputeQuota | Format-Table -AutoSize | Out-String | Log
}

$TestAzsFabricAdmin =
{
    Log -Message "Running Get-AzsInfrastructureLocation..."
    Get-AzsInfrastructureLocation | Format-Table -AutoSize | Out-String | Log
}

$TestAzsInfrastructureInsightsAdmin =
{
    Log -Message "Running Get-AzsAlert..."
    Get-AzsAlert | Format-Table -AutoSize | Out-String | Log
}

$TestAzsGalleryAdmin =
{
    Log -Message "Running Get-AzsGalleryItem..."
    Get-AzsGalleryItem | Format-Table -AutoSize | Out-String | Log
}

$TestAzsKeyVaultAdmin =
{
    Log -Message "Running Get-AzsKeyvaultQuota..."
    Get-AzsKeyvaultQuota | Format-Table -AutoSize | Out-String | Log
}

$TestAzsNetworkAdmin =
{
    Log -Message "Running Get-AzsNetworkQuota..."
    Get-AzsNetworkQuota | Format-Table -AutoSize | Out-String | Log
}

$TestAzsStorageAdmin =
{
    Log -Message "Running Get-AzsStorageQuota..."
    Get-AzsStorageQuota | Format-Table -AutoSize | Out-String | Log
}

$TestAzsSubscription =
{
    Log -Message "Running Get-AzsSubscription..."
    Get-AzsSubscription | Format-Table -AutoSize | Out-String | Log
}

$TestAzsSubscriptionAdmin =
{
    Log -Message "Running Get-AzsUserSubscription..."
    Get-AzsUserSubscription | Format-Table -AutoSize | Out-String | Log
}

$TestAzsUpdateAdmin =
{
    Log -Message "Running Get-AzsUpdate..."
    Get-AzsUpdate | Format-Table -AutoSize | Out-String | Log
}

function Main
{
    Import-Module Az.Accounts
    Import-Module Az.Resources
    Import-Module AzureStack
    $PSVersionTable | Out-String | Log

    Test -TestName "TestAzAccounts" -TestBlock $TestAzAccounts
    Test -TestName "TestAzBilling" -TestBlock $TestAzBilling
    Test -TestName "TestAzCompute" -TestBlock $TestAzCompute
    Test -TestName "TestAzDns" -TestBlock $TestAzDns
    Test -TestName "TestAzKeyVault" -TestBlock $TestAzKeyVault
    Test -TestName "TestAzMonitor" -TestBlock $TestAzMonitor
    Test -TestName "TestAzNetwork" -TestBlock $TestAzNetwork
    Test -TestName "TestAzResources" -TestBlock $TestAzResources
    Test -TestName "TestAzWebsites" -TestBlock $TestAzWebsites
    Test -TestName "TestAzsAzureBridgeAdmin" -TestBlock $TestAzsAzureBridgeAdmin
    Test -TestName "TestAzsBackupAdmin" -TestBlock $TestAzsBackupAdmin
    Test -TestName "TestAzsCommerceAdmin" -TestBlock $TestAzsCommerceAdmin
    Test -TestName "TestAzsComputeAdmin" -TestBlock $TestAzsComputeAdmin
    Test -TestName "TestAzsFabricAdmin" -TestBlock $TestAzsFabricAdmin
    Test -TestName "TestAzsInfrastructureInsightsAdmin" -TestBlock $TestAzsInfrastructureInsightsAdmin
    Test -TestName "TestAzsGalleryAdmin" -TestBlock $TestAzsGalleryAdmin
    Test -TestName "TestAzsKeyVaultAdmin" -TestBlock $TestAzsKeyVaultAdmin
    Test -TestName "TestAzsNetworkAdmin" -TestBlock $TestAzsNetworkAdmin
    Test -TestName "TestAzsStorageAdmin" -TestBlock $TestAzsStorageAdmin
    Test -TestName "TestAzsSubscription" -TestBlock $TestAzsSubscription
    Test -TestName "TestAzsSubscriptionAdmin" -TestBlock $TestAzsSubscriptionAdmin
    Test -TestName "TestAzsUpdateAdmin" -TestBlock $TestAzsUpdateAdmin
}

Main