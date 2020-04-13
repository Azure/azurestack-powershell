$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsSlbMuxInstance.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzsSlbMuxInstance' {
    . $PSScriptRoot\Common.ps1

    BeforeEach {

        function ValidateSlbMuxInstance {
            param(
                [Parameter(Mandatory = $true)]
                $SlbMuxInstance
            )

            $SlbMuxInstance          | Should Not Be $null

            # Resource
            $SlbMuxInstance.Id       | Should Not Be $null
            $SlbMuxInstance.Location | Should Not Be $null
            $SlbMuxInstance.Name     | Should Not Be $null
            $SlbMuxInstance.Type     | Should Not Be $null

            # Software Load Balancing Mux Instance
            $SlbMuxInstance.BgpPeers            | Should Not Be $null
            $SlbMuxInstance.ConfigurationState  | Should Not Be $null
            $SlbMuxInstance.VirtualServer       | Should Not Be $null
        }

        function AssertSlbMuxInstancesAreSame {
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

                # Software Load Balancing Mux Instance
                if ($Expected.BgpPeers -eq $null) {
                    $Found.BgpPeers        | Should Be $null
                }
                else {
                    $Found.BgpPeers        | Should not Be $null
                    $Found.BgpPeers.Count  | Should Be $Expected.BgpPeers.Count
                }

                $Found.ConfigurationState  | Should Be $Expected.ConfigurationState
                $Found.VirtualServer       | Should Be $Expected.VirtualServer
            }
        }
    }

    AfterEach {
        $global:Client = $null
    }


    it "TestListSlbMuxInstances" -Skip:$('TestListSlbMuxInstances' -in $global:SkippedTests) {
        $global:TestName = 'TestListSlbMuxInstances'
        $SlbMuxInstances = Get-AzsSlbMuxInstance -ResourceGroupName $global:ResourceGroupName -Location $Location
        $SlbMuxInstances | Should Not Be $null
        foreach ($SlbMuxInstance in $SlbMuxInstances) {
            ValidateSlbMuxInstance -SlbMuxInstance $SlbMuxInstance
        }
    }


    it "TestGetSlbMuxInstance" -Skip:$('TestGetSlbMuxInstance' -in $global:SkippedTests) {
        $global:TestName = 'TestGetSlbMuxInstance'

        $SlbMuxInstances = Get-AzsSlbMuxInstance -ResourceGroupName $global:ResourceGroupName -Location $Location
        foreach ($SlbMuxInstance in $SlbMuxInstances) {
            $retrieved = Get-AzsSlbMuxInstance -ResourceGroupName $global:ResourceGroupName -Location $Location -Name $SlbMuxInstance.Name
            AssertSlbMuxInstancesAreSame -Expected $SlbMuxInstance -Found $retrieved
            break
        }
    }

    it "TestGetAllSlbMuxInstances" -Skip:$('TestGetAllSlbMuxInstances' -in $global:SkippedTests) {
        $global:TestName = 'TestGetAllSlbMuxInstances'

        $SlbMuxInstances = Get-AzsSlbMuxInstance -ResourceGroupName $global:ResourceGroupName -Location $Location
        foreach ($SlbMuxInstance in $SlbMuxInstances) {
            $retrieved = Get-AzsSlbMuxInstance -ResourceGroupName $global:ResourceGroupName -Location $Location -Name $SlbMuxInstance.Name
            AssertSlbMuxInstancesAreSame -Expected $SlbMuxInstance -Found $retrieved
        }
    }
}
