. (Join-Path $PSScriptRoot 'loadEnvJson.ps1')

$TestRecordingFile = Join-Path $PSScriptRoot 'New-AzsStorageQuota.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-AzsStorageQuota' {

    . $PSScriptRoot\Common.ps1
    
    It "TestCreateStorageQuota" -Skip:$('TestCreateStorageQuota' -in $global:SkippedTests) {
        $global:TestName = 'TestCreateStorageQuota'

        $name = "TestCreateQuota"
        $quota = New-AzsStorageQuota -CapacityInGb 100000000 -NumberOfStorageAccounts 1000000000  -Name $name
        $quota                          | Should Not Be $null
        $quota.CapacityInGb             | Should Be 100000000
        $quota.NumberOfStorageAccounts  | Should Be 1000000000
        Remove-AzsStorageQuota  -Name $name
    }
}
