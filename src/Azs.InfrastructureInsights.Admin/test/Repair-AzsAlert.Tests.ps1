. (Join-Path $PSScriptRoot 'loadEnvJson.ps1')

$TestRecordingFile = Join-Path $PSScriptRoot 'Repair-AzsAlert.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe "Alerts" -Tags @('Alert', 'InfrastructureInsightsAdmin') {

    . $PSScriptRoot\Common.ps1

    it "TestRepairAlert" -Skip:$('TestRepairAlert' -in $global:SkippedTests) {

        $global:TestName = 'TestRepairAlert'
        $ErrorActionPreference = "SilentlyContinue"

        # Test repair for a non-existing alert
        Write-Verbose "Repairing alert with an invalid name"

        { Repair-AzsAlert -Name "wrongid" -ErrorAction Stop } | Should Throw "Guid should contain 32 digits with 4 dashes (xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx)."
        $Alerts = Get-AzsAlert
        $Alerts | Should Not Be $null

        foreach ($Alert in $Alerts)
        {
            $Alert | Should not be $null

            $Alert.State | Should not be $null

            Write-Verbose "Repairing alert $($Alert.AlertId)"
            
            if ($Alert.State -eq "Active" -and $Alert.hasValidRemediationAction -eq $true)
            {
                 Repair-AzsAlert -Name $Alert.AlertId
            }
        }
        return
    }
}