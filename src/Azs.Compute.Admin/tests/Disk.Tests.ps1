$TestRecordingFile = Join-Path $PSScriptRoot 'Disk.Tests.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

$Global:UseInstalled = $UseInstalled
$global:RunRaw = $RunRaw

#. $PSScriptRoot\CommonModules.ps1

$global:Location = "northwest"
$global:TestName = ""

Describe 'Get-AzsDisk' {
    BeforeEach {

        . $PSScriptRoot\Common.ps1

        function ValidateDisk {
            param(
                [Parameter(Mandatory = $true)]
                $Disk
            )

            $Disk | Should Not Be $null
            $Disk.Id | Should Not Be $null
            $Disk.Type | Should Not Be $null
            $Disk.Name | Should Not Be $null
            $Disk.ActualSizeGB | Should Not Be $null
            $Disk.ProvisionSizeGB | Should Not Be $null
            $Disk.DiskSku | Should Not Be $null
            $Disk.DiskType | Should Not Be $null
            $Disk.SharePath | Should Not Be $null
            $Disk.Status | Should Not Be $null
            $Disk.UserResourceId | Should Not Be $null
            $Disk.Location | Should Not Be $null
            $Disk.DiskId | Should Not Be $null
        }

        function ValidateDisksTheSame {
            param(
                [Parameter(Mandatory = $true)]
                $DisksRight,
                [Parameter(Mandatory = $true)]
                $DisksLeft
            )
            $DisksRight | Should Not Be $null
            $DisksLeft | Should Not Be $null
            $DisksRight.Count -eq $DisksLeft.Count | Should Be $true

            $DisksRight | % {CheckDisksInList -List $DisksLeft -Disk $_ | Should Be $true}
        }

        function CheckDisksInList {
            param(
                [Parameter(Mandatory = $true)]
                $List,
                [Parameter(Mandatory = $true)]
                $Disk
            )
            $List | Should Not Be $null
            $Disk | Should Not Be $null

            $diskInList = $List | ?{$_.UserResourceId.Equals($Disk.UserResourceId)}
            if($diskInList)
            {
                $true
            }
            else
            {
                $false
            }
        }

        function ValidateDiskTheSame {
            param(
                [Parameter(Mandatory = $true)]
                $DiskRight,
                [Parameter(Mandatory = $true)]
                $DiskLeft
            )
            $DiskRight | Should Not Be $null
            $DiskLeft | Should Not Be $null

            $DiskLeft.Id -eq $DiskRight.Id | Should Be $true
        }
    }

    It "TestListDisks" {
        $global:TestName = 'TestListDisks'

        $disks = Get-AzsDisk -Location $global:Location

        $disks | Should Not Be $null
        foreach ($disk in $disks) {
            ValidateDisk -Disk $disk
        }
        if($disks.Count -gt 0)
        {
            $firstDisk = $disks[0]
            $tenantSubscriptionId = $($firstDisk.UserResourceId.Split("/", [System.StringSplitOptions]::RemoveEmptyEntries))[1]
            $disksForSubscription = Get-AzsDisk -Location $global:Location -UserSubscriptionId $tenantSubscriptionId
            ValidateDisksTheSame -DisksRight $($disks | ?{$_.UserResourceId.Contains($tenantSubscriptionId)}) -DisksLeft $disksForSubscription

            $disksForStatus = Get-AzsDisk -Location $global:Location -Status $firstDisk.Status
            ValidateDisksTheSame -DisksRight $($disks | ?{$_.Status.Equals($firstDisk.Status)}) -DisksLeft $disksForStatus

            $disksForShare = Get-AzsDisk -Location $global:Location -SharePath $firstDisk.SharePath
            ValidateDisksTheSame -DisksRight $($disks | ?{$_.SharePath.Equals($firstDisk.SharePath)}) -DisksLeft $disksForShare

            if ($disks.Count -ge 2)
            {
                $disksWithCountAndStart = Get-AzsDisk -Location $global:Location -Start 1 -Count 1
                ValidateDisksTheSame -DisksRight @($disks[1]) -DisksLeft @($disksWithCountAndStart)
            }
        }
    }

    It "TestGetDisk" {
        $global:TestName = 'TestGetDisk'

        $disks = Get-AzsDisk -Location $global:Location

        $disks | Should Not Be $null
        foreach ($disk in $disks) {
            ValidateDisk -Disk $disk
        }
        if($disks.Count -gt 0)
        {
            $firstDisk = $disks[0]
            $diskFromServer = Get-AzsDisk -Location $global:Location -Name $firstDisk.DiskId
            ValidateDiskTheSame -DiskRight $firstDisk -DiskLeft $diskFromServer
        }
    }

    It "TestGetDiskInvalid" {
        $global:TestName = 'TestGetDiskInvalid'

        {Get-AzsDisk -Location $global:Location -Name "454E5E28-8D5E-41F9-929E-BFF6A7E1A253" -ErrorAction Stop} | Should Throw
    }
}

