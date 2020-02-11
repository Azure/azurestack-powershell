$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsVirtualNetwork.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzsVirtualNetwork' {
        
    . $PSScriptRoot\Common.ps1

    BeforeEach {

        function ValidateConfigurationState {
            param(
                $state
            )

            $state | Should Not Be $null
            $state.ConfigurationStateStatus | Should Not Be $null
            $state.ConfigurationStateLastUpdatedTime | Should Not Be $null
            $state.ProvisioningState | Should Not Be $null
        }
    }

    AfterEach {
        $global:Client = $null
    }

    It "TestGetAllVirtualNetworks" -Skip:$('TestGetAllVirtualNetworks' -in $global:SkippedTests) {
        $global:TestName = "TestGetAllVirtualNetworks"

        $networks = Get-AzsVirtualNetwork
        foreach ($network in $networks) {
            ValidateBaseResources $network
            ValidateBaseResourceTenant $network
            ValidateConfigurationState $network
        }
    }

    # Uncomment this test once ODATA assembly has been added
    It "TestGetAllVirtualNetworksOData" -Skip:$("TestGetAllVirtualNetworksOData" -in $global:SkippedTests) {
        $global:TestName = "TestGetAllVirtualNetworksOData"

        [System.Reflection.Assembly]::LoadWithPartialName("Microsoft.Rest.Azure.OData.ODataQuery")
        $oDataQuery = New-Object -TypeName [Microsoft.Rest.Azure.OData.ODataQuery] -ArgumentList VirtualNetwork
        $oDataQuery.Top = 10
        $networks = Get-AzsVirtualNetwork -Filter $oDataQuery
        foreach ($network in $networks) {
            ValidateBaseResources $network
            ValidateBaseResourceTenant $network
            ValidateConfigurationState $network
        }
    }
}
