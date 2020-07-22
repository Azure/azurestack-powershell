. (Join-Path $PSScriptRoot 'loadEnvJson.ps1')

$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsStorageAccount.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzsStorageAccount' {

    . $PSScriptRoot\Common.ps1

    BeforeEach {

        function ValidateStorageAccount {
            param(
                [Parameter(Mandatory = $true)]
                $storageAccount
            )
            # Resource
            $storageAccount								| Should Not Be $null

            # Validate Storage account properties
            $storageAccount.AccountStatus				| Should Not Be $null
            $storageAccount.AccountType					| Should Not Be $null
            $storageAccount.CreationTime				| Should Not Be $null
            $storageAccount.Id							| Should Not Be $null
            $storageAccount.Location					| Should Not Be $null
            $storageAccount.Name						| Should Not Be $null
            $storageAccount.PrimaryEndpoints			| Should Not Be $null
            $storageAccount.PrimaryLocation				| Should Not Be $null
            $storageAccount.ProvisioningState			| Should Not Be $null
            $storageAccount.StatusOfPrimary				| Should Not Be $null
            $storageAccount.TenantResourceGroupName		| Should Not Be $null
            $storageAccount.TenantStorageAccountName	| Should Not Be $null
            $storageAccount.TenantSubscriptionId		| Should Not Be $null
            $storageAccount.TenantViewId				| Should Not Be $null
            $storageAccount.Type						| Should Not Be $null
            $storageAccount.Kind						| Should Not Be $null
            $storageAccount.HealthState					| Should Not Be $null
        }

        function AssertAreEqual {
            param(
                [Parameter(Mandatory = $true)]
                $expected,
                [Parameter(Mandatory = $true)]
                $found
            )
            # Resource
            if ($null -eq $expected) {
                $found												    | Should Be $null
            }
            else {
                $found												    | Should Not Be $null
                # Validate Storage account properties
                $expected.AccountId | Should Be $found.AccountId
                $expected.AccountStatus | Should Be $found.AccountStatus
                $expected.AccountType | Should Be $found.AccountType
            }
        }
    }

    AfterEach {
        $global:Client = $null
    }
    
    It "TestListAllStorageAccounts" -Skip:$('TestListAllStorageAccounts' -in $global:SkippedTests) {
        $global:TestName = 'TestListAllStorageAccounts'

        $storageAccounts = Get-AzsStorageAccount  -Summary:$false
        foreach ($storageAccount in $storageAccounts) {
            ValidateStorageAccount -storageAccount $storageAccount
        }
    }

    It "TestGetStorageAccount" -Skip:$('TestGetStorageAccount' -in $global:SkippedTests) {
        $global:TestName = 'TestGetStorageAccount'

        $storageAccounts = Get-AzsStorageAccount  -Summary:$false
        foreach ($storageAccount in $storageAccounts) {
            $result = Get-AzsStorageAccount -InputObject $storageAccount
            ValidateStorageAccount -storageAccount $result
            AssertAreEqual -expected $storageAccount -found $result
            return
        }
    }

    It "TestGetAllStorageAccounts" -Skip:$('TestGetAllStorageAccounts' -in $global:SkippedTests) {
        $global:TestName = 'TestGetAllStorageAccounts'

        $storageAccounts = Get-AzsStorageAccount  -Summary:$false
        foreach ($storageAccount in $storageAccounts) {
            $result = Get-AzsStorageAccount  -Name $storageAccount.Name
            ValidateStorageAccount -storageAccount $result
            AssertAreEqual -expected $storageAccount -found $result
        }
    }
}
