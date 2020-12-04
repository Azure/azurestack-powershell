$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Add-AzsScaleUnitNode.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Add-AzsScaleUnitNode' {
    . $PSScriptRoot\Common.ps1
	
	BeforeEach {
	}
	
	AfterEach {
        $global:Client = $null
    }

    It "TestAddScaleUnitNode" -Skip:$('TestAddScaleUnitNode' -in $global:SkippedTests) {
        $global:TestName = "TestAddScaleUnitNode"

        {
           Add-AzsScaleUnitNode -BmciPv4Address "100.71.11.155" -ComputerName "ASRR1N31R12U25" -ScaleUnit "s-cluster" -ResourceGroupName $global:ResourceGroupName -Location $global:Location
        } | Should throw
    }
}
