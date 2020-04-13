$TestRecordingFile = Join-Path $PSScriptRoot 'UserSubscription.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'UserSubscription' {

    . $PSScriptRoot\Common.ps1

    BeforeEach {
        function ValidateSubscription {
            param(
                [Parameter(Mandatory = $true)]
                $Subscription
            )
            $Subscription                | Should Not Be $null
            # Resource
            $Subscription.Id             | Should Not Be $null
            $Subscription.DisplayName    | Should Not Be $null
            $Subscription.OfferId        | Should Not Be $null
            $Subscription.Owner          | Should Not Be $null
            $Subscription.State          | Should Not Be $null
            $Subscription.SubscriptionId | Should Not Be $null
            $Subscription.TenantId       | Should Not Be $null

        }

    }

    AfterEach {
        $global:Client = $null
    }

    it "TestListSubscriptions" -Skip:$('TestListSubscriptions' -in $global:SkippedTests) {
        $global:TestName = 'TestListSubscriptions'
        $Subscriptions = Get-AzsUserSubscription
        $Subscriptions | Should Not Be $null
        foreach ($Subscription in $Subscriptions) {
            ValidateSubscription -Subscription $Subscription
        }
    }

    it "TestSetSubscription" -Skip:$('TestSetSubscription' -in $global:SkippedTests) {
        $global:TestName = "TestSetSubscription"
        $Subscriptions = Get-AzsUserSubscription
        foreach ($sub in $subscriptions) {
            $sub.DisplayName += "-test"
            $sub.Owner = $global:Owner
            $sub | Set-AzsUserSubscription
            $updated = Get-AzsUserSubscription -TargetSubscriptionId $sub.SubscriptionId
            $updated.DisplayName | Should Be $sub.DisplayName
            $updated.Owner       | Should Be $global:Owner
            break;
        }
    }

    it "CheckNameAvailability" -Skip:$('CheckNameAvailability' -in $global:SkippedTests) {
        $global:TestName = 'CheckNameAvailability'
        Test-AzsNameAvailability -Name $global:TestAvailability -ResourceType $global:ResourceType
    }

    it "TestMoveUserSubscription" -Skip:$('TestMoveSubscription' -in $global:SkippedTests) {
        $global:TestName = 'MoveUserSubscription'
        $offer = Get-AzsAdminManagedOffer | Select-Object -First 1
        $subscription = New-AzsUserSubscription -DisplayName $global:SubscriptionName -OfferId $offer.Id -Owner $global:Owner
        $resourceIds = Get-AzsUserSubscription | where Displayname -eq $global:SubscriptionName  | Select -ExpandProperty Id
        Move-AzsUserSubscription -ResourceId $resourceIds
    }

    it "TestTestMoveSubscription" -Skip:$('TestTestMoveSubscription' -in $global:SkippedTests) {
        $global:TestName = 'TestMoveUserSubscription'
        $resourceIds = Get-AzsUserSubscription | where Displayname -eq $global:SubscriptionName | Select-Object -ExpandProperty Id
        Test-AzsMoveUserSubscription -ResourceId $resourceIds
    }

    It 'Get' {
        #{ throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetViaIdentity' {
        #{ throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
