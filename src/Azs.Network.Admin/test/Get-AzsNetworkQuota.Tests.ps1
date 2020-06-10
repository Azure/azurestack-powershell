. (Join-Path $PSScriptRoot 'loadEnvJson.ps1')

$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsNetworkQuota.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzsNetworkQuota' {
    
    . $PSScriptRoot\Common.ps1

     BeforeEach {
        function CheckBaseResourcesAreSame {
            param(
                $expected,
                $found
            )

            $expected.Id -eq $found.Id | Should Be $true
            $expected.Location -eq $found.Location | Should Be $true
            $expected.Name -eq $found.Name | Should Be $true
            $expected.Type -eq $found.Type | Should Be $true
        }

        function CreateTestQuota {
            param(
                $Name
            )
            return New-AzsNetworkQuota -MaxPublicIpsPerSubscription $global:TestQuotaMaxPublicIpsPerSubscription `
                -MaxVnetsPerSubscription $global:TestQuotaMaxVnetsPerSubscription `
                -MaxVirtualNetworkGatewaysPerSubscription $global:TestQuotaMaxVirtualNetworkGatewaysPerSubscription `
                -MaxVirtualNetworkGatewayConnectionsPerSubscription $global:TestQuotaMaxVirtualNetworkGatewayConnectionsPerSubscription `
                -MaxLoadBalancersPerSubscription $global:TestQuotaMaxLoadBalancersPerSubscription `
                -MaxNicsPerSubscription $global:TestQuotaMaxNicsPerSubscription `
                -MaxSecurityGroupsPerSubscription $global:TestQuotaMaxSecurityGroupsPerSubscription `
                -Name $Name
        }

        function AssertQuotasAreSame {
            param(
                $expected,
                $found
            )

            if ($null -eq $expected) {
                $found | Should Be $null
            }
            else {
                CheckBaseResourcesAreSame -expected $expected -found $found

                $expected.MaxLoadBalancersPerSubscription -eq $found.MaxLoadBalancersPerSubscription | Should Be $true
                $expected.MaxNicsPerSubscription -eq $found.MaxNicsPerSubscription | Should Be $true
                $expected.MaxPublicIpsPerSubscription -eq $found.MaxPublicIpsPerSubscription | Should Be $true
                $expected.MaxSecurityGroupsPerSubscription -eq $found.MaxSecurityGroupsPerSubscription | Should Be $true
                $expected.MaxVirtualNetworkGatewayConnectionsPerSubscription -eq $found.MaxVirtualNetworkGatewayConnectionsPerSubscription | Should Be $true
                $expected.MaxVirtualNetworkGatewaysPerSubscription -eq $found.MaxVirtualNetworkGatewaysPerSubscription | Should Be $true
                $expected.MaxVnetsPerSubscription -eq $found.MaxVnetsPerSubscription | Should Be $true
                $expected.MigrationPhase -eq $found.MigrationPhase | Should Be $true
            }
        }
    }

    AfterEach {
        $global:Client = $null
    }

    # Record new tests
    It "TestPutAndDeleteQuota" -Skip:$('TestPutAndDeleteQuota' -in $global:SkippedTests) {
        $global:TestName = 'TestPutAndDeleteQuota'

        $created = New-AzsNetworkQuota -Name $global:PutAndDeleteQuotaName
        $quota = Get-AzsNetworkQuota -Name $global:PutAndDeleteQuotaName

        $quota   | Should Not be $null
        $created | Should Not be $null

        $quota.Id | Should Not be $null
        $quota.Id | Should Not be $null

        AssertQuotasAreSame -expected $quota -found $created

        # Delete Quota
        Remove-AzsNetworkQuota -Name $global:PutAndDeleteQuotaName
    }

    It "TestPutAndDeleteQuotaWithParams" -Skip:$('TestPutAndDeleteQuotaWithParams' -in $global:SkippedTests) {
        $global:TestName = 'TestPutAndDeleteQuotaWithParams'

        $created = CreateTestQuota -Name $global:PutAndDeleteQuotaWithParamsName
        $quota = Get-AzsNetworkQuota -Name $global:PutAndDeleteQuotaWithParamsName

        $quota   | Should Not be $null
        $created | Should Not be $null

        $quota.Id | Should Not be $null
        $quota.Id | Should Not be $null

        AssertQuotasAreSame -expected $quota -found $created

        # Delete Quota
        Remove-AzsNetworkQuota -Name $global:PutAndDeleteQuotaWithParamsName
    }

    # Record again
    It "TestPutAndUpdateQuota" -Skip:$('TestPutAndUpdateQuota' -in $global:SkippedTests) {
        $global:TestName = 'TestPutAndUpdateQuota'

        $quota = New-AzsNetworkQuota -Name $global:CreateAndUpdateQuotaName

        $created = Get-AzsNetworkQuota -Name $global:CreateAndUpdateQuotaName

        $quota   | Should Not be $null
        $created | Should Not be $null

        AssertQuotasAreSame -expected $quota -found $created
        
        $created.MaxNicsPerSubscription = $global:MaxNicsPerSubscription
        $created | Set-AzsNetworkQuota

        $getUpdatedQuota = Get-AzsNetworkQuota -Name $global:CreateAndUpdateQuotaName

        AssertQuotasAreSame -expected $created -found $getUpdatedQuota

        # Delete Quota
        Remove-AzsNetworkQuota -Name $global:CreateAndUpdateQuotaName
    }
}
