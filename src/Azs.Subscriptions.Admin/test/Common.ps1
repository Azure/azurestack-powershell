$global:SkippedTests = @(
)

# Multiple tests
if ($TestMode -eq 'playback') {
    $global:Location = "redmond"
    # Acquired plan test
    $global:TargetSubscriptionId = '5816b1a6-ee2e-4590-8dff-a6a1e0de9ef6'
    $global:SubscriptionId = '5816b1a6-ee2e-4590-8dff-a6a1e0de9ef6'
} else {
    $global:Location = (Get-AzLocation)[0].Location
    # Acquired plan test
    $global:TargetSubscriptionId = (Get-AzsUserSubscription | where DisplayName -Match 'tenantadmin').DelegatedProviderSubscriptionId[0]
    $global:SubscriptionId = (Get-AzContext).Subscription.Id
}
$global:ResourceGroupName = "system." + "$($global:Location)"

# Acquired plan test
$global:PlanAcquisitionId = "718c7f7c-4868-479a-98ce-5caaa8f158c8"

# Offer Tests
$global:OfferResourceGroupName = "testrg"
$global:OfferName = "testOffer"

# Plan tests
$global:PlanResourceGroupName = "testrg"
$global:PlanName = "testplans"
$global:PlanDescription = "description of the plan"

# Subscriptions Tests
$global:Owner = 'user@microsoft.com'
$global:SubscriptionName = 'Test Subscription'
$global:NewUserSubscriptionId = 'eb377774-8d90-4f4b-bc76-0211g8bfbf86'

# Test Availability
$global:TestAvailability = "Test Sub"
$global:ResourceType = "Microsoft.Subscriptions.Admin/plans"

if ($TestMode -ne 'playback') {
    $rg = Get-AzResourceGroup -Name $global:OfferResourceGroupName -ErrorAction SilentlyContinue
    if ($null -eq $rg) { New-AzResourceGroup -Name $global:OfferResourceGroupName -Location $global:Location }
    $rg = Get-AzResourceGroup -Name $global:PlanResourceGroupName -ErrorAction SilentlyContinue
    if ($null -eq $rg) { New-AzResourceGroup -Name $global:PlanResourceGroupNam -Location $global:Location }
}