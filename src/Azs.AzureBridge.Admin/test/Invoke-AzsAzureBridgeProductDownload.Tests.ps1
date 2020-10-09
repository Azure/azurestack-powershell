$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)

$TestRecordingFile = Join-Path $PSScriptRoot 'Invoke-AzsAzureBridgeProductDownload.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Invoke-AzsAzureBridgeProductDownload' {
    
    . $PSScriptRoot\Common.ps1

    BeforeEach {

        function ValidateProductInfo {
            param(
                [Parameter(Mandatory = $true)]
                $Product
            )

            $Product          | Should Not Be $null

            # Resource
            $Product.Id       | Should Not Be $null
            $Product.Name     | Should Not Be $null
            $Product.Type     | Should Not Be $null

            $Product.GalleryItemIdentity    | Should Not Be $null
            $Product.ProductKind         | Should Not Be $null
            $Product.ProductProperties        | Should Not Be $null
            # $Product.Description  | Should Not Be $null
            $Product.DisplayName  | Should Not Be $null

        }
    }

    AfterEach {
        $global:Client = $null
    }

    It "TestDownloadAzsAzureBridgeProduct" -Skip:$("TestDownloadAzsAzureBridgeProduct" -in $global:SkippedTests) {
        $global:TestName = "TestDownloadAzsAzureBridgeProduct"
        $downloadedExtension = Get-AzsAzureBridgeDownloadedProduct -ActivationName "default" -ResourceGroupName "azurestack-activation" `
            | Where-Object {$_.DisplayName -eq "VM Access For Linux Extension"} `
            | Sort-Object -Property ProductProperties -Descending `
            | Select-Object -First 1

        $latestAvailableExtension = Get-AzsAzureBridgeProduct -ActivationName "default" -ResourceGroupName "azurestack-activation" `
            | Where-Object {$_.DisplayName -eq "VM Access For Linux Extension"} `
            | Sort-Object -Property ProductProperties -Descending `
            | Select-Object -First 1

        if ($downloadedExtension.ProductProperties -eq $latestAvailableExtension.ProductProperties)
        {
            Remove-AzsAzureBridgeDownloadedProduct -ActivationName "default" -ResourceGroupName "azurestack-activation" -ProductName $downloadedExtension.Name.Split("/")[1]
        }

        Invoke-AzsAzureBridgeProductDownload -ActivationName default -ResourceGroupName azurestack-activation -ProductName $latestAvailableExtension.Name.Split("/")[1]

        $downloadedExtension = Get-AzsAzureBridgeDownloadedProduct -ActivationName default -ResourceGroupName azurestack-activation `
            | Where-Object {$_.DisplayName -eq "VM Access For Linux Extension"} `
            | Sort-Object -Property ProductProperties -Descending `
            | Select-Object -First 1

        ValidateProductInfo $downloadedExtension
        Remove-AzsAzureBridgeDownloadedProduct -ActivationName "default" -ResourceGroupName "azurestack-activation" -ProductName $downloadedExtension.Name.Split("/")[1]
    }

    # TODO: piping is bugged when run with Invoke-Pester, but works otherwise in a Powershell Core terminal.
    It "TestDownloadAzsAzureBridgeProductPipeline" -Skip:$("TestDownloadAzsAzureBridgeProductPipeline" -in $global:SkippedTests) {
        $global:TestName = "TestDownloadAzsAzureBridgeProductPipeline"
        
        $downloadedExtension = Get-AzsAzureBridgeDownloadedProduct -ActivationName default -ResourceGroupName azurestack-activation `
            | Where-Object {$_.DisplayName -eq "VM Access For Linux Extension"} `
            | Sort-Object -Property ProductProperties -Descending `
            | Select-Object -First 1

        $latestAvailableExtension = Get-AzsAzureBridgeProduct -ResourceGroupName azurestack-activation -ActivationName default `
            | Where-Object {$_.DisplayName -eq "VM Access For Linux Extension"} `
            | Sort-Object -Property ProductProperties -Descending `
            | Select-Object -First 1

        if ($downloadedExtension.ProductProperties -eq $latestAvailableExtension.ProductProperties)
        {
            $downloadedExtension | Remove-AzsAzureBridgeDownloadedProduct
        }

        $latestAvailableExtension | Invoke-AzsAzureBridgeProductDownload -ActivationName "default" -ResourceGroupName "azurestack-activation"

        $downloadedExtension = Get-AzsAzureBridgeDownloadedProduct -ActivationName default -ResourceGroupName azurestack-activation `
        | Where-Object {$_.DisplayName -eq "VM Access For Linux Extension"} `
        | Sort-Object -Property ProductProperties -Descending `
        | Select-Object -First 1

        ValidateProductInfo $downloadedExtension
        $downloadedExtension | Remove-AzsAzureBridgeDownloadedProduct -ActivationName "default" -ResourceGroupName "azurestack-activation"
    }
}
