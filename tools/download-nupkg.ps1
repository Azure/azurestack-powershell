<#
    This script downloads artifacts from Azure Devops with build ID $BuildId using your personal access token 
    $AzSdkPersonalAccessToken, and downloads the artifacts as zip files to $DestinationFolder, where the .nupkg files will be
    extracted.
    
    $BuildId: The numerical ID of the build. If empty, the latest build ID number will be used.
    $DestinationFolder: The destination folder to download the artifacts and extract the nupkg. Defaults to the current 
        script's directory.
    $AzSdkPersonalAccessToken: The personal access token granted to you from Azure Devops. Defaults to environment variable 
        named "AzSdkPersonalAccessToken".
    
    Sample headers:
    
    Get the latest build information:
    $buildReq = @{
        Uri = "https://dev.azure.com/azure-sdk/internal/_apis/build/latest/azurestack-powershell%20-%20gen-sign?branchName=dev&api-version=5.1-preview.1"
        Headers = $headers
    }

    Get multiple builds:
    $listBuildsReq = @{
        Uri = "https://dev.azure.com/azure-sdk/internal/_apis/build/builds?buildNumber=api-version=5.1"
        Headers = $headers
    }
    
    Get the a single artifact of a single build:
    $artifactReq = @{
        Uri = "https://dev.azure.com/azure-sdk/internal/_apis/build/builds/258451/artifacts?artifactName=module-Azs.Commerce.Admin&api-version=5.1"
        Headers = $headers
    }
    
    Get all artifacts of a build:
    $listArtifactsReq = @{
        Uri = "https://dev.azure.com/azure-sdk/internal/_apis/build/builds/${BuildId}/artifacts?api-version=5.1"
        Headers = $headers
    }
#>

Param (
    [string]$BuildId,
    [string]$DestinationFolder = $PSScriptRoot,
    [string]$AzSdkPersonalAccessToken = $env:AzSdkPersonalAccessToken
)

$user = $AzSdkPersonalAccessToken
$pass = $AzSdkPersonalAccessToken
$pair = "${user}:${pass}"
$bytes = [System.Text.Encoding]::ASCII.GetBytes($pair)
$base64 = [System.Convert]::ToBase64String($bytes)
$basicAuthValue = "Basic $base64"
$headers = @{ Authorization = $basicAuthValue }
$apiVersion = "5.1-preview"

# If the $BuildId is empty string, download from the latest build.
if ($BuildId -eq "")
{
    $buildReq = @{
        Uri = "https://dev.azure.com/azure-sdk/internal/_apis/build/latest/azurestack-powershell%20-%20gen-sign?branchName=dev&api-version=${apiVersion}"
        Headers = $headers
    }
    
    $result = Invoke-RestMethod @buildReq -Method Get
    $BuildId = $result.buildNumber
}

$listArtifactsReq = @{
    Uri = "https://dev.azure.com/azure-sdk/internal/_apis/build/builds/${BuildId}/artifacts?api-version=${apiVersion}"
    Headers = $headers
}

$result = Invoke-RestMethod @listArtifactsReq -Method Get

<#####################################

           DOWNLOAD ZIPS

#####################################>
$downloadedModuleZips = New-Object System.Collections.Generic.List[System.Object]
foreach($resultValue in $result.value) {
    Write-Host "Downloading: $($resultValue.resource.downloadUrl)"
    $fileReq = @{
        Uri = $resultValue.resource.downloadUrl
        Headers = $headers
    }
    $downloadedModuleZips.add("${DestinationFolder}\$($resultValue.name).zip")
    Invoke-RestMethod @fileReq -Method Get -Outfile "${DestinationFolder}\$($resultValue.name).zip"
}

<#####################################

            EXTRACT ZIPS

#####################################>
$extractedModulesFolder = New-Object System.Collections.Generic.List[System.Object]

foreach($moduleZip in $downloadedModuleZips)
{
    $expanded = Expand-Archive -LiteralPath $moduleZip -DestinationPath $DestinationFolder -Force -PassThru

    foreach($expandedFolder in $expanded)
    {
        if ($expandedFolder.directory.name -match "module-[^\\]*$")
        {
            $extractedModulesFolder.add($expandedFolder.directory.fullName)
        }
    }
    
    Remove-Item $moduleZip
}

<#####################################

            COPY NUPKG

#####################################>
foreach($extractedModuleFolder in $extractedModulesFolder)
{
    $nupkgs = Get-ChildItem $extractedModuleFolder -Filter "*.nupkg"
    
    foreach($nupkg in $nupkgs)
    {
        copy-item $nupkg.FullName -Destination $DestinationFolder -Force
    }

    Remove-Item -LiteralPath $extractedModuleFolder -Force -Recurse
}