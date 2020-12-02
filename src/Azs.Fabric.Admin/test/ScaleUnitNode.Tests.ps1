$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'ScaleUnitNodeTest.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'ScaleUnitNodeTest' {
    . $PSScriptRoot\Common.ps1

    BeforeEach {

        function ValidateScaleUnitNode {
            param(
                [Parameter(Mandatory = $true)]
                $ScaleUnitNode
            )

            $ScaleUnitNode          | Should Not Be $null

            # Resource
            $ScaleUnitNode.Id       | Should Not Be $null
            $ScaleUnitNode.Location | Should Not Be $null
            $ScaleUnitNode.Name     | Should Not Be $null
            $ScaleUnitNode.Type     | Should Not Be $null

            # Scale Unit Node
            $ScaleUnitNode.CanPowerOff          | Should Not Be $null
            $ScaleUnitNode.CapacityOfCores      | Should Not Be $null
            $ScaleUnitNode.CapacityOfMemoryInGB | Should Not Be $null
            $ScaleUnitNode.PowerState           | Should Not Be $null
            $ScaleUnitNode.ScaleUnitName        | Should Not Be $null
            $ScaleUnitNode.ScaleUnitNodeStatus  | Should Not Be $null
            $ScaleUnitNode.ScaleUnitUri         | Should Not Be $null
        }

        function AssertScaleUnitNodesAreSame {
            param(
                [Parameter(Mandatory = $true)]
                $Expected,

                [Parameter(Mandatory = $true)]
                $Found
            )
            if ($Expected -eq $null) {
                $Found | Should Be $null
            }
            else {
                $Found                  | Should Not Be $null

                # Resource
                $Found.Id               | Should Be $Expected.Id
                $Found.Location         | Should Be $Expected.Location
                $Found.Name             | Should Be $Expected.Name
                $Found.Type             | Should Be $Expected.Type

                # Scale Unit Node
                $Found.CanPowerOff           | Should Be $Expected.CanPowerOff
                $Found.CapacityOfCores       | Should Be $Expected.CapacityOfCores
                $Found.CapacityOfMemoryInGB  | Should Be $Expected.CapacityOfMemoryInGB

                $Found.PowerState           | Should Be $Expected.PowerState
                $Found.ScaleUnitName        | Should Be $Expected.ScaleUnitName
                $Found.ScaleUnitNodeStatus  | Should Be $Expected.ScaleUnitNodeStatus
                $Found.ScaleUnitUri         | Should Be $Expected.ScaleUnitUri
            }
        }
    }

    AfterEach {
        $global:Client = $null
    }


    It "TestListScaleUnitNodes" -Skip:$('TestListScaleUnitNodes' -in $global:SkippedTests) {
        $global:TestName = 'TestListScaleUnitNodes'

        $ScaleUnitNodes = Get-AzsScaleUnitNode -ResourceGroupName $global:ResourceGroupName -Location $global:Location
        $ScaleUnitNodes | Should Not Be $null
        foreach ($ScaleUnitNode in $ScaleUnitNodes) {
            ValidateScaleUnitNode -ScaleUnitNode $ScaleUnitNode
        }
    }


    It "TestGetScaleUnitNode" -Skip:$('TestGetScaleUnitNode' -in $global:SkippedTests) {
        $global:TestName = 'TestGetScaleUnitNode'

        $ScaleUnitNodes = Get-AzsScaleUnitNode -ResourceGroupName $global:ResourceGroupName -Location $global:Location
        foreach ($ScaleUnitNode in $ScaleUnitNodes) {
            $retrieved = Get-AzsScaleUnitNode -ResourceGroupName $global:ResourceGroupName -Location $global:Location -Name $ScaleUnitNode.Name
            AssertScaleUnitNodesAreSame -Expected $ScaleUnitNode -Found $retrieved
            break
        }
    }

    It "TestGetAllScaleUnitNodes" -Skip:$('TestGetAllScaleUnitNodes' -in $global:SkippedTests) {
        $global:TestName = 'TestGetAllScaleUnitNodes'

        $ScaleUnitNodes = Get-AzsScaleUnitNode -ResourceGroupName $global:ResourceGroupName -Location $global:Location
        foreach ($ScaleUnitNode in $ScaleUnitNodes) {
            $retrieved = Get-AzsScaleUnitNode -ResourceGroupName $global:ResourceGroupName -Location $global:Location -Name $ScaleUnitNode.Name
            AssertScaleUnitNodesAreSame -Expected $ScaleUnitNode -Found $retrieved
        }
    }

    It "TestStartStopMaintenanceModeUnitNode" -Skip:$('TestStartStopMaintenanceModeUnitNode' -in $global:SkippedTests) {
        $global:TestName = 'TestStartStopMaintenanceModeUnitNode'

        $ScaleUnitNodes = Get-AzsScaleUnitNode -ResourceGroupName $global:ResourceGroupName -Location $global:Location
        foreach ($ScaleUnitNode in $ScaleUnitNodes) {
            {
                Disable-AzsScaleUnitNode -ResourceGroupName $global:ResourceGroupName -Location $global:Location -Name $ScaleUnitNode.Name -Force -ErrorAction Stop
                Enable-AzsScaleUnitNode -ResourceGroupName $global:ResourceGroupName -Location $global:Location -Name $ScaleUnitNode.Name -Force -ErrorAction Stop
            } | Should Not Throw
            break
        }
    }

    # Tenant VM

    It "TestGetScaleUnitNodeOnTenantVM" -Skip:$('TestGetScaleUnitNodeOnTenantVM' -in $global:SkippedTests) {
        $global:TestName = 'TestGetAllScaleUnitNodes'

        { Get-AzsScaleUnitNode -ResourceGroupName $global:ResourceGroupName -Location $global:Location -Name $global:TenantVMName -ErrorAction Stop } | Should Throw
    }

    It "TestPowerOnOnTenantVM" -Skip:$('TestPowerOnOnTenantVM' -in $global:SkippedTests) {
        $global:TestName = 'TestPowerOnOnTenantVM'
        {
            $operationStatus = Start-AzsScaleUnitNode -ResourceGroupName $global:ResourceGroupName -Location $global:Location -Name $global:TenantVMName -Force -ErrorAction Stop
            $operationStatus.ProvisioningState | Should not be ""
            $operationStatus.ProvisioningState | Should be "Failure"
        } | Should Throw
    }

    It "TestPowerOffOnTenantVM" -Skip:$('TestPowerOffOnTenantVM' -in $global:SkippedTests) {
        $global:TestName = 'TestPowerOffOnTenantVM'

        {
            $operationStatus = Stop-AzsScaleUnitNode -ResourceGroupName $global:ResourceGroupName -Location $global:Location -Name $global:TenantVMName -Force -ErrorAction Stop
            $operationStatus.ProvisioningState | Should not be ""
            $operationStatus.ProvisioningState | Should be "Failure"
        } | Should Throw
    }

    It "TestStartMaintenanceModeOnTenantVM" -Skip:$('TestStartMaintenanceModeOnTenantVM' -in $global:SkippedTests) {
        $global:TestName = 'TestStartMaintenanceModeOnTenantVM'
        {
            $operationStatus = Disable-AzsScaleUnitNode -ResourceGroupName $global:ResourceGroupName -Location $global:Location -Name $TenantVMName -Force -ErrorAction Stop
            $operationStatus.ProvisioningState | Should not be ""
            $operationStatus.ProvisioningState | Should be "Failure"
        } | Should Throw
    }


    # Disabled

    It "TestPowerOnScaleUnitNode" -Skip:$('TestPowerOnScaleUnitNode' -in $global:SkippedTests) {
        $global:TestName = 'TestPowerOnScaleUnitNode'

        $ScaleUnitNodes = Get-AzsScaleUnitNode -ResourceGroupName $global:ResourceGroupName -Location $global:Location
        foreach ($ScaleUnitNode in $ScaleUnitNodes) {
            Start-AzsScaleUnitNode -ResourceGroupName $global:ResourceGroupName -Location $global:Location -Name $ScaleUnitNode.Name -Force
            $retrieved | Should Be $null
            break
        }
    }

    It "TestPowerOffScaleUnitNode" -Skip:$('TestPowerOffScaleUnitNode' -in $global:SkippedTests) {
        $global:TestName = 'TestPowerOffScaleUnitNode'

        $ScaleUnitNodes = Get-AzsScaleUnitNode -ResourceGroupName $global:ResourceGroupName -Location $global:Location
        foreach ($ScaleUnitNode in $ScaleUnitNodes) {
            $retrieved = Stop-AzsScaleUnitNode -ResourceGroupName $global:ResourceGroupName -Location $global:Location -Name $ScaleUnitNode.Name -Force
            $retrieved | Should Be $null
            break
        }
    }

    It "TestAddScaleUnitNode" -Skip:$('TestAddScaleUnitNode' -in $global:SkippedTests) {
        $global:TestName = "TestAddScaleUnitNode"

        {
           Add-AzsScaleUnitNode -BmciPv4Address "100.71.11.155" -ComputerName "ASRR1N31R12U25" -ScaleUnit "s-cluster"
        } | Should throw

    }
}
