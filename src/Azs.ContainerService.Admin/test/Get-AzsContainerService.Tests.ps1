$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsContainerService.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzsContainerService' {
    BeforeEach {
        function ValidateContainerService {
            param(
                [Parameter(Mandatory = $true)]
                $ManagedClusters
            )
            $managedClusters						| Should Not Be $null
            $managedClusters.orchestratorVersion	| Should Not Be $null
            $managedClusters.provisioningState      | Should Not Be $null
        }
    }

    AfterEach {
        $global:Client = $null
    }

    It "TestGetContainerService" -Skip:$('TestGetContainerService' -in $global:SkippedTests) {
        $global:TestName = 'TestGetContainerService'

        $result = Get-AzsContainerService -Location $env.Location
        $result  | Should Not Be $null
        ValidateContainerService -ManagedClusters $result
    }
}
