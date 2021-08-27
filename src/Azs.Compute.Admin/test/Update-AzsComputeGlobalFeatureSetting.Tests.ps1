$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Update-AzsComputeGlobalFeatureSetting.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Update-AzsComputeGlobalFeatureSetting' {
    It 'TestUpdateComputeGlobalFeatureSetting' -Skip:$('TestUpdateComputeGlobalFeatureSetting' -in $global:SkippedTests) {
        $global:TestName = 'TestUpdateComputeGlobalFeatureSetting'

        $feature = Get-AzsComputeFeature -Name Microsoft.Compute.EmergencyVMAccess -Location $env.Location -SubscriptionId $env.SubscriptionId
        $originalSetting = $feature.GlobalFeatureSettingGlobalFeatureState

        Update-AzsComputeGlobalFeatureSetting  -FeatureName Microsoft.Compute.EmergencyVMAccess -GlobalFeatureState Disabled -Location $env.Location -SubscriptionId $env.SubscriptionId
        $feature = Get-AzsComputeFeature -Name Microsoft.Compute.EmergencyVMAccess -Location $env.Location -SubscriptionId $env.SubscriptionId
        $feature.GlobalFeatureSettingGlobalFeatureState | Should Be Disabled

        Update-AzsComputeGlobalFeatureSetting   -FeatureName Microsoft.Compute.EmergencyVMAccess -GlobalFeatureState Enabled -Location $env.Location -SubscriptionId $env.SubscriptionId
        $feature = Get-AzsComputeFeature -Name Microsoft.Compute.EmergencyVMAccess -Location $env.Location -SubscriptionId $env.SubscriptionId
        $feature.GlobalFeatureSettingGlobalFeatureState | Should Be Enabled

        Update-AzsComputeGlobalFeatureSetting   -FeatureName Microsoft.Compute.EmergencyVMAccess -GlobalFeatureState TenantSubscriptionLevel -Location $env.Location -SubscriptionId $env.SubscriptionId
        $feature = Get-AzsComputeFeature -Name Microsoft.Compute.EmergencyVMAccess -Location $env.Location -SubscriptionId $env.SubscriptionId
        $feature.GlobalFeatureSettingGlobalFeatureState | Should Be TenantSubscriptionLevel

        Update-AzsComputeGlobalFeatureSetting   -FeatureName Microsoft.Compute.EmergencyVMAccess -GlobalFeatureState $originalSetting -Location $env.Location -SubscriptionId $env.SubscriptionId
    }
}