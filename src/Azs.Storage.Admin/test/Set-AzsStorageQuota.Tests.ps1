. (Join-Path $PSScriptRoot 'loadEnvJson.ps1')

$TestRecordingFile = Join-Path $PSScriptRoot 'Set-AzsStorageQuota.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-AzsStorageQuota' {

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
    
    It "TestUpdateStorageQuota" -Skip:$('TestUpdateStorageQuota' -in $global:SkippedTests) {
        $global:TestName = 'TestUpdateStorageQuota'

        $name = "Default Quota"

        $quota = Get-AzsStorageQuota -Name 'Default Quota' 
        
        $quota | Should Not Be $null

        $CapInGB = 123
        $NumStorageAccounts = 10

        $updated = Set-AzsStorageQuota `
            -CapacityInGb $CapInGB `
            -NumberOfStorageAccounts $NumStorageAccounts `
            -Name $name

        ValidateStorageQuota -storageQuota $updated
        $updated.CapacityInGb               | Should Be $CapInGB
        $updated.NumberOfStorageAccounts    | Should Be $NumStorageAccounts

        Set-AzsStorageQuota `
            -CapacityInGb $quota.CapacityInGb `
            -NumberOfStorageAccounts $quota.NumberOfStorageAccounts `
            -Name $name
    }
}
