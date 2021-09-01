$loadEnvPath = Join-Path $PSScriptRoot 'loadEnvJson.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnvJson.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsContainerRegistrySetupStatus.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzsContainerRegistrySetupStatus' {

    BeforeEach {

        function ValidateSetupStatus {
            param(
                [Parameter(Mandatory = $true)]
                $SetupStatus
            )
            $setupStatus		| Should Not Be $null
            $setupStatus.Id	    | Should Not Be $null
            $setupStatus.Name	| Should Not Be $null
            $setupStatus.Type	| Should Not Be $null
            $setupStatus.Status	| Should Not Be $null
        }
    }

    AfterEach {
        $global:Client = $null
    }

    It "TestGetContainerRegistrySetupStatus" -Skip:$('TestGetContainerRegistrySetupStatus' -in $global:SkippedTests) {
        $global:TestName = 'TestGetContainerRegistrySetupStatus'

        $result = Get-AzsContainerRegistrySetupStatus  
        $result  | Should Not Be $null
        ValidateSetupStatus -SetupStatus $result
    }
}
