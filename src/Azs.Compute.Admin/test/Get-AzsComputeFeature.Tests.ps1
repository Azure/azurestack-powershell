$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)

$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsComputeFeature.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzsComputeFeature' {
    It 'TestGetComputeFeature' -Skip:$('TestGetComputeFeature' -in $global:SkippedTests) {
        $global:TestName = 'TestGetComputeFeature'

        $feature = Get-AzsComputeFeature -Name Microsoft.Compute.EmergencyVMAccess -Location $env.Location -SubscriptionId $env.SubscriptionId

        $feature | Should Not Be $null
        $feature.Id | Should Not Be $null
        $feature.Name | Should Be Microsoft.Compute.EmergencyVMAccess
        $feature.Type | Should Be Microsoft.Compute.Admin/locations/features
        $feature.Location | Should Be $env.Location
        $feature.EnabledTenantSubscriptionId | Should Not Be $null
        $feature.GlobalFeatureSettingGlobalFeatureState | Should Not Be $null
    }
}
