$loadEnvPath = Join-Path $PSScriptRoot 'loadEnvJson.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnvJson.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Remove-AzsContainerRegistryQuota.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Remove-AzsContainerRegistryQuota' {
    It "TestDeleteContainerRegistryQuota" -Skip:$('TestDeleteContainerRegistryQuota' -in $global:SkippedTests) {
        $global:TestName = 'TestDeleteContainerRegistryQuota'

        $name = "TestDeleteQuota"
        $quota = New-AzsContainerRegistryQuota -CapacityPerRegistryInGib 50 -NumberOfRegistries 100  -Name $name
        $quota      |    Should Not Be $null
        $quota.CapacityPerRegistryInGib | Should Be 50
        $quota.NumberOfRegistries       | Should Be 100
        Remove-AzsContainerRegistryQuota  -Name $name
        $quota | New-AzsContainerRegistryQuota -Name $name
        $retrievedQuota = Get-AzsContainerRegistryQuota -Name $name
        Remove-AzsContainerRegistryQuota -InputObject $retrievedQuota
    }
}
