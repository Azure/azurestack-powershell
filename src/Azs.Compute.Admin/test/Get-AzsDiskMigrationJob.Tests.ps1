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

$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsDiskMigrationJob.Recording.json'

$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzsDiskMigrationJob' {
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

    It "TestListDiskMigrationJobs" -Skip:$('TestListDiskMigrationJobs' -in $global:SkippedTests) {
        $global:TestName = 'TestListDiskMigrationJobs'
        
        $jobs = Get-AzsDiskMigrationJob -Location $global:Location
        foreach ($job in $jobs) 
        {
            ValidateDiskMigration -DiskMigration $job
        }
    }

    It "TestGetDiskMigrationJob" -Skip:$('TestGetDiskMigrationJob' -in $global:SkippedTests) {
        $global:TestName = 'TestGetDiskMigrationJob'

        $jobs = Get-AzsDiskMigrationJob -Location $global:Location
        $job1 = Get-AzsDiskMigrationJob -Location $global:Location -Name $($jobs[0].Name.Split("/")[-1])
        $job1 | Should Not Be $null
        $job1.Id | Should Be $jobs[0].Id
        ValidateDiskMigration -DiskMigration $job1
        $job2 = Get-AzsDiskMigrationJob -InputObject $jobs[0]
        $job2 | Should Not Be $null
        $job2.Id | Should Be $jobs[0].Id
        ValidateDiskMigration -DiskMigration $job2
    }
}
