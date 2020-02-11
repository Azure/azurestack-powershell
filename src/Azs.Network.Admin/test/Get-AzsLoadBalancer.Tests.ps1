$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsLoadBalancer.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzsLoadBalancer' {
    
    . $PSScriptRoot\Common.ps1

    BeforeEach {

    }

    AfterEach {
        $global:Client = $null
    }

    It "TestGetAllLoadBalancers" -Skip:$('TestGetAllLoadBalancers' -in $global:SkippedTests) {
        $global:TestName = 'TestGetAllLoadBalancers'

        $Balancers = Get-AzsLoadBalancer
        # This test should be using the SessionRecord which has an existing LoadBalancer created
        if ($null -ne $Balancers) {
            foreach ($Balancer in $Balancers) {
                ValidateBaseResources($Balancer)
                ValidateBaseResourceTenant($Balancer)
                foreach ($IpAddress in $Balancer.PublicIpAddress) {
                    $IpAddress | Should Not Be $null
                }
            }
        }
    }
}
