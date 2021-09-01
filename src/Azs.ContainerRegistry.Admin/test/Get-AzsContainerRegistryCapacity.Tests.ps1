$loadEnvPath = Join-Path $PSScriptRoot 'loadEnvJson.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnvJson.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsContainerRegistryCapacity.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzsContainerRegistryCapacity' {
    BeforeEach {

        function ValidateCapacity {
            param(
                [Parameter(Mandatory = $true)]
                $Capacity
            )
            $capacity								| Should Not Be $null
            $capacity.MaximumCapacityInGiB	        | Should Not Be $null
            $capacity.RegistriesConsumptionInGiB	| Should Not Be $null
        }
    }

    AfterEach {
        $global:Client = $null
    }

    It "TestGetContainerRegistryCapacity" -Skip:$('TestGetContainerRegistryCapacity' -in $global:SkippedTests) {
        $global:TestName = 'TestGetContainerRegistryCapacity'

        $result = Get-AzsContainerRegistryCapacity  
        $result  | Should Not Be $null
        ValidateCapacity -Capacity $result
    }
}
