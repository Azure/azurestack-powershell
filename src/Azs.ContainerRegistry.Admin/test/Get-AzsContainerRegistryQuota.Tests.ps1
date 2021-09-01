$loadEnvPath = Join-Path $PSScriptRoot 'loadEnvJson.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnvJson.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsContainerRegistryQuota.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzsContainerRegistryQuota' {
    BeforeEach {

        function ValidateContainerRegistryQuota {
            param(
                [Parameter(Mandatory = $true)]
                $containerRegistryQuota
            )
            # Resource
            $containerRegistryQuota								| Should Not Be $null

            # Validate ContainerRegistry quota properties
            $containerRegistryQuota.CapacityPerRegistryInGib	| Should Not Be $null
            $containerRegistryQuota.NumberOfRegistry			| Should Not Be $null
            $containerRegistryQuota.Type	                    | Should Not Be $null
            $containerRegistryQuota.Id							| Should Not Be $null
            $containerRegistryQuota.Name						| Should Not Be $null
        }

        function AssertAreEqual {
            param(
                [Parameter(Mandatory = $true)]
                $expected,
                [Parameter(Mandatory = $true)]
                $found
            )
            # Resource
            if ($null -eq $expected) {
                $found							| Should Be $null
            }
            else {
                $found							| Should Not Be $null
                # Validate ContainerRegistry quota properties
                $expected.CapacityPerRegistryInGib | Should Be $found.CapacityPerRegistryInGib
                $expected.NumberOfRegistry         | Should Be $found.NumberOfRegistry
            }
        }
    }

    AfterEach {
        $global:Client = $null
    }

    It "TestListAllContainerRegistryQuotas" -Skip:$('TestListAllContainerRegistryQuotas' -in $global:SkippedTests) {
        $global:TestName = 'TestListAllContainerRegistryQuotas'

        $quotas = Get-AzsContainerRegistryQuota 
        foreach ($quota in $quotas.Value) {
            ValidateContainerRegistryQuota -containerRegistryQuota $quota
        }
    }

    It "TestGetContainerRegistryQuota" -Skip:$('TestGetContainerRegistryQuota' -in $global:SkippedTests) {
        $global:TestName = 'TestGetContainerRegistryQuota'

        $quota = Get-AzsContainerRegistryQuota 
        if ($quota -as [Array])
        {
            $quota = $quota[0]
        }
        $retrievedQuota = Get-AzsContainerRegistryQuota -InputObject $quota 
        ValidateContainerRegistryQuota -containerRegistryQuota $retrievedQuota
        AssertAreEqual -expected $quota -found $retrievedQuota
    }

    It "TestGetAllContainerRegistryQuotas" -Skip:$('TestGetAllContainerRegistryQuotas' -in $global:SkippedTests) {
        $global:TestName = 'TestGetAllContainerRegistryQuotas'

        $quotas = Get-AzsContainerRegistryQuota 
        foreach ($quota in $quotas -as [Array]) {
            $result = Get-AzsContainerRegistryQuota -InputObject $quota
            ValidateContainerRegistryQuota -containerRegistryQuota $quota
            AssertAreEqual -expected $quota -found $result
        }
    }
}
