$TestRecordingFile = Join-Path $PSScriptRoot 'Offer.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe "Offers" -Tags @('Subscription', 'Offer') {

    BeforeEach {

        function ValidateOffer {
            param(
                [Parameter(Mandatory = $true)]
                $Offer
            )
            $Offer              | Should Not Be $null
            # Resource
            $Offer.Id           | Should Not Be $null
            $Offer.Name         | Should Not Be $null
            $Offer.DisplayName  | Should Not Be $null
        }

        function AssertOffersAreSame {
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
                $Found                  | Should Not Be $null
                # Resource
                $Found.Id               | Should Be $Expected.Id
                $Found.Name             | Should Be $Expected.Name
                $Found.DisplayName      | Should Be $Expected.DisplayName
            }
        }
    }

    AfterEach {
        $global:Client = $null
    }

    it "TestListRootOffers" -Skip:$('TestListRootOffers' -in $global:SkippedTests) {
        $global:TestName = 'TestListRootOffers'

        $offers = Get-AzsOffer
        $offers | Should Not Be $null
        foreach ($offer in $offers) {
            ValidateOffer -Offer $offer
        }
    }

    it "TestListDelegatedProviderOffers" -Skip:$('TestListDelegatedProviderOffers' -in $global:SkippedTests) {
        $global:TestName = 'TestListDelegatedProviderOffers'

        $offers = Get-AzsDelegatedProviderOffer -DelegatedProviderId 'default'
        $offers | Should Not Be $null
        foreach ($offer in $offers) {
            ValidateOffer -Offer $offer
        }
    }

    it "TestGetDelegatedProviderOffers" -Skip:$('TestGetDelegatedProviderOffers' -in $global:SkippedTests) {
        $global:TestName = 'TestGetDelegatedProviderOffers'

        $offers = Get-AzsDelegatedProviderOffer -DelegatedProviderId 'default'
        $offers | Should Not Be $null
        foreach ($offer in $offers) {
            $retrieved = Get-AzsDelegatedProviderOffer -OfferName $offer.Name -DelegatedProviderId 'default'
            AssertOffersAreSame -Expected $offer -Found $retrieved
            break
        }
    }
}