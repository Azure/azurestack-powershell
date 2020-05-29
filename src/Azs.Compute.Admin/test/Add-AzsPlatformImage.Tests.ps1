$envFile = 'env.json'
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

$TestRecordingFile = Join-Path $PSScriptRoot 'Add-AzsPlatformImage.Recording.json'
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
            $PlatformImage.OsType    | Should Not Be $null
            $PlatformImage.OsUri     | Should Not Be $null
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

        $platformImages = Get-AzsPlatformImage

        $platformImages  | Should Not Be $null
        foreach ($platformImage in $platformImages) {
            ValidatePlatformImage -PlatformImage $platformImage
        }
    }

    It "TestGetPlatformImage" -Skip:$('TestGetPlatformImage' -in $global:SkippedTests) {
        $global:TestName = 'TestGetPlatformImage'

        $platformImages = Get-AzsPlatformImage
        $platformImages  | Should Not Be $null

        foreach ($platformImage in $platformImages) {
            $result = Get-AzsPlatformImage -Publisher $platformImage.publisher -Offer $platformImage.offer -Sku $platformImage.sku -Version $platformImage.version
            AssertSame -Expected $platformImage -Found $result
            break
        }
    }
<# A lot of recordings are missing from this test
    It "TestGetAllPlatformImages" -Skip:$('TestGetAllPlatformImages' -in $global:SkippedTests) {
        $global:TestName = 'TestGetAllPlatformImages'

        $platformImages = Get-AzsPlatformImage
        $platformImages  | Should Not Be $null
        foreach ($platformImage in $platformImages) {
            $result = Get-AzsPlatformImage -InputObject $platformImage
            AssertSame -Expected $platformImage -Found $result
        }
    }
#>

<# TODO: UnComment once the test recordings are added for these tests.

    It "TestCreatePlatformImage" -Skip:$('TestCreatePlatformImage' -in $global:SkippedTests) {
        $global:TestName = 'TestCreatePlatformImage'

        
        $script:Publisher = "Canonical";
        $script:Offer = "UbuntuServer";
        $script:Sku = "16.04-LTS";
        $script:Version = "1.0.0";

        $image = Add-AzsPlatformImage `
            -Publisher $script:Publisher `
            -Offer $script:Offer `
            -Sku $script:Sku `
            -Version $script:Version `
            -OsType "Linux" `
            -OsUri $global:VHDUri

        $image | Should Not Be $null
        
        $image | Should Not Be $null
        Write-Debug "Image OSURI:"
        Write-Debug $image.OsUri

        Write-Debug "Global VHDUri:"
        Write-Debug $global:VHDUri
        $image.OsUri | Should be $global:VHDUri
        $image.OsType | Should be "Linux"

        while ($image.ProvisioningState -eq "Creating") {
            # Start-Sleep -Seconds 30
            $image = Get-AzsPlatformImage `
                -Publisher $script:Publisher `
                -Offer $script:Offer `
                -Sku $script:Sku `
                -Version $script:version
        }

        $image.ProvisioningState | Should be "Succeeded"

    }

    It "TestCreateAndDeletePlatformImage" -Skip:$('TestCreateAndDeletePlatformImage' -in $global:SkippedTests) {
        $global:TestName = 'TestCreateAndDeletePlatformImage'

        $script:Publisher = "Canonical";
        $script:Offer = "UbuntuServer";
        $script:Sku = "16.04-LTS";
        $script:Version = "1.0.0";

        $image = Add-AzsPlatformImage `
            -Publisher $script:Publisher `
            -Offer $script:Offer `
            -Sku $script:Sku `
            -Version $script:Version `
            -OsType "Linux" `
            -OsUri $global:VHDUri

        $image | Should Not Be $null
        $image.OsUri | Should be $global:VHDUri

        while ($image.ProvisioningState -ne "Succeeded") {
            $image = Get-AzsPlatformImage `
                -Publisher $script:Publisher `
                -Sku $script:Sku `
                -Offer $script:Offer `
                -Version $script:version
        }
        $image.ProvisioningState | Should be "Succeeded"
        Remove-AzsPlatformImage -Publisher $script:Publisher -Offer $script:Offer -Version $script:version -Sku $script:Sku
    }
    #>
}
