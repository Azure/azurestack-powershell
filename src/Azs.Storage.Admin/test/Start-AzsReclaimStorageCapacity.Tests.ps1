. (Join-Path $PSScriptRoot 'loadEnvJson.ps1')

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

        { Start-AzsReclaimStorageCapacity  -Force } | Should Not Throw
    }
}
