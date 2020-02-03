$TestRecordingFile = Join-Path $PSScriptRoot 'Offers.Recording.json'
$currentPath = $PSScriptRoot

Describe "Subscriptions" -Tags @('Subscriptions', 'Offers') {

    BeforeEach {

        function ValidateSubscription {
            param(
                [Parameter(Mandatory = $true)]
                $subscription
            )

            $subscription          | Should Not Be $null
            # Resource
            $subscription.Id       | Should Not Be $null
            # Subscription
            $subscription.DisplayName	    | Should Not Be $null
            $subscription.SubscriptionId	| Should Not Be $null
            $subscription.TenantId			| Should Not Be $null
            $subscription.State             | Should Not Be $null
            $subscription.OfferId           | Should Not Be $null
        }

        function AssertSubscriptionsAreSame {
            param(
                [Parameter(Mandatory = $true)]
                $Expected,
                [Parameter(Mandatory = $true)]
                $Found
            )
            if ($Expected -eq $null) {
                $Found | Should Be $null
            }
            else {
                $Found          | Should Not Be $null
                # Resource
                $Found.Id       | Should Be $Expected.Id
                # Subscription
                $Found.DisplayName	    | Should Not Be $null
                $Found.SubscriptionId	| Should Not Be $null
                $Found.TenantId			| Should Not Be $null
                $Found.State            | Should Not Be $null
                $Found.OfferId          | Should Not Be $null
            }
        }
    }

    AfterEach {
        $global:Client = $null
    }


    it "TestListSubscriptions" -Skip:$('TestListSubscriptions' -in $global:SkippedTests) {
        $global:TestName = 'TestListSubscriptions'
        $subscriptions = Get-AzsSubscription
        $subscriptions | Should Not Be $null
        foreach ($subscription in $subscriptions) {
            ValidateSubscription -Subscription $subscription
        }
    }

    it "TestGetSubscription" -Skip:$('TestGetSubscription' -in $global:SkippedTests) {
        $global:TestName = 'TestGetSubscription'
        $subscriptions = Get-AzsSubscription
        $subscriptions | Should Not Be $null
        foreach ($subscription in $subscriptions) {
            $retrieved = Get-AzsSubscription -SubscriptionId $subscription.SubscriptionId
            AssertSubscriptionsAreSame -Expected $subscription -Found $retrieved
            break
        }
    }
}