$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Restart-AzsInfrastructureRole.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Restart-AzsInfrastructureRole' {
    . $PSScriptRoot\Common.ps1
	
	BeforeEach {
	}
	
	AfterEach {
        $global:Client = $null
    }

    It 'RestartInfrastructureRole' -skip:$('RestartInfrastructureRole' -in $global:SkippedTests) {
        { 
            $global:TestName = 'RestartInfrastructureRole'

            $InfraRoles = Get-AzsInfrastructureRole -ResourceGroupName $global:ResourceGroupName -Location $global:Location | Where-Object {$_.ReStartable -eq $true}
            $InfraRoles | Should Not Be $null

            Restart-AzsInfrastructureRole -Name $InfraRoles[1].Name -ResourceGroupName $global:ResourceGroupName -Location $global:Location -Force
        } | Should Not Throw
    }
}
