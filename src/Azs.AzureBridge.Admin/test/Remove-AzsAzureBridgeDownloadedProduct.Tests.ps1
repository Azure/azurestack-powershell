$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)

$TestRecordingFile = Join-Path $PSScriptRoot 'Remove-AzsAzureBridgeDownloadedProduct.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Remove-AzsAzureBridgeDownloadedProduct' {
    
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

    It "TestRemoveAzsAzureBridgeDownloadedProduct" -Skip:$("TestRemoveAzsAzureBridgeDownloadedProduct" -in $global:SkippedTests) {
        $global:TestName = "TestRemoveAzsAzureBridgeDownloadedProduct"
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
            # Downloaded version = latest version: Uninstall latest version and then re-install.
            Remove-AzsAzureBridgeDownloadedProduct -ActivationName "default" -ResourceGroupName "azurestack-activation" -ProductName $downloadedExtension.Name.Split("/")[1]
            $oldDownloadedExtension = Get-AzsAzureBridgeDownloadedProduct -ActivationName "default" -ResourceGroupName "azurestack-activation" `
                | Where-Object {$_.DisplayName -eq "VM Access For Linux Extension"} `
                | Sort-Object -Property ProductProperties -Descending `
                | Select-Object -First 1

            $validate = $oldDownloadedExtension.ProductProperties -eq $downloadedExtension.ProductProperties
            $validate | Should Be $false

            Invoke-AzsAzureBridgeProductDownload -ActivationName "default" -ResourceGroupName "azurestack-activation" -ProductName $latestAvailableExtension.Name.Split("/")[1]
        }
        elseif ($downloadedExtension.ProductProperties -le $latestAvailableExtension.ProductProperties)
        {
            # Downloaded version < latest version: Install latest version then uninstall.
            Invoke-AzsAzureBridgeProductDownload -ActivationName "default" -ResourceGroupName "azurestack-activation" -ProductName $latestAvailableExtension.Name.Split("/")[1]
            $newDownloadedExtension = Get-AzsAzureBridgeDownloadedProduct -ActivationName "default" -ResourceGroupName "azurestack-activation" `
                | Where-Object {$_.DisplayName -eq "VM Access For Linux Extension"} `
                | Sort-Object -Property ProductProperties -Descending `
                | Select-Object -First 1

            $validate = $newDownloadedExtension.ProductProperties -eq $latestAvailableExtension.ProductProperties
            $validate | Should Be $true
            
            Remove-AzsAzureBridgeDownloadedProduct -ActivationName "default" -ResourceGroupName "azurestack-activation" -ProductName $newDownloadedExtension.Name.Split("/")[1]
            $oldDownloadedExtension = Get-AzsAzureBridgeDownloadedProduct -ActivationName "default" -ResourceGroupName "azurestack-activation" `
                | Where-Object {$_.DisplayName -eq "VM Access For Linux Extension"} `
                | Sort-Object -Property ProductProperties -Descending `
                | Select-Object -First 1

            $validate = $oldDownloadedExtension.ProductProperties -le $latestAvailableExtension.ProductProperties
            $validate | Should Be $true
        }
        elseif ($downloadedExtension.ProductProperties -ge $latestAvailableExtension.ProductProperties)
        {
            # Downloaded version > latest version: error since original state cannot be resumed after any installs or uninstalls.
            throw "The latest available extension version for $($latestAvailableExtension.Name) of $($latestAvailableExtension.ProductProperties) is behind the currently downloaded version $($downloadedExtension.ProductProperties). This test will not run since the removed product cannot be re-installed."
        }
    }

    # TODO: piping is bugged when run with Invoke-Pester, but works otherwise in a Powershell Core terminal.
    It "TestRemoveAzsAzureBridgeDownloadedProductPipeline" -Skip:$("TestRemoveAzsAzureBridgeDownloadedProductPipeline" -in $global:SkippedTests) {
        $global:TestName = "TestRemoveAzsAzureBridgeDownloadedProductPipeline"
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
            # Downloaded version = latest version: Uninstall latest version and then re-install.
            $downloadedExtension | Remove-AzsAzureBridgeDownloadedProduct
            $oldDownloadedExtension = Get-AzsAzureBridgeDownloadedProduct -ActivationName "default" -ResourceGroupName "azurestack-activation" `
                | Where-Object {$_.DisplayName -eq "VM Access For Linux Extension"} `
                | Sort-Object -Property ProductProperties -Descending `
                | Select-Object -First 1

            $validate = $oldDownloadedExtension.ProductProperties -eq $downloadedExtension.ProductProperties
            $validate | Should Be $false

            Invoke-AzsAzureBridgeProductDownload -ActivationName "default" -ResourceGroupName "azurestack-activation" -ProductName $latestAvailableExtension.Name.Split("/")[1]
        }
        elseif ($downloadedExtension.ProductProperties -le $latestAvailableExtension.ProductProperties)
        {
            # Downloaded version < latest version: Install latest version then uninstall.
            Invoke-AzsAzureBridgeProductDownload -ActivationName "default" -ResourceGroupName "azurestack-activation" -ProductName $latestAvailableExtension.Name.Split("/")[1]
            $newDownloadedExtension = Get-AzsAzureBridgeDownloadedProduct -ActivationName "default" -ResourceGroupName "azurestack-activation" `
                | Where-Object {$_.DisplayName -eq "VM Access For Linux Extension"} `
                | Sort-Object -Property ProductProperties -Descending `
                | Select-Object -First 1

            $validate = $newDownloadedExtension.ProductProperties -eq $latestAvailableExtension.ProductProperties
            $validate | Should Be $true
            
            $newDownloadedExtension | Remove-AzsAzureBridgeDownloadedProduct
            $oldDownloadedExtension = Get-AzsAzureBridgeDownloadedProduct -ActivationName "default" -ResourceGroupName "azurestack-activation" `
                | Where-Object {$_.DisplayName -eq "VM Access For Linux Extension"} `
                | Sort-Object -Property ProductProperties -Descending `
                | Select-Object -First 1

            $validate = $oldDownloadedExtension.ProductProperties -le $latestAvailableExtension.ProductProperties
            $validate | Should Be $true
        }
        elseif ($downloadedExtension.ProductProperties -ge $latestAvailableExtension.ProductProperties)
        {
            # Downloaded version > latest version: error since original state cannot be resumed after any installs or uninstalls.
            throw "The latest available extension version for $($latestAvailableExtension.Name) of $($latestAvailableExtension.ProductProperties) is behind the currently downloaded version $($downloadedExtension.ProductProperties). This test will not run since the removed product cannot be re-installed."
        }
    }
}
