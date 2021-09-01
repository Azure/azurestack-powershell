$loadEnvPath = Join-Path $PSScriptRoot 'loadEnvJson.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnvJson.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-AzsContainerRegistryQuota.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-AzsContainerRegistryQuota' {
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
            $containerRegistryQuota.NumberOfRegistry	        | Should Not Be $null
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
                $found												    | Should Be $null
            }
            else {
                $found												    | Should Not Be $null
                # Validate ContainerRegistry quota properties
                $expected.CapacityPerRegistryInGib | Should Be $found.CapacityPerRegistryInGib
                $expected.NumberOfRegistry         | Should Be $found.NumberOfRegistry
            }
        }
    }

    AfterEach {
        $global:Client = $null
    }
    
    It "TestUpdateContainerRegistryQuota" -Skip:$('TestUpdateContainerRegistryQuota' -in $global:SkippedTests) {
        $global:TestName = 'TestUpdateContainerRegistryQuota'

        $name = "Default Quota"

        $quota = Get-AzsContainerRegistryQuota -Name 'Default Quota' 
        
        $quota | Should Not Be $null

        $CapInGiB = 100
        $NumOfRegistry = 10

        $updated = Set-AzsContainerRegistryQuota `
            -CapacityPerRegistryInGib $CapInGiB `
            -NumberOfRegistry $NumOfRegistry `
            -Name $name

        ValidateContainerRegistryQuota -containerRegistryQuota $updated
        $updated.CapacityPerRegistryInGib  | Should Be $CapInGiB
        $updated.NumberOfRegistry          | Should Be $NumOfRegistry

        Set-AzsContainerRegistryQuota `
            -CapacityPerRegistryInGib $quota.CapacityPerRegistryInGib `
            -NumberOfRegistry $quota.NumberOfRegistry `
            -Name $name
    }
}
