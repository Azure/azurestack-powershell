$global:SkippedTests = @(
)

# Multiple tests
$global:Location = (Get-AzLocation)[0].Location
$global:ResourceGroupName = "system." + "$($global:Location)"

# Acquired plan tests
$global:TargetSubscriptionId = (Get-AzsUserSubscription | where DisplayName -Match 'tenantadmin').DelegatedProviderSubscriptionId[0]
$global:SubscriptionId = (Get-AzContext).Subscription.Id
$global:PlanAcquisitionId = "718c7f7c-4868-479a-98ce-5caaa8f158c8"

# Offer Tests
$global:OfferResourceGroupName = "testrg"
$global:OfferName = "testOffer1"
$rg = Get-AzResourceGroup -Name $global:OfferResourceGroupName -ErrorAction SilentlyContinue
if ($null -eq $rg) { New-AzResourceGroup -Name $global:OfferResourceGroupName -Location $global:Location}

# Plan tests
$global:PlanResourceGroupName = "testrg"
$global:PlanName = "testplans"
$global:PlanDescription = "description of the plan"
$rg = Get-AzResourceGroup -Name $global:PlanResourceGroupName -ErrorAction SilentlyContinue
if ($null -eq $rg) { New-AzResourceGroup -Name $global:PlanResourceGroupNam -Location $global:Location }

# Subscriptions Tests
$global:Owner = 'user@microsoft.com'
$global:SubscriptionName = 'Test Subscription'

# Test Availability
$global:TestAvailability = "Test Sub"
$global:ResourceType = "Microsoft.Subscriptions.Admin/plans"