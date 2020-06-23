. (Join-Path $PSScriptRoot 'loadEnvJson.ps1')

$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsStorageAcquisition.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzsStorageAcquisition' {

    . $PSScriptRoot\Common.ps1

    BeforeEach {

        function ValidateAcquisition {
            param(
                [Parameter(Mandatory = $true)]
                $Acquisition
            )
            # Resource
            $Acquisition             | Should Not Be $null

            # Validate acquisition properties
            $Acquisition.Acquisitionid		| Should Not Be $null
            $Acquisition.Blob				| Should Not Be $null
            $Acquisition.Container			| Should Not Be $null
            $Acquisition.FilePath			| Should Not Be $null
            $Acquisition.Maximumblobsize    | Should Not Be $null
            $Acquisition.Storageaccount     | Should Not Be $null
            $Acquisition.Susbcriptionid		| Should Not Be $null
        }
    }

    AfterEach {
        $global:Client = $null
    }

    It "TestListAllAcquisitions" -Skip:$('TestListAllAcquisitions' -in $global:SkippedTests) {
        $global:TestName = 'TestListAllAcquisitions'

        $acquisitions = Get-AzsStorageAcquisition 
        foreach ($acquisition in $acquisitions.Value) {
            ValidateAcquisition -Acquisition $acquisition
        }
    }
}
