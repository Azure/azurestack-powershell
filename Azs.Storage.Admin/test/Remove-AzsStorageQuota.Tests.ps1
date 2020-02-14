$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
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
        Remove-AzsStorageQuota -Location $global:Location -Name $name -Force
        $quota = New-AzsStorageQuota -CapacityInGb 50 -NumberOfStorageAccounts 100 -Location $global:Location -Name $name
        $quota      |    Should Not Be $null
        $quota.CapacityInGb | Should Be 50
        $quota.NumberOfStorageAccounts | Should Be 100
        Get-AzsStorageQuota -Location $global:Location -Name $name | Remove-AzsStorageQuota -Force
        Get-AzsStorageQuota -Location $global:Location -Name $name | Should Be $null
    }
}
