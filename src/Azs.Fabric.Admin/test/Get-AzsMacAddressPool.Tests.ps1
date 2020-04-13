$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsMacAddressPool.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzsMacAddressPool' {
   . $PSScriptRoot\Common.ps1

    BeforeEach {

        function ValidateMacAddressPool {
            param(
                [Parameter(Mandatory = $true)]
                $MacAddressPool
            )

            $MacAddressPool          | Should Not Be $null

            # Resource
            $MacAddressPool.Id       | Should Not Be $null
            $MacAddressPool.Location | Should Not Be $null
            $MacAddressPool.Name     | Should Not Be $null
            $MacAddressPool.Type     | Should Not Be $null

            # Mac Address Pool
            $MacAddressPool.NumberOfAllocatedMacAddresses  | Should Not Be $null
            $MacAddressPool.NumberOfAvailableMacAddresses  | Should Not Be $null
            $MacAddressPool.StartMacAddress                | Should Not Be $null
            $MacAddressPool.EndMacAddress                  | Should Not Be $null
        }

        function AssertMacAddressPoolsAreSame {
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

                # Mac Address Pool
                $Found.NumberOfAllocatedMacAddresses  | Should Be $Expected.NumberOfAllocatedMacAddresses
                $Found.NumberOfAvailableMacAddresses  | Should Be $Expected.NumberOfAvailableMacAddresses
                $Found.StartMacAddress                | Should Be $Expected.StartMacAddress
                $Found.EndMacAddress                  | Should Be $Expected.EndMacAddress

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


    it "TestListMacAddressPools" -Skip:$('TestListMacAddressPools' -in $global:SkippedTests) {
        $global:TestName = 'TestListMacAddressPools'
        $macAddressPools = Get-AzsMacAddressPool -ResourceGroupName $global:ResourceGroupName -Location $Location
        $macAddressPools | Should Not Be $null
        foreach ($macAddressPool in $macAddressPools) {
            ValidateMacAddressPool -MacAddressPool $macAddressPool
        }
    }


    it "TestGetMacAddressPool" -Skip:$('TestGetMacAddressPool' -in $global:SkippedTests) {
        $global:TestName = 'TestGetMacAddressPool'

        $macAddressPools = Get-AzsMacAddressPool -ResourceGroupName $global:ResourceGroupName -Location $Location
        foreach ($macAddressPool in $macAddressPools) {
            $retrieved = Get-AzsMacAddressPool -ResourceGroupName $global:ResourceGroupName -Location $Location -Name $macAddressPool.Name
            AssertMacAddressPoolsAreSame -Expected $macAddressPool -Found $retrieved
            break
        }
    }

    it "TestGetAllMacAddressPools" -Skip:$('TestGetAllMacAddressPools' -in $global:SkippedTests) {
        $global:TestName = 'TestGetAllMacAddressPools'

        $macAddressPools = Get-AzsMacAddressPool -ResourceGroupName $global:ResourceGroupName -Location $Location
        foreach ($macAddressPool in $macAddressPools) {
            $retrieved = Get-AzsMacAddressPool -ResourceGroupName $global:ResourceGroupName -Location $Location -Name $macAddressPool.Name
            AssertMacAddressPoolsAreSame -Expected $macAddressPool -Found $retrieved
        }
    }
}
