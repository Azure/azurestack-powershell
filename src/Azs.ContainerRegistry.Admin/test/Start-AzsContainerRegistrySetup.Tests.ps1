$loadEnvPath = Join-Path $PSScriptRoot 'loadEnvJson.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnvJson.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Start-AzsContainerRegistrySetup.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Start-AzsContainerRegistrySetup' {
        $password = ConvertTo-SecureString "password" -AsPlainText -Force
        $pfx_cert_path = Join-Path $PSScriptRoot 'SSL.pem'
        
        { Start-AzsContainerRegistrySetup -Password $password -SslCertInputFile $pfx_cert_path } | Should Not Throw
}
