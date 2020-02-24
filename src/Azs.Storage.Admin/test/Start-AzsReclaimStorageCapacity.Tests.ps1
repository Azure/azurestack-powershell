$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Start-AzsReclaimStorageCapacity.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Start-AzsReclaimStorageCapacity' {

    . $PSScriptRoot\Common.ps1
    
    It "TestStartGarbageCollection" -Skip:$('TestStartGarbageCollection' -in $global:SkippedTests) {
        $global:TestName = 'TestStartGarbageCollection'

        { Start-AzsReclaimStorageCapacity -Location $global:Location -Force } | Should Not Throw
    }
}
