$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsInfrastructureRoleInstance.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzsInfrastructureRoleInstance' {

    . $PSScriptRoot\Common.ps1

    BeforeEach {

        function ValidateInfrastructureRoleInstance {
            param(
                [Parameter(Mandatory = $true)]
                $InfrastructureRoleInstance
            )

            $InfrastructureRoleInstance          | Should Not Be $null

            # Resource
            $InfrastructureRoleInstance.Id       | Should Not Be $null
            $InfrastructureRoleInstance.Location | Should Not Be $null
            $InfrastructureRoleInstance.Name     | Should Not Be $null
            $InfrastructureRoleInstance.Type     | Should Not Be $null

            # Infra Role Instance
            $InfrastructureRoleInstance.ScaleUnit       | Should Not Be $null
            $InfrastructureRoleInstance.ScaleUnitNode   | Should Not Be $null
            $InfrastructureRoleInstance.SizeMemoryInGB  | Should Not Be $null
            $InfrastructureRoleInstance.NumberOfCores  | Should Not Be $null
            $InfrastructureRoleInstance.State           | Should Not Be $null

        }

        function AssertInfrastructureRoleInstancesAreSame {
            param(
                [Parameter(Mandatory = $true)]
                $Expected,

                [Parameter(Mandatory = $true)]
                $Found
            )
            if ($Expected -eq $null) {
                $Found | Should Be $null
            } else {
                $Found                  | Should Not Be $null

                # Resource
                $Found.Id               | Should Be $Expected.Id
                $Found.Location         | Should Be $Expected.Location
                $Found.Name             | Should Be $Expected.Name
                $Found.Type             | Should Be $Expected.Type

                # Infra Role Instance
                $Found.ScaleUnit         | Should Be $Expected.ScaleUnit
                $Found.ScaleUnitNode     | Should Be $Expected.ScaleUnitNode
                $Found.NumberOfCores     | Should Be $Expected.NumberOfCores
                $Found.SizeMemoryInGB    | Should Be $Expected.SizeMemoryInGB
                $Found.State             | Should Be $Expected.State

            }
        }
    }

    AfterEach {
        $global:Client = $null
    }

    It "TestListInfraRoleInstances" -Skip:$('TestListInfraRoleInstances' -in $global:SkippedTests) {
        $global:TestName = 'TestListInfraRoleInstances'
        $InfrastructureRoleInstances = Get-AzsInfrastructureRoleInstance -ResourceGroupName $global:ResourceGroupName -Location $global:Location
        $InfrastructureRoleInstances | Should Not Be $null
        foreach ($InfrastructureRoleInstance in $InfrastructureRoleInstances) {
            ValidateInfrastructureRoleInstance -InfrastructureRoleInstance $InfrastructureRoleInstance
        }
    }

    It "TestGetInfraRoleInstance" -Skip:$('TestGetInfraRoleInstance' -in $global:SkippedTests) {
        $global:TestName = 'TestGetInfraRoleInstance'

        $InfrastructureRoleInstances = Get-AzsInfrastructureRoleInstance -ResourceGroupName $global:ResourceGroupName -Location $global:Location
        foreach ($InfrastructureRoleInstance in $InfrastructureRoleInstances) {
            $retrieved = Get-AzsInfrastructureRoleInstance -ResourceGroupName $global:ResourceGroupName -Location $global:Location -Name $InfrastructureRoleInstance.Name
            AssertInfrastructureRoleInstancesAreSame -Expected $InfrastructureRoleInstance -Found $retrieved
            break
        }
    }

    It "TestGetAllInfraRoleInstances" -Skip:$('TestGetAllInfraRoleInstances' -in $global:SkippedTests) {
        $global:TestName = 'TestGetAllInfraRoleInstances'

        $InfrastructureRoleInstances = Get-AzsInfrastructureRoleInstance -ResourceGroupName $global:ResourceGroupName -Location $global:Location
        foreach ($InfrastructureRoleInstance in $InfrastructureRoleInstances) {
            $retrieved = Get-AzsInfrastructureRoleInstance -ResourceGroupName $global:ResourceGroupName -Location $global:Location -Name $InfrastructureRoleInstance.Name
            AssertInfrastructureRoleInstancesAreSame -Expected $InfrastructureRoleInstance -Found $retrieved
        }
    }

    It "TestInfraRoleInstancePowerOn" -Skip:$('TestInfraRoleInstancePowerOn' -in $global:SkippedTests) {
        $global:TestName = 'TestInfraRoleInstancePowerOn'
    
        $InfrastructureRoleInstances = Get-AzsInfrastructureRoleInstance -ResourceGroupName $global:ResourceGroupName -Location $global:Location
        foreach ($InfrastructureRoleInstance in $InfrastructureRoleInstances) {
            Start-AzsInfrastructureRoleInstance -ResourceGroupName $global:ResourceGroupName -Location $global:Location -Name $InfrastructureRoleInstance.Name -Force
            break
        }
    }
    
    It "TestInfraRoleInstancePowerOnAll" -Skip:$('TestInfraRoleInstancePowerOnAll' -in $global:SkippedTests) {
        $global:TestName = 'TestInfraRoleInstancePowerOnAll'
    
        $InfrastructureRoleInstances = Get-AzsInfrastructureRoleInstance -ResourceGroupName $global:ResourceGroupName -Location $global:Location
        foreach ($InfrastructureRoleInstance in $InfrastructureRoleInstances) {
            Start-AzsInfrastructureRoleInstance -ResourceGroupName $global:ResourceGroupName -Location $global:Location -Name $InfrastructureRoleInstance.Name -Force
        }
    }
 }