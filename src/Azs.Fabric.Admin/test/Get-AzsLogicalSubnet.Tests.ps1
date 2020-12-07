$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsLogicalSubnet.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzsLogicalSubnet' {
    . $PSScriptRoot\Common.ps1

    BeforeEach {

        function ValidateLogicalSubnet {
            param(
                [Parameter(Mandatory = $true)]
                $LogicalSubnet
            )

            $LogicalSubnet          | Should Not Be $null

            # Resource
            $LogicalSubnet.Id       | Should Not Be $null
            $LogicalSubnet.Location | Should Not Be $null
            $LogicalSubnet.Name     | Should Not Be $null
            $LogicalSubnet.Type     | Should Not Be $null

            # Logical Network
            <#
			$LogicalSubnet.Metadata  | Should Not Be $null
			#>
            $LogicalSubnet.IpPool    | Should Not Be $null
            $LogicalSubnet.IsPublic  | Should Not Be $null
        }

        function AssertLogicalSubnetsAreSame {
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

                # Logical Network
                if ($Expected -eq $null) {
                    $Found.IpPool | Should be $null
                }
                else {
                    $Found.IpPool.Count   | Should Be $Expected.IpPool.Count
                }
                $Found.IsPublic  | Should Be $Expected.IsPublic

                if ($Expected.Metadata -eq $null) {
                    $Found.Metadata        | Should Be $null
                }
                else {
                    $Found.Metadata        | Should Not Be $null
                    $Found.Metadata.Count  | Should Be $Expected.Metadata.Count
                }
            }
        }
    }

    AfterEach {
        $global:Client = $null
    }


    it "TestListLogicalSubnets" -Skip:$('TestListLogicalSubnets' -in $global:SkippedTests) {
        $global:TestName = 'TestListLogicalSubnets'

        $logicalNetworks = Get-AzsLogicalNetwork -ResourceGroupName $global:ResourceGroupName -Location $Location
        foreach ($logicalNetwork in $logicalNetworks) {
            $logicalSubnets = Get-AzsLogicalSubnet -ResourceGroupName $global:ResourceGroupName -Location $Location -LogicalNetwork $logicalNetwork.Name
            foreach ($logicalSubnet in $logicalSubnets) {
                ValidateLogicalSubnet $logicalSubnet
            }
            break
        }
    }


    it "TestGetLogicalSubnet" -Skip:$('TestGetLogicalSubnet' -in $global:SkippedTests) {
        $global:TestName = 'TestGetLogicalSubnet'

        $logicalNetworks = Get-AzsLogicalNetwork -ResourceGroupName $global:ResourceGroupName -Location $Location
        foreach ($logicalNetwork in $logicalNetworks) {
            $logicalSubnets = Get-AzsLogicalSubnet -ResourceGroupName $global:ResourceGroupName -Location $Location -LogicalNetwork $logicalNetwork.Name
            foreach ($logicalSubnet in $logicalSubnets) {
                $retrieved = Get-AzsLogicalSubnet -ResourceGroupName $global:ResourceGroupName -Location $Location -LogicalNetwork $logicalNetwork.Name -Name $logicalSubnet.Name
                AssertLogicalSubnetsAreSame -Expected $logicalSubnet -Found $retrieved
                break
            }
            break
        }
    }

    it "TestGetAllLogicalSubnets" -Skip:$('TestGetAllLogicalSubnets' -in $global:SkippedTests) {
        $global:TestName = 'TestGetAllLogicalSubnets'

        $logicalNetworks = Get-AzsLogicalNetwork -ResourceGroupName $global:ResourceGroupName -Location $Location
        foreach ($logicalNetwork in $logicalNetworks) {
            $logicalSubnets = Get-AzsLogicalSubnet -ResourceGroupName $global:ResourceGroupName -Location $Location -LogicalNetwork $logicalNetwork.Name
            foreach ($logicalSubnet in $logicalSubnets) {
                $retrieved = Get-AzsLogicalSubnet -ResourceGroupName $global:ResourceGroupName -Location $Location -LogicalNetwork $logicalNetwork.Name -Name $logicalSubnet.Name
                AssertLogicalSubnetsAreSame -Expected $logicalSubnet -Found $retrieved
            }
        }
    }
}

