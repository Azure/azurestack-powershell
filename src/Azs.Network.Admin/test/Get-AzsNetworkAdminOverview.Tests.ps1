$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsNetworkAdminOverview.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzsNetworkAdminOverview' {

    BeforeEach {
        function AssertAdminOverviewResourceHealth {
            param(
                [Parameter(Mandatory = $true)]
                $Health,
                [Parameter(Mandatory = $true)]
                $Resource
            )

            $Health.($Resource + "ErrorResourceCount") | Should Not Be $null
            $Health.($Resource + "UnknownCount") | Should Not Be $null
            $Health.($Resource + "HealthyResourceCount") | Should Not Be $null
        }

        function AssertAdminOverviewResourceUsage {
            param(
                [Parameter(Mandatory = $true)]
                $Usage,
                [Parameter(Mandatory = $true)]
                $Resource
            )
        
            $Usage.($Resource + "InUseResourceCount") | Should Not Be $null
            $Usage.($Resource + "TotalResourceCount") | Should Not Be $null
        }
    }

    AfterEach {
        $global:Client = $null
    }

    It "TestGetAdminOverview" -Skip:$('TestGetAdminOverview' -in $global:SkippedTests) {
        $global:TestName = 'TestGetAdminOverview'

        $Overview = Get-AzsNetworkAdminOverview
        $Overview | Should Not Be $null

        AssertAdminOverviewResourceHealth $Overview "LoadBalancerMuxHealth"
        AssertAdminOverviewResourceHealth $Overview "VirtualNetworkHealth"
        AssertAdminOverviewResourceHealth $Overview "VirtualGatewayHealth"

        AssertAdminOverviewResourceUsage $Overview "MacAddressUsage"
        AssertAdminOverviewResourceUsage $Overview "PublicIpAddressUsage"
        AssertAdminOverviewResourceUsage $Overview "BackendIpUsage"
    }
}
