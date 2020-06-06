. (Join-Path $PSScriptRoot 'loadEnvJson.ps1')

$TestRecordingFile = Join-Path $PSScriptRoot 'Close-AzsAlert.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName


Describe "Alerts" -Tags @('Alert', 'InfrastructureInsightsAdmin') {
    . $PSScriptRoot\Common.ps1

    it "TestCloseAlertFromPipe" -Skip:$('TestCloseAlert' -in $global:SkippedTests) {
            $global:TestName = 'TestCloseAlertFromPipe'
            $Alerts = Get-AzsAlert
            $Alerts | Should Not Be $null
            foreach ($Alert in $Alerts) {
                $Alert | Should not be $null
                $Alert.State | Should not be $null
                if ($Alert.State -eq "Active") {
                    $Alert | Close-AzsAlert -Name $Alert.AlertId -User "foobar"
                    return
                }
            }
        }

    it "TestCloseAlert" -Skip:$('TestCloseAlert' -in $global:SkippedTests) {
            $global:TestName = 'TestCloseAlert'
            $Alerts = Get-AzsAlert
            $Alerts | Should Not Be $null
            foreach ($Alert in $Alerts) {
                $Alert | Should not be $null
                $Alert.State | Should not be $null
                if ($Alert.State -eq "Active") {
                    Close-AzsAlert -Name $Alert.AlertId -User "foobar" -AlertProperty @{"User"="foobar"}
                    return
                }
            }
        }
}