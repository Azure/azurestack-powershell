$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsSubscriberUsage.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName




Describe 'Get-AzsSubscriberUsage' {

    . $PSScriptRoot\Common.ps1

    AfterEach {
        $global:Client = $null
    }

    It 'TestGetAzsSubscriberUsage' -Skip:$('TestGetAzsSubscriberUsage' -in $Global:SkippedTests) {
        $Global:TestName  = 'TestGetAzsSubscriberUsage'
        $usageRecords = Get-AzsSubscriberUsage `
                            -ReportedStartTime $global:ReportedStartTime `
                            -ReportedEndTime $global:ReportedEndTime `
                            -AggregationGranularity $global:AggregationGranularity
        
        ValidateAzsSubscriberUsage $usageRecords
    }
}
