$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)

$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsGalleryItem.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName
. $PSScriptRoot\Common.ps1

Describe 'Get-AzsGalleryItem' {
    it "TestListAllGalleryItems" -Skip:$('TestListAllGalleryItems' -in $global:SkippedTests) {
        $global:TestName = 'TestListAllGalleryItems'

        $GalleryItems = Get-AzsGalleryItem
        $GalleryItems | Should Not Be $null
        foreach ($GalleryItem in $GalleryItems) {
            ValidateGalleryItem -GalleryItem $GalleryItem
        }
    }


    it "TestGetGalleryItem" -Skip:$('TestGetGalleryItem' -in $global:SkippedTests) {
        $global:TestName = 'TestGetGalleryItem'

        $GalleryItems = Get-AzsGalleryItem
        $GalleryItems | Should Not Be $null
        foreach ($GalleryItem in $GalleryItems) {
            $retrieved = Get-AzsGalleryItem -Name $GalleryItem.Name
            AssertGalleryItemsAreSame -Expected $GalleryItem -Found $retrieved
        }
    }
}
