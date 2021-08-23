$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Remove-AzsContainerRegistryConfiguration.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Remove-AzsContainerRegistryConfiguration' {
    It "TestRemoveContainerRegistryConfiguration" -Skip:$('TestRemoveContainerRegistryConfiguration' -in $global:SkippedTests) {
        $global:TestName = 'TestRemoveContainerRegistryConfiguration'

        $maxCapacityInGib = (Get-AzsContainerRegistryConfiguration ).MaximumCapacityInGib
        $targetCapacityInGib = 0
        Remove-AzsContainerRegistryConfiguration -ConfigurationName default
        $result = Get-AzsContainerRegistryConfiguration
        $result                      | Should Not Be $null
        $result.MaximumCapacityInGib | Should Be $targetCapacityInGib
        Set-AzsContainerRegistryConfiguration  -MaximumCapacityInGib $maxCapacityInGib -ConfigurationName default
    }
}
