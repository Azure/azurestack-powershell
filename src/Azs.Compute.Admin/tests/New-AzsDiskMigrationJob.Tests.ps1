$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'New-AzsDiskMigrationJob.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'New-AzsDiskMigrationJob' {
    BeforeEach {

        $global:Location = "redmond"

        function ValidateDiskMigration {
            param(
                [Parameter(Mandatory = $true)]
                $DiskMigration
            )

            $DiskMigration | Should Not Be $null
            $DiskMigration.Id | Should Not Be $null
            $DiskMigration.Type | Should Not Be $null
            $DiskMigration.Name | Should Not Be $null
            $DiskMigration.CreationTime | Should Not Be $null
            $DiskMigration.TargetShare | Should Not Be $null
            $DiskMigration.Status | Should Not Be $null
            $DiskMigration.Location | Should Not Be $null
            $DiskMigration.MigrationId | Should Not Be $null
        }
    }

    It "TestNewDiskMigrationJob" -Skip:$('TestNewDiskMigrationJob' -in $global:SkippedTests) {
        $global:TestName = 'TestNewDiskMigrationJob'

        $disks = Get-AzsDisk -Location $global:Location
        $disks | Should Not Be $null
        $toMigrationDisks = @()
        foreach($disk in $disks)
        {
            if ($toMigrationDisks.Count -lt 3)
            {
                $toMigrationDisks += $disk;
            }
            else
            {
                break;
            }
        }

        $jobName = "TestNewDiskMigration";
        $suName = "s-cluster"
        $targetVol = "ObjStore_1"
        $migration = New-AzsDiskMigrationJob -Location $global:Location -Name $jobName -TargetScaleUnit $suName -TargetVolumeLabel $targetVol -Disks $toMigrationDisks
        ValidateDiskMigration -DiskMigration $migration
    }
}