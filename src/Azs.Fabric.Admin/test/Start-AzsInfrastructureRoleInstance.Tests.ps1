$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Start-AzsInfrastructureRoleInstance.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Start-AzsInfrastructureRoleInstance' {
    . $PSScriptRoot\Common.ps1
	
	BeforeEach {
	}
	
	AfterEach {
        $global:Client = $null
    }

    It 'StartAzsInfrastructureRoleInstance' -skip:$('StartAzsInfrastructureRoleInstance' -in $global:SkippedTests) {
        { 
		    $global:TestName = 'RepairSacleUnit'

            $InfraRoleInstances = Get-AzsInfrastructureRoleInstance -ResourceGroupName $global:ResourceGroupName -Location $global:Location
            $InfraRoleInstances | Should Not Be $null
			
			Start-AzsInfrastructureRoleInstance -Name $InfraRoleInstances[0].Name -ResourceGroupName $global:ResourceGroupName -Location $global:Location -Force
		} | Should Not Throw
    }
}
