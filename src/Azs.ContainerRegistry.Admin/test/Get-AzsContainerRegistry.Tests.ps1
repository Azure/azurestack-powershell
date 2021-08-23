$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsContainerRegistry.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzsContainerRegistry' {
    BeforeEach {

        function ValidateRegistry {
            param(
                [Parameter(Mandatory = $true)]
                $Registry
            )
            $registry				| Should Not Be $null
            $registry.CreationDate	| Should Not Be $null
            $registry.Id	        | Should Not Be $null
            $registry.Location	    | Should Not Be $null
            $registry.Name	        | Should Not Be $null
            $registry.PropertiesName| Should Not Be $null
            $registry.RegistryId	| Should Not Be $null
            $registry.RegistrySizeInByte | Should Not Be $null
            $registry.ResourceGroup	| Should Not Be $null
            $registry.SubscriptionId| Should Not Be $null
            $registry.Type	        | Should Not Be $null
        }
    }

    AfterEach {
        $global:Client = $null
    }

    It "TestGetContainerRegistryRegistry" -Skip:$('TestGetContainerRegistry' -in $global:SkippedTests) {
        $global:TestName = 'TestGetContainerRegistry'

        $result = Get-AzsContainerRegistry  
        $result  | Should Not Be $null
        ValidateRegistry -Registry $result
    }
}
