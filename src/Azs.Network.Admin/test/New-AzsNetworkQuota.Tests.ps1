. (Join-Path $PSScriptRoot 'loadEnvJson.ps1')

$TestRecordingFile = Join-Path $PSScriptRoot 'New-AzsNetworkQuota.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-AzsNetworkQuota' {

    . $PSScriptRoot\Common.ps1

    BeforeEach {
        function AssertQuotaWasCreated {
            param(
                $quota
            )

            $quota.MaxLoadBalancersPerSubscription -eq $global:TestQuotaMaxLoadBalancersPerSubscription | Should Be $true
            $quota.MaxNicsPerSubscription -eq $global:TestQuotaMaxNicsPerSubscription | Should Be $true
            $quota.MaxPublicIpsPerSubscription -eq $global:TestQuotaMaxPublicIpsPerSubscription | Should Be $true
            $quota.MaxSecurityGroupsPerSubscription -eq $global:TestQuotaMaxSecurityGroupsPerSubscription | Should Be $true
            $quota.MaxVirtualNetworkGatewayConnectionsPerSubscription -eq $global:TestQuotaMaxVirtualNetworkGatewayConnectionsPerSubscription | Should Be $true
            $quota.MaxVirtualNetworkGatewaysPerSubscription -eq $global:TestQuotaMaxVirtualNetworkGatewaysPerSubscription | Should Be $true
            $quota.MaxVnetsPerSubscription -eq $global:TestQuotaMaxVnetsPerSubscription | Should Be $true
        }
    }

    AfterEach {
        $global:Client = $null
    }

    It "TestPutNewQuota" -Skip:$('TestPutNewQuota' -in $global:SkippedTests) {
        $global:TestName = 'TestPutNewQuota'
        
        # Remove the quota if it exists
        Remove-AzsNetworkQuota -Name $global:PutNewQuotaName

        # Create a new quota
        $quota = New-AzsNetworkQuota -Name $global:PutNewQuotaName `
                    -MaxPublicIpsPerSubscription $global:TestQuotaMaxPublicIpsPerSubscription `
                    -MaxVnetsPerSubscription $global:TestQuotaMaxVnetsPerSubscription `
                    -MaxVirtualNetworkGatewaysPerSubscription $global:TestQuotaMaxVirtualNetworkGatewaysPerSubscription `
                    -MaxVirtualNetworkGatewayConnectionsPerSubscription $global:TestQuotaMaxVirtualNetworkGatewayConnectionsPerSubscription `
                    -MaxLoadBalancersPerSubscription $global:TestQuotaMaxLoadBalancersPerSubscription `
                    -MaxNicsPerSubscription $global:TestQuotaMaxNicsPerSubscription `
                    -MaxSecurityGroupsPerSubscription $global:TestQuotaMaxSecurityGroupsPerSubscription

        # Validate the quota
        AssertQuotaWasCreated $quota

        # Cleanup
        Remove-AzsNetworkQuota -Name $global:PutNewQuotaName
    }
}

