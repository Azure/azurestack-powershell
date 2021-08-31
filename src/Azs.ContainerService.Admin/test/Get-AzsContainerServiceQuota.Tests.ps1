$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsContainerServiceQuota.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzsContainerServiceQuota' {
    BeforeEach {
        function ValidateContainerServiceQuota {
            param(
                [Parameter(Mandatory = $true)]
                $ManagedClustersQuota
            )
            $managedClustersQuota		| Should Not Be $null
            $managedClustersQuota.name	| Should Not Be $null
        }
    }

    AfterEach {
        $global:Client = $null
    }

    It "TestGetContainerServiceQuota" -Skip:$('TestGetContainerServiceQuota' -in $global:SkippedTests) {
        $global:TestName = 'TestGetContainerServiceQuota'

        $result = Get-AzsContainerServiceQuota -Location $env.Location
        $result  | Should Not Be $null
        ValidateContainerServiceQuota -ManagedClustersQuota $result
    }
}
