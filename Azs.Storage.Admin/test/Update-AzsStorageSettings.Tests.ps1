$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Update-AzsStorageSettings.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Update-AzsStorageSettings' {

    . $PSScriptRoot\Common.ps1

    It "TestUpdateStorageSettings" -Skip:$('TestUpdateStorageSettings' -in $global:SkippedTests) {
        $global:TestName = 'TestUpdateStorageSettings'

        $originalDays = (Get-AzsStorageSettings -Location $global:Location).RetentionPeriodForDeletedStorageAccountsInDays
        $targetDays = $originalDays + 1
        $result = Update-AzsStorageSettings -Location $global:Location -RetentionPeriodForDeletedStorageAccountsInDays $targetDays -Force
        $result  | Should Not Be $null
        $result.RetentionPeriodForDeletedStorageAccountsInDays | Should Be $targetDays
        Update-AzsStorageSettings -Location $global:Location -RetentionPeriodForDeletedStorageAccountsInDays $originalDays -Force
    }
}
