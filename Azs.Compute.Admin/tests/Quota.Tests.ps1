$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsComputeQuota.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe "Quota" -Tags @('Quota', 'Azs.Compute.Admin') {

    . $PSScriptRoot\Common.ps1

    BeforeEach {

        function ValidateComputeQuota {
            param(
                [Parameter(Mandatory = $true)]
                $Quota
            )

            $Quota          | Should Not Be $null

            # Resource
            $Quota.Id       | Should Not Be $null
            $Quota.Name     | Should Not Be $null
            $Quota.Type     | Should Not Be $null

            # Subscriber Usage Aggregate
            $Quota.AvailabilitySetCount                 | Should Not Be $null
            $Quota.CoresLimit                           | Should Not Be $null
            $Quota.VirtualMachineCount                  | Should Not Be $null
            $Quota.VmScaleSetCount                      | Should Not Be $null
            $Quota.StandardManagedDiskAndSnapshotSize   | Should Not Be $null
            $Quota.PremiumManagedDiskAndSnapshotSize    | Should Not Be $null
        }

        function AssertSame {
            param(
                $Expected,
                $Found
            )
        }
    }

    AfterEach {
        $global:Client = $null
    }

    It "TestListQuotas" -Skip:$('TestListQuotas' -in $global:SkippedTests) {
        $global:TestName = 'TestListQuotas'
        $quotas = Get-AzsComputeQuota -Location $global:Location

        $quotas | Should Not Be $null
        foreach ($quota in $quotas) {
            ValidateComputeQuota -Quota $quota
        }
    }

    It "TestGetQuota" -Skip:$('TestGetQuota' -in $global:SkippedTests) {
        $global:TestName = 'TestGetQuota'

        $quotas = Get-AzsComputeQuota -Location $global:Location
        $quotas | Should Not Be $null
        foreach ($quota in $quotas) {
            $result = Get-AzsComputeQuota -Location $global:Location -Name $quota.Name

            AssertSame -Expected $quota -Found $result
            break
        }
    }

    It "TestGetAllQuotas" -Skip:$('TestGetAllQuotas' -in $global:SkippedTests) {
        $global:TestName = 'TestGetAllQuotas'
        $quotas = Get-AzsComputeQuota -Location $global:Location
        $quotas | Should Not Be $null
        foreach ($quota in $quotas) {
            $result = Get-AzsComputeQuota -Location $global:Location -Name $quota.Name
            AssertSame -Expected $quota -Found $result
        }
    }

    It "TestCreateQuota" -Skip:$('TestCreateQuota' -in $global:SkippedTests) {
        $global:TestName = 'TestCreateQuota'

        $quotaNamePrefix = "testQuota"
        $data = @(
            @(0, 0, 0, 0, 0, 0, 0),
            @(1, 0, 0, 0, 0, 0, 1),
            @(0, 1, 0, 0, 0, 0, 2),
            @(0, 0, 1, 0, 0, 0, 3),
            @(0, 0, 0, 1, 0, 0, 4),
            @(0, 0, 0, 0, 1, 0, 5),
            @(0, 0, 0, 0, 0, 1, 6),
            @(100, 100, 100, 100 , 100, 100, 7),
            @(1000, 1000, 1000, 1000, 1000, 1000, 8)
        )

        $data | ForEach-Object {
            $name = $quotaNamePrefix + $_[6]
            $quota = New-AzsComputeQuota -Location $global:Location -Name $name -AvailabilitySetCount $_[0] -CoresCount $_[1] -VmScaleSetCount $_[2] -VirtualMachineCount $_[3] -StandardManagedDiskAndSnapshotSize $_[4] -PremiumManagedDiskAndSnapshotSize $_[5]
            $quota.AvailabilitySetCount                 | Should be $_[0]
            $quota.CoresLimit                           | Should be $_[1]
            $quota.VmScaleSetCount                      | Should be $_[2]
            $quota.VirtualMachineCount                  | Should be $_[3]
            $quota.StandardManagedDiskAndSnapshotSize   | Should be $_[4]
            $quota.PremiumManagedDiskAndSnapshotSize    | Should be $_[5]
        }

        $data | ForEach-Object {
            $name = $quotaNamePrefix + $_[6]
            Remove-AzsComputeQuota -Location $global:Location -Name $name
        }

    }

    It "TestCreateQuotaWithAlias" -Skip:$('TestCreateQuotaWithAlias' -in $global:SkippedTests) {
        $global:TestName = 'TestCreateQuota'

        $quotaNamePrefix = "testQuota"
        $data = @(
            @(0, 0, 0, 0, 0, 0, 0),
            @(1, 0, 0, 0, 0, 0, 1),
            @(0, 1, 0, 0, 0, 0, 2),
            @(0, 0, 1, 0, 0, 0, 3),
            @(0, 0, 0, 1, 0, 0, 4),
            @(0, 0, 0, 0, 1, 0, 5),
            @(0, 0, 0, 0, 0, 1, 6),
            @(100, 100, 100, 100 , 100, 100, 7),
            @(1000, 1000, 1000, 1000, 1000, 1000, 8)
        )

        # Retry the same tests above with the alias, to ensure that usage of alias is not broken
        $data | ForEach-Object {
            $name = $quotaNamePrefix + $_[6]
            $quota = New-AzsComputeQuota -Location $global:Location -Name $name -AvailabilitySetCount $_[0] -CoresLimit $_[1] -VmScaleSetCount $_[2] -VirtualMachineCount $_[3] -StandardManagedDiskAndSnapshotSize $_[4] -PremiumManagedDiskAndSnapshotSize $_[5]
            $quota.AvailabilitySetCount                 | Should be $_[0]
            $quota.CoresLimit                           | Should be $_[1]
            $quota.VmScaleSetCount                      | Should be $_[2]
            $quota.VirtualMachineCount                  | Should be $_[3]
            $quota.StandardManagedDiskAndSnapshotSize   | Should be $_[4]
            $quota.PremiumManagedDiskAndSnapshotSize    | Should be $_[5]
        }

        $data | ForEach-Object {
            $name = $quotaNamePrefix + $_[6]
            Remove-AzsComputeQuota -Location $global:Location -Name $name
        }

    }

    # Tests wth Invalid data
    It "TestCreateInvalidQuota" -Skip:$('TestCreateInvalidQuota' -in $global:SkippedTests) {
        $global:TestName = 'TestCreateInvalidQuota'

        $data = @(
            @(-1, 1, 1, 1, 1, 1),
            @(1, -1, 1, 1, 1, 1),
            @(1, 1, -1, 1, 1, 1),
            @(1, 1, 1, -1, 1, 1),
            @(1, 1, 1, 1, -1, 1),
            @(1, 1, 1, 1, 1, -1),
            @(-1, 0, 0, 0, 0, 0),
            @( 0, -1, 0, 0, 0, 0),
            @( 0, 0, -1, 0, 0, 0),
            @( 0, 0, 0, -1, 0, 0),
            @( 0, 0, 0, 0, -1, 0),
            @( 0, 0, 0, 0, 0, -1),
            @(-1, -1, -1, -1, -1, -1)
        )

        $name = "myQuota"
        $data | ForEach-Object {
            {
                New-AzsComputeQuota -Location $global:Location -Name $name -AvailabilitySetCount $_[0] -CoresCount $_[1] -VmScaleSetCount $_[2] -VirtualMachineCount $_[3] -StandardManagedDiskAndSnapshotSize $_[4] -PremiumManagedDiskAndSnapshotSize $_[5]
            } | Should Throw
        }
    }

    # Apparently CRP will default to a place even if it does not exist
    It "TestListInvalidLocation" -Skip:$('TestListInvalidLocation' -in $global:SkippedTests) {
        $global:TestName = 'TestListInvalidLocation'
        $quotas = Get-AzsComputeQuota -Location "thisisnotarealplace"
        $quotas | Should Be $null
    }

    It "TestDeleteNonExistingQuota" -Skip:$('TestDeleteNonExistingQuota' -in $global:SkippedTests) {
        $global:TestName = 'TestDeleteNonExistingQuota'

        {Remove-AzsComputeQuota -Location $global:Location -Name "thisdoesnotexistandifitdoesoops" -ErrorAction Stop} | Should Throw "Operation returned an invalid status code 'NotFound'"
    }

    It "TestCreateQuotaOnInvalidLocation" -Skip:$('TestCreateQuotaOnInvalidLocation' -in $global:SkippedTests) {
        $global:TestName = 'TestCreateQuotaOnInvalidLocation'

        $quotaNamePrefix = "testQuota"
        $invalidLocation = "thislocationdoesnotexist"

        $data = @(
            @( 0, 0, 0, 0, 0, 0, 0 ),
            @( 1, 0, 0, 0, 0, 0, 1 ),
            @( 0, 1, 0, 0, 0, 0, 2 ),
            @( 0, 0, 1, 0, 0, 0, 3 ),
            @( 0, 0, 0, 1, 0, 0, 4 ),
            @( 0, 0, 0, 0, 1, 0, 5 ),
            @( 0, 0, 0, 0, 0, 1, 6 ),
            @( 100, 100, 100, 100 , 100, 100, 7 ),
            @( 1000, 1000, 1000, 1000, 1000, 1000, 8 )
        )
        $data | ForEach-Object {
            $name = $quotaNamePrefix + $_[6]
            New-AzsComputeQuota -Location $invalidLocation -Name $name -AvailabilitySetCount $_[0] -CoresCount $_[1] -VmScaleSetCount $_[2] -VirtualMachineCount $_[3] -StandardManagedDiskAndSnapshotSize $_[4] -PremiumManagedDiskAndSnapshotSize $_[5] | Should be $null
            Get-AzsComputeQuota -Location $invalidLocation -Name $quota.Name | Should be $null

        }

        $data | ForEach-Object {
            $name = $quotaNamePrefix + $_[4]
            Get-AzsComputeQuota -Location | Where-Object { $_.Name -eq $name} | Should be $null
        }
    }

    It "TestQuotaCreateUpdateDelete" -Skip:$('TestQuotaCreateUpdateDelete' -in $global:SkippedTests) {
        $global:TestName = 'TestQuotaCreateUpdateDelete'


        @(
            @(1, 1, 1, 1, 1, 1),
            @(1, 1, 1, 2, 1, 1),
            @(2, 1, 1, 2, 1, 1),
            @(2, 1, 2, 2, 1, 1)
        ) | ForEach-Object {
            $quota = Set-AzsComputeQuota `
                -Location $global:Location `
                -Name "testQuotaCreateUpdateDelete" `
                -AvailabilitySetCount $_[0] `
                -CoresCount $_[1] `
                -VmScaleSetCount $_[2] `
                -VirtualMachineCount $_[3] `
                -StandardManagedDiskAndSnapshotSize $_[4] `
                -PremiumManagedDiskAndSnapshotSize $_[5]

            $quota | Should not be $null
            $quota.AvailabilitySetCount | Should be $_[0]
            $quota.CoresLimit | Should be $_[1]
            $quota.VmScaleSetCount | Should be $_[2]
            $quota.VirtualMachineCount | Should be $_[3]
            $quota.StandardManagedDiskAndSnapshotSize | Should be $_[4]
            $quota.PremiumManagedDiskAndSnapshotSize | Should be $_[5]
        }
        $quota | Remove-AzsComputeQuota
    }

    It "TestQuotaCreateUpdateDeleteWithAlias" -Skip:$('TestQuotaCreateUpdateDeleteWithAlias' -in $global:SkippedTests) {
        $global:TestName = 'TestQuotaCreateUpdateDelete'

        @(
            @(1, 1, 1, 1, 1, 1),
            @(1, 1, 1, 2, 1, 1),
            @(2, 1, 1, 2, 1, 1),
            @(2, 1, 2, 2, 1, 1)
        ) | ForEach-Object {
            $quota = Set-AzsComputeQuota `
                -Location $global:Location `
                -Name "testQuotaCreateUpdateDelete" `
                -AvailabilitySetCount $_[0] `
                -CoresLimit $_[1] `
                -VmScaleSetCount $_[2] `
                -VirtualMachineCount $_[3] `
                -StandardManagedDiskAndSnapshotSize $_[4] `
                -PremiumManagedDiskAndSnapshotSize $_[5]

            $quota | Should not be $null
            $quota.AvailabilitySetCount | Should be $_[0]
            $quota.CoresLimit | Should be $_[1]
            $quota.VmScaleSetCount | Should be $_[2]
            $quota.VirtualMachineCount | Should be $_[3]
            $quota.StandardManagedDiskAndSnapshotSize | Should be $_[4]
            $quota.PremiumManagedDiskAndSnapshotSize | Should be $_[5]
        }
        $quota | Remove-AzsComputeQuota -Force
    }
}
