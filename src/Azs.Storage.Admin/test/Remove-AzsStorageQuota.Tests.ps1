. (Join-Path $PSScriptRoot 'loadEnvJson.ps1')

$TestRecordingFile = Join-Path $PSScriptRoot 'Remove-AzsStorageQuota.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Remove-AzsStorageQuota' {

    . $PSScriptRoot\Common.ps1
    
    It "TestDeleteStorageQuota" -Skip:$('TestDeleteStorageQuota' -in $global:SkippedTests) {
        $global:TestName = 'TestDeleteStorageQuota'

        $name = "TestDeleteQuota"
        $quota = New-AzsStorageQuota -CapacityInGb 50 -NumberOfStorageAccounts 100  -Name $name
        $quota      |    Should Not Be $null
        $quota.CapacityInGb | Should Be 50
        $quota.NumberOfStorageAccounts | Should Be 100
        Remove-AzsStorageQuota  -Name $name
        $quota | New-AzsStorageQuota -Name $name
        $retrievedQuota = Get-AzsStorageQuota -Name $name
        Remove-AzsStorageQuota -InputObject $retrievedQuota
    }
}
