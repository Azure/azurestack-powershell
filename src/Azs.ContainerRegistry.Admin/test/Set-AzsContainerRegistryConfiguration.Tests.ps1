$loadEnvPath = Join-Path $PSScriptRoot 'loadEnvJson.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnvJson.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-AzsContainerRegistryConfiguration.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-AzsContainerRegistryConfiguration' {
    It "TestUpdateContainerRegistryConfiguration" -Skip:$('TestUpdateContainerRegistryConfiguration' -in $global:SkippedTests) {
        $global:TestName = 'TestUpdateContainerRegistryConfiguration'

        $maxCapacityInGib = (Get-AzsContainerRegistryConfiguration ).MaximumCapacityInGib
        $targetCapacityInGib = $originalDays + 1
        $result = Set-AzsContainerRegistryConfiguration  -MaximumCapacityInGib $targetCapacityInGib -Name default
        $result                      | Should Not Be $null
        $result.MaximumCapacityInGib | Should Be $targetCapacityInGib
        Set-AzsContainerRegistryConfiguration  -MaximumCapacityInGib $maxCapacityInGib -Name default
    }
}
