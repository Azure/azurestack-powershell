$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsPlatformImage.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

$Global:UseInstalled = $UseInstalled
$global:RunRaw = $RunRaw
$global:TestName = ""

Describe 'Get-AzsPlatformImage' {
    
    . $PSScriptRoot\Common.ps1

    BeforeEach {

        function Create() {

        }

        function ValidatePlatformImage {
            param(
                [Parameter(Mandatory = $true)]
                $PlatformImage
            )

            $PlatformImage          | Should Not Be $null

            # Resource
            $PlatformImage.Id       | Should Not Be $null
            $PlatformImage.Type     | Should Not Be $null

            # Subscriber Usage Aggregate
            $PlatformImage.OsDisk    | Should Not Be $null
            $PlatformImage.ProvisioningState    | Should Not Be $null
        }

        function AssertSame {
            param(
                $Expected,
                $Found
            )
        }
    }

    AfterEach {
        $global:Client = $null
    }

    It "TestListPlatformImages" -Skip:$('TestListPlatformImages' -in $global:SkippedTests) {
        $global:TestName = 'TestListPlatformImages'

        $platformImages = Get-AzsPlatformImage -Location $global:Location

        $platformImages  | Should Not Be $null
        foreach ($platformImage in $platformImages) {
            ValidatePlatformImage -PlatformImage $platformImage
        }
    }

    It "TestGetPlatformImage" -Skip:$('TestGetPlatformImage' -in $global:SkippedTests) {
        $global:TestName = 'TestGetPlatformImage'

        $platformImages = Get-AzsPlatformImage -Location $global:Location
        $platformImages  | Should Not Be $null

        foreach ($platformImage in $platformImages) {
            $result = Get-AzsPlatformImage -Location $global:Location -Publisher $platformImage.publisher -Offer $platformImage.offer -Sku $platformImage.sku -Version $platformImage.version
            AssertSame -Expected $platformImage -Found $result
            break
        }
    }

    It "TestGetAllPlatformImages" -Skip:$('TestGetAllPlatformImages' -in $global:SkippedTests) {
        $global:TestName = 'TestGetAllPlatformImages'

        $platformImages = Get-AzsPlatformImage -Location $global:Location
        $platformImages  | Should Not Be $null
        foreach ($platformImage in $platformImages) {
            $result = $platformImage | Get-AzsPlatformImage
            AssertSame -Expected $platformImage -Found $result
        }
    }

    It "TestCreatePlatformImage" -Skip:$('TestCreatePlatformImage' -in $global:SkippedTests) {
        $global:TestName = 'TestCreatePlatformImage'

        $script:Location = $global:Location;
        $script:Publisher = "Canonical";
        $script:Offer = "UbuntuServer";
        $script:Sku = "16.04-LTS";
        $script:Version = "1.0.0";

        $image = Add-AzsPlatformImage `
            -Location $script:Location `
            -Publisher $script:Publisher `
            -Offer $script:Offer `
            -Sku $script:Sku `
            -Version $script:Version `
            -OsType "Linux" `
            -OsUri $global:VHDUri

        $image | Should Not Be $null
        $image.OsDisk.Uri | Should be $global:VHDUri
        $image.OsDisk.OsType | Should be "Linux"

        while ($image.ProvisioningState -eq "Creating") {
            # Start-Sleep -Seconds 30
            Write-host $script:Location
            $image = Get-AzsPlatformImage `
                -Location $script:Location `
                -Publisher $script:Publisher `
                -Offer $script:Offer `
                -Version $script:version
        }

        $image.ProvisioningState | Should be "Succeeded"

    }

    It "TestCreateAndDeletePlatformImage" -Skip:$('TestCreateAndDeletePlatformImage' -in $global:SkippedTests) {
        $global:TestName = 'TestCreateAndDeletePlatformImage'

        $script:Location = $global:Location;
        $script:Publisher = "Microsoft";
        $script:Offer = "UbuntuServer";
        $script:Sku = "16.04-LTS";
        $script:Version = "1.0.0";

        $image = Add-AzsPlatformImage `
            -Location $script:Location `
            -Publisher $script:Publisher `
            -Offer $script:Offer `
            -Sku $script:Sku `
            -Version $script:Version `
            -OsType "Linux" `
            -OsUri $global:VHDUri

        $image | Should Not Be $null
        $image.OsDisk.Uri | Should be $global:VHDUri

        while ($image.ProvisioningState -ne "Succeeded") {
            $image = Get-AzsPlatformImage `
                -Location $script:Location `
                -Publisher $script:Publisher `
                -Offer $script:Offer `
                -Version $script:version
        }
        $image.ProvisioningState | Should be "Succeeded"
        Remove-AzsPlatformImage -Location $script:Location -Publisher $script:Publisher -Offer $script:Offer -Version $script:version -Sku $script:Sku
    }
}
