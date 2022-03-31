. (Join-Path $PSScriptRoot 'loadEnvJson.ps1')

$TestRecordingFile = Join-Path $PSScriptRoot 'Remove-AzsNetworkQuota.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Remove-AzsNetworkQuota' {
    . $PSScriptRoot\Common.ps1

    It "TestDeleteQuota" -Skip:$('TestDeleteQuota' -in $global:SkippedTests) {
        $global:TestName = 'TestDeleteQuota'
        
        # Remove the quota if it exists
        Remove-AzsNetworkQuota -Name $global:DeleteQuotaName

        # Create a new quota
        $quota = New-AzsNetworkQuota -Name $global:DeleteQuotaName

        # Assert that the quota was created
        $quota | Should not be $null

        # Delete the quota
        Remove-AzsNetworkQuota -Name $global:DeleteQuotaName

        try
        {
            Get-AzsNetworkQuota -Name $global:DeleteQuotaName
        }
        catch
        {
            # Assert that we got a not found exception 
            $_ -like "*$global:DeleteQuotaName not found.*" | Should be $true
        }
    }
}
