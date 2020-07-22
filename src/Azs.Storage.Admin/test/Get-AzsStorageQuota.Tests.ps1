. (Join-Path $PSScriptRoot 'loadEnvJson.ps1')

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

        $quotas = Get-AzsStorageQuota 
        foreach ($quota in $quotas.Value) {
            ValidateStorageQuota -storageQuota $quota
        }
    }

    It "TestGetStorageQuota" -Skip:$('TestGetStorageQuota' -in $global:SkippedTests) {
        $global:TestName = 'TestGetStorageQuota'

        $quota = Get-AzsStorageQuota 
        if ($quota.GetType().BaseType.Name -eq "Array")
        {
            $quota = $quota[0]
        }
        $retrievedQuota = Get-AzsStorageQuota -InputObject $quota 
        ValidateStorageQuota -storageQuota $retrievedQuota
        AssertAreEqual -expected $quota -found $retrievedQuota
    }

    It "TestGetAllStorageQuotas" -Skip:$('TestGetAllStorageQuotas' -in $global:SkippedTests) {
        $global:TestName = 'TestGetAllStorageQuotas'

        $quotas = Get-AzsStorageQuota 
        foreach ($quota in $quotas) {
            $result = Get-AzsStorageQuota  -Name $quota.Name
            ValidateStorageQuota -storageQuota $quota
            AssertAreEqual -expected $quota -found $result
        }
    }
}
