. (Join-Path $PSScriptRoot 'loadEnvJson.ps1')

$TestRecordingFile = Join-Path $PSScriptRoot 'Set-AzsNetworkQuota.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-AzsNetworkQuota' {

    . $PSScriptRoot\Common.ps1

    BeforeEach {
        function AssertQuotaWasModified {
            param(
                $quota,
                $newMaxVnetsPerSubscription
            )

            $quota.MaxVnetsPerSubscription -eq $newMaxVnetsPerSubscription | Should Be $true
        }
    }
    It "TestSetQuota" -Skip:$('TestSetQuota' -in $global:SkippedTests) {
        $global:TestName = 'TestSetQuota'
        
        # Remove the quota if it exists
        Remove-AzsNetworkQuota -Name $global:SetQuotaName

        # Create a new quota
        $quota = New-AzsNetworkQuota -Name $global:SetQuotaName

        $quota.MaxVnetsPerSubscription = 64
        $quota | Set-AzsNetworkQuota

        # Validate that the quota was modified
        AssertQuotaWasModified -Quota $quota -newMaxVnetsPerSubscription 64

        # Cleanup
        Remove-AzsNetworkQuota -Name $global:SetQuotaName
    }
}
