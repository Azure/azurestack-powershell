$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-AzsContainerRegistryQuota.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-AzsContainerRegistryQuota' {
    It "TestCreateStorageQuota" -Skip:$('TestCreateContainerRegistryQuota' -in $global:SkippedTests) {
        $global:TestName = 'TestCreateContainerRegistryQuota'

        $name = "TestCreateQuota"
        $quota = New-AzsContainerRegistryQuota  -CapacityPerRegistryInGib 20 -NumberOfRegistry 20  -Name $name
        $quota                          | Should Not Be $null
        $quota.CapacityPerRegistryInGib | Should Be 20
        $quota.NumberOfRegistry         | Should Be 20
        Remove-AzsContainerRegistryQuota  -Name $name
    }
}
