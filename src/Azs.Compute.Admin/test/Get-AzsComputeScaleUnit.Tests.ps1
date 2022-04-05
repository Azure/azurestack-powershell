$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)

$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsComputeScaleUnit.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName



Describe 'Get-AzsComputeScaleUnit' {
    It 'GetComputeScaleUnitTest' -Skip:$('TestListDiskMigrationJobs' -in $global:SkippedTests) {
        $global:TestName = 'GetComputeScaleUnitTest'

        $scaleUnitView = Get-AzsComputeScaleUnit -Name s-cluster -Location $env.Location -SubscriptionId $env.SubscriptionId

        $scaleUnitView | Should Not Be $null
        $scaleUnitView.Id | Should Not Be $null
        $scaleUnitView.LastUpdatedTime | Should Not Be $null
        $scaleUnitView.Nodes | Should Not Be $null
        $scaleUnitView.ScaleUnitName | Should Be s-cluster
        $scaleUnitView.Type | Should Not Be $null

        foreach ($node in $scaleUnitView.Nodes){
            $node.LastUpdatedTime | Should Not Be $null
            $node.NodeHealthState | Should Not Be $null
            $node.NodeName | Should Not Be $null
            foreach ($vm in $node.VirtualMachine){
                $vm.ResourceGroupName | Should Not Be $null
                $vm.SubscriptionId | Should Not Be $null
                $vm.TimeOfLastConfigurationChange | Should Not Be $null
                $vm.VMId | Should Not Be $null
                $vm.VMSize | Should Not Be $null
            }            
        }
    }
}
