$loadEnvPath = Join-Path $PSScriptRoot 'loadEnvJson.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnvJson.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsContainerRegistryConfiguration.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzsContainerRegistryConfiguration' {
    BeforeEach {

        function ValidateConfiguration {
            param(
                [Parameter(Mandatory = $true)]
                $Configuration
            )
            $configuration							| Should Not Be $null
            $configuration.MaximumCapacityInGib		| Should Not Be $null
        }
    }

    AfterEach {
        $global:Client = $null
    }

    It "TestGetContainerRegistryConfiguration" -Skip:$('TestGetContainerRegistryConfiguration' -in $global:SkippedTests) {
        $global:TestName = 'TestGetContainerRegistryConfiguration'

        $result = Get-AzsContainerRegistryConfiguration  
        $result  | Should Not Be $null
        ValidateConfiguration -Configuration $result
    }
}
