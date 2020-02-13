$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsDiskMigrationJob.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

$Global:UseInstalled = $UseInstalled
$global:RunRaw = $RunRaw

$global:Location = "northwest"
$global:TestName = ""
$global:TargetShare = "\\SU1FileServer.azurestack.local\SU1_ObjStore\"


Describe 'Get-AzsDiskMigrationJob' {
    BeforeEach {

        . $PSScriptRoot\Common.ps1

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

    It "TestDiskMigration" {
        $global:TestName = 'TestDiskMigration'

        $disks = Get-AzsDisk -Location $global:Location
        $disks | Should Not Be $null
        $toMigrationDisks = @()
        foreach($disk in $disks)
        {
            if ($toMigrationDisks.Count -lt 3)
            {
                $toMigrationDisks +=$disk;
            }
            else
            {
                break;
            }
        }
        $migrationId = "ba0644a4-c2ed-4e3c-a167-089a32865297"; # this should be the same as session Records

        $migration = Start-AzsDiskMigrationJob -Location $global:Location -Name $migrationId -TargetShare $global:TargetShare -Disks $toMigrationDisks
        ValidateDiskMigration -DiskMigration $migration

        $migration = Stop-AzsDiskMigrationJob -Location $global:Location -Name $migration.MigrationId
        ValidateDiskMigration -DiskMigration $migration

        $migrationFromGet = Get-AzsDiskMigrationJob -Location $global:Location -Name $migrationId
        ValidateDiskMigration -DiskMigration $migrationFromGet

        $migrationList = Get-AzsDiskMigrationJob -Location $global:Location
        $migrationList | %{ValidateDiskMigration -DiskMigration $_ }

        $migrationSucceededList = Get-AzsDiskMigrationJob -Location $global:Location  -Status "Succeeded"
        $migrationSucceededList | %{ValidateDiskMigration -DiskMigration $_ }
    }

    It "TestDiskMigrationInvalidInput" {
        $global:TestName = 'TestDiskMigrationInvalidInput'

        $InvalidtTargetShare = "\\SU1FileServer.azurestack.local\SU1_ObjStore_Invalid\"
        $disks = @()
        $disks += Get-AzsDisk -Location $global:Location
        $disks | Should Not Be $null
        if($disks.Count -gt 0)
        {
            $toMigrationDisks = @($disks[0])
            $migrationId = "A50E9E6B-CFC2-4BC7-956B-0F7C35035DF2"; # This guid should be the same as the ones in sessionRecord
            {Start-AzsDiskMigrationJob -Location $global:Location -Name $migrationId -TargetShare $InvalidtTargetShare -Disks $toMigrationDisks -ErrorAction Stop} | Should throw
            {Get-AzsDiskMigrationJob -Location $global:Location -Name $migrationId -ErrorAction Stop }| Should throw
        }
    }
}

