$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Set-AzsScaleUnit.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Set-AzsScaleUnit' {
    . $PSScriptRoot\Common.ps1
    
        BeforeEach {

        function AssertScaleUnitNodesPropertiesChange {
            param(
                [Parameter(Mandatory = $true)]
                $Updated,

                [Parameter(Mandatory = $true)]
                $Original,

                [Parameter(Mandatory = $true)]
                $NewGpuPartitionSize
            )
            if ($Updated -eq $null) {
                $Original | Should Be $null
            }
            else {
                $Original                  | Should Not Be $null

                # Resource
                $Original.Id               | Should Be $Updated.Id
                $Original.Location         | Should Be $Updated.Location
                $Original.Name             | Should Be $Updated.Name
                $Original.Type             | Should Be $Updated.Type

                # Scale Unit Node
                $Original.CanPowerOff          | Should Be $Updated.CanPowerOff
                $Original.CapacityOfCores      | Should Be $Updated.CapacityOfCores
                $Original.CapacityOfMemoryInGB | Should Be $Updated.CapacityOfMemoryInGB

                $Original.PowerState           | Should Be $Updated.PowerState
                $Original.ScaleUnitName        | Should Be $Updated.ScaleUnitName
                $Original.ScaleUnitNodeStatus  | Should Be $Updated.ScaleUnitNodeStatus
                $Original.ScaleUnitUri         | Should Be $Updated.ScaleUnitUri

                $Original.IsGpuAvailable       | Should Be $Updated.IsGpuAvailable
				$Original.GpuType              | Should Be $Updated.GpuType
				$Original.GpuPartitionSize     | Should Not Be $Updated.GpuPartitionSize
                $Updated.GpuPartitionSize      | Should Be $NewGpuPartitionSize
            }
        }
    }

    AfterEach {
        $global:Client = $null
    }
     
    It 'TestSetAzsScaleUnit' -skip:$('TestSetAzsScaleUnit' -in $global:SkippedTests) {
        $global:TestName = 'SetScaleUnit'
		
		$ScaleUnits = Get-AzsScaleUnit -ResourceGroupName $global:ResourceGroupName -Location $Location
        $ScaleUnits | Should Not Be $null
		
        foreach ($ScaleUnit in $ScaleUnits) {
		    if($ScaleUnit.IsGpuAvailable)
			{
				$newSize = 4
				if($ScaleUnit.GpuPartitionSize -eq 4)
				{
				    $newSize = 8
				}
				
			    Set-AzsScaleUnit -NumberOfGPUPartition $newSize -ResourceGroupName $global:ResourceGroupName -Location $global:Location -Name $ScaleUnit.Name -Force -ErrorAction Stop
                Start-Sleep -Seconds 300
				$retrieved = Get-AzsScaleUnit -ResourceGroupName $global:ResourceGroupName -Location $Location -Name $ScaleUnit.Name

                AssertScaleUnitNodesPropertiesChange -Original $ScaleUnit -Updated $retrieved -NewGpuPartitionSize $newSize
			}
        }
    }
}
