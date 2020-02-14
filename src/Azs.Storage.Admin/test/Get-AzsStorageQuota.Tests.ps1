$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsStorageQuota.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzsStorageQuota' {

    . $PSScriptRoot\Common.ps1

    BeforeEach {

        function ValidateStorageQuota {
            param(
                [Parameter(Mandatory = $true)]
                $storageQuota
            )
            # Resource
            $storageQuota								| Should Not Be $null

            # Validate Storage quota properties
            $storageQuota.CapacityInGb				| Should Not Be $null
            $storageQuota.NumberOfStorageAccounts					| Should Not Be $null
            $storageQuota.Type	| Should Not Be $null
            $storageQuota.Id							| Should Not Be $null
            $storageQuota.Location					| Should Not Be $null
            $storageQuota.Name						| Should Not Be $null
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
                # Validate Storage quota properties
                $expected.CapacityInGb | Should Be $found.CapacityInGb
                $expected.NumberOfStorageAccounts | Should Be $found.NumberOfStorageAccounts
            }
        }
    }

    AfterEach {
        $global:Client = $null
    }

    It "TestListAllStorageQuotas" -Skip:$('TestListAllStorageQuotas' -in $global:SkippedTests) {
        $global:TestName = 'TestListAllStorageQuotas'

        $quotas = Get-AzsStorageQuota -Location $global:Location
        foreach ($quota in $quotas.Value) {
            ValidateStorageQuota -storageQuota $quota
        }
    }

    It "TestGetStorageQuota" -Skip:$('TestGetStorageQuota' -in $global:SkippedTests) {
        $global:TestName = 'TestGetStorageQuota'

        $quotas = Get-AzsStorageQuota -Location $global:Location
        $quota = $quotas[0] | Get-AzsStorageQuota
        ValidateStorageQuota -storageQuota $quota
        AssertAreEqual -expected $quotas[0] -found $quota
    }

    It "TestGetAllStorageQuotas" -Skip:$('TestGetAllStorageQuotas' -in $global:SkippedTests) {
        $global:TestName = 'TestGetAllStorageQuotas'

        $quotas = Get-AzsStorageQuota -Location $global:Location
        foreach ($quota in $quotas) {
            $result = Get-AzsStorageQuota -Location $global:Location -Name $quota.Name
            ValidateStorageQuota -storageQuota $quota
            AssertAreEqual -expected $quota -found $result
        }
    }
}
