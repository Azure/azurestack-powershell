$envFile = 'env.json'
Write-Host "Loading env.json"
if ($TestMode -eq 'live') {
    $envFile = 'localEnv.json'
}

if (Test-Path -Path (Join-Path $PSScriptRoot $envFile)) {
    $envFilePath = Join-Path $PSScriptRoot $envFile
} else {
    $envFilePath = Join-Path $PSScriptRoot '..\$envFile'
}
$env = @{}
if (Test-Path -Path $envFilePath) {
    $env = Get-Content (Join-Path $PSScriptRoot $envFile) | ConvertFrom-Json
    $PSDefaultParameterValues=@{"*:SubscriptionId"=$env.SubscriptionId; "*:Tenant"=$env.Tenant; "*:Location"=$env.Location}
    Write-Host "Default values: $($PSDefaultParameterValues.Values)"
}

$TestRecordingFile = Join-Path $PSScriptRoot 'Add-AzsVMExtension.Recording.json'
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

        $VMExtensions = Get-AzsVMExtension
        $VMExtensions | Should Not Be $null
        foreach ($VMExtension in $VMExtensions) {
            ValidateVMExtension -VMExtension $VMExtension
        }
    }


    It "TestGetVMExtension" -Skip:$('TestGetVMExtension' -in $global:SkippedTests) {
        $global:TestName = 'TestGetVMExtension'

        $VMExtensions = Get-AzsVMExtension
        $VMExtensions | Should Not Be $null
        foreach ($VMExtension in $VMExtensions) {
            ValidateVMExtension -VMExtension $VMExtension
        }
    }


    It "TestGetAllVMExtensions" -Skip:$('TestGetAllVMExtensions' -in $global:SkippedTests) {
        $global:TestName = 'TestGetAllVMExtensions'

        $VMExtensions = Get-AzsVMExtension
        $VMExtensions | Should Not Be $null
        foreach ($VMExtension in $VMExtensions) {
            $vmExt = Get-AzsVMExtension `
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
        Remove-AzsVMExtension -Publisher "Microsoft" -Type "MicroExtension" -Version "0.1.0"
    }
}

