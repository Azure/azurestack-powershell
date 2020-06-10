. (Join-Path $PSScriptRoot 'loadEnvJson.ps1')

$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsPublicIPAddress.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzsPublicIPAddress' {
    
    . $PSScriptRoot\Common.ps1

    BeforeEach {

    }

    AfterEach {
        $global:Client = $null
    }

    It "TestGetAllPublicIpAddresses" -Skip:$('TestGetAllPublicIpAddresses' -in $global:SkippedTests) {
        $global:TestName = 'TestGetAllPublicIpAddresses'

        $addresses = Get-AzsPublicIPAddress

        # This test should be using the SessionRecord which has an existing PublicIPAddress created
        if ($null -ne $addresses) {
            foreach ($address in $addresses) {
                ValidateBaseResources($address)
                ValidateBaseResourceTenant($address)
            }
        }
    }

    It "TestGetAllPublicIpAddressesOData" -Skip:$('TestGetAllPublicIpAddressesOData' -in $global:SkippedTests) {
        $global:TestName = 'TestGetAllPublicIpAddressesOData'

        [System.Reflection.Assembly]::LoadWithPartialName("Microsoft.Rest.Azure.OData.ODataQuery")
        $oDataQuery = New-Object -TypeName [Microsoft.Rest.Azure.OData.ODataQuery] -ArgumentList PublicIPAddress
        $oDataQuery.Top = 10
        $addresses = Get-AzsPublicIPAddress -Filter $oDataQuery
        # This test should be using the SessionRecord which has an existing PublicIPAddress created
        if ($null -ne $addresses) {
            foreach ($address in $addresses) {
                ValidateBaseResources($address)
                ValidateBaseResourceTenant($address)
            }
        }
    }
}
