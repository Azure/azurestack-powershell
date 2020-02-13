$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsVMExtension.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

$Global:UseInstalled = $UseInstalled
$global:RunRaw = $RunRaw
$global:TestName = ""

Describe 'Get-AzsVMExtension' {
    . $PSScriptRoot\Common.ps1

    BeforeEach {

        function ValidateVMExtension {
            param(
                [Parameter(Mandatory = $true)]
                $VMExtension
            )

            $VMExtension          | Should Not Be $null

            # Resource
            $VMExtension.Id       | Should Not Be $null
            $VMExtension.Type     | Should Not Be $null
        }

        function ValidateSameVMExtension {
            param(
                $VMExt1,
                $VMExt2
            )
            Get-Member -InputObject $VMExt1 -MemberType Properties {
                $variable = $_.Name
                $VMExt1."$variable" | Should be $VMExt2."$variable"
            }
        }
    }

    AfterEach {
        $global:Client = $null
    }


    It "TestListVMExtensions" -Skip:$('TestListVMExtensions' -in $global:SkippedTests) {
        $global:TestName = 'TestListVMExtensions'

        $VMExtensions = Get-AzsVMExtension -Location $global:Location
        $VMExtensions | Should Not Be $null
        foreach ($VMExtension in $VMExtensions) {
            ValidateVMExtension -VMExtension $VMExtension
        }
    }


    It "TestGetVMExtension" -Skip:$('TestGetVMExtension' -in $global:SkippedTests) {
        $global:TestName = 'TestGetVMExtension'

        $VMExtensions = Get-AzsVMExtension -Location $global:Location
        $VMExtensions | Should Not Be $null
        foreach ($VMExtension in $VMExtensions) {
            ValidateVMExtension -VMExtension $VMExtension
        }
    }


    It "TestGetAllVMExtensions" -Skip:$('TestGetAllVMExtensions' -in $global:SkippedTests) {
        $global:TestName = 'TestGetAllVMExtensions'

        $VMExtensions = Get-AzsVMExtension -Location $global:Location
        $VMExtensions | Should Not Be $null
        foreach ($VMExtension in $VMExtensions) {
            $vmExt = Get-AzsVMExtension `
                -Location $vmextension.Location `
                -Publisher $vmExtension.Publisher `
                -Type $vmExtension.ExtensionType `
                -Version $vmExtension.TypeHandlerVersion `

            $vmExt | Should not be $null
            ValidateSameVMExtension $VMExtension $vmExt
        }
    }


    It "TestCreateVMExtension" -Skip:$('TestCreateVMExtension' -in $global:SkippedTests) {
        $global:TestName = 'TestCreateVMExtension'
        $result = Add-AzsVMExtension `
            -Location $global:Location `
            -Publisher "Microsoft" `
            -Type "MicroExtension" `
            -Version "0.1.0" `
            -ComputeRole "IaaS" `
            -SourceBlob "https://github.com/Microsoft/PowerShell-DSC-for-Linux/archive/v1.1.1-294.zip" `
            -SupportMultipleExtensions `
            -VmOsType "Linux"
        $result | Should not be $null
    }


    It "TestDeleteVMExtension" -Skip:$('TestDeleteVMExtension' -in $global:SkippedTests) {
        $global:TestName = 'TestDeleteVMExtension'
        Remove-AzsVMExtension -Location $global:Location -Publisher "Microsoft" -Type "MicroExtension" -Version "0.1.0"
    }
}

