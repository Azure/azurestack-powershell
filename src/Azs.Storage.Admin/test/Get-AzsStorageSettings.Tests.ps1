$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsStorageSettings.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzsStorageSettings' {

    . $PSScriptRoot\Common.ps1

    BeforeEach {

        function ValidateSetting {
            param(
                [Parameter(Mandatory = $true)]
                $Setting
            )
            $setting													| Should Not Be $null
            $setting.RetentionPeriodForDeletedStorageAccountsInDays		| Should Not Be $null
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
                $found												     | Should Be $null
            }
            else {
                $found												     | Should Not Be $null
                # Validate Farm properties
                $expected.RetentionPeriodForDeletedStorageAccountsInDays | Should Be $found.RetentionPeriodForDeletedStorageAccountsInDays
            }
        }
    }

    AfterEach {
        $global:Client = $null
    }

    It "TestGetStorageSettings" -Skip:$('TestGetStorageSettings' -in $global:SkippedTests) {
        $global:TestName = 'TestGetStorageSettings'

        $result = Get-AzsStorageSettings -Location $global:Location 
        $result  | Should Not Be $null
        ValidateSetting -Setting $result
    }
}
