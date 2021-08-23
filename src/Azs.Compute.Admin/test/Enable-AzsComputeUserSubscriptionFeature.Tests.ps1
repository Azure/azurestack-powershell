$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Enable-AzsComputeUserSubscriptionFeature.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Enable-AzsComputeUserSubscriptionFeature' {
    It 'TestEnableComputeUserSubscriptionFeature' -Skip:$('TestEnableComputeUserSubscriptionFeature' -in $global:SkippedTests) {
        $global:TestName = 'TestEnableComputeUserSubscriptionFeature'

        $tenantSubscriptionId = $env.TenantSubscriptionId
        $feature = Get-AzsComputeFeature -Name Microsoft.Compute.EmergencyVMAccess -Location $env.Location
        $feature.EnabledTenantSubscriptionId[-1] | Should Not Be $tenantSubscriptionId
        Enable-AzsComputeUserSubscriptionFeature  -TenantSubscriptionId $tenantSubscriptionId -FeatureName Microsoft.Compute.EmergencyVMAccess -Location $env.Location -SubscriptionId $env.SubscriptionId
        $feature = Get-AzsComputeFeature -Name Microsoft.Compute.EmergencyVMAccess -Location $env.Location -SubscriptionId $env.SubscriptionId
        $feature.EnabledTenantSubscriptionId[-1] | Should Be $tenantSubscriptionId
        Disable-AzsComputeUserSubscriptionFeature -TenantSubscriptionId $tenantSubscriptionId -FeatureName Microsoft.Compute.EmergencyVMAccess -Location $env.Location -SubscriptionId $env.SubscriptionId
        $feature = Get-AzsComputeFeature -Name Microsoft.Compute.EmergencyVMAccess -Location $env.Location
        $feature.EnabledTenantSubscriptionId[-1] | Should Not Be $tenantSubscriptionId
    }
}