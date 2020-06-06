. (Join-Path $PSScriptRoot 'loadEnvJson.ps1')

$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsAlert.Recording.json'
$currentPath = $PSScriptRoot

while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe "Alerts" -Tags @('Alert', 'InfrastructureInsightsAdmin') {

    . $PSScriptRoot\Common.ps1

    it "TestListAlerts" -Skip:$('TestListAlerts' -in $global:SkippedTests) {

        $global:TestName = 'TestListAlerts'

        $Alerts = Get-AzsAlert

        foreach ($Alert in $Alerts) {
            ValidateAlert -Alert $Alert
        }
    }

    it "TestGetAlert" -Skip:$('TestGetAlert' -in $global:SkippedTests) {

        $global:TestName = 'TestGetAlert'

        $Regions = Get-AzsRegionHealth

        foreach ($Region in $Regions) {

            $Alerts = Get-AzsAlert -Location $Region.Name

            foreach ($Alert in $Alerts) {

                $retrieved = Get-AzsAlert -Location $Region.Name -Name $Alert.AlertId
                AssertAlertsAreSame -Expected $Alert -Found $retrieved
                return
            }
        }
    }

    it "TestGetAllAlerts" -Skip:$('TestGetAllAlerts' -in $global:SkippedTests) {

        $global:TestName = 'TestGetAllAlerts'

        $Regions = Get-AzsRegionHealth

        foreach ($Region in $Regions) {

            $Alerts = Get-AzsAlert -Location $Region.Name

            foreach ($Alert in $Alerts) {
                $retrieved = Get-AzsAlert -Location $Region.Name -Name $Alert.AlertId

                AssertAlertsAreSame -Expected $Alert -Found $retrieved
            }
        }
    }

    it "TestGetAllAlerts" -Skip:$('TestGetAllAlerts' -in $global:SkippedTests) {

        $global:TestName = 'TestGetAllAlerts'
             
        $Regions = Get-AzsRegionHealth

        foreach ($Region in $Regions) {

            $Alerts = Get-AzsAlert -Location $Region.Name

            foreach ($Alert in $Alerts) {
                $retrieved = Get-AzsAlert -InputObject $Alert
                AssertAlertsAreSame -Expected $Alert -Found $retrieved
            }
        }
    }
}