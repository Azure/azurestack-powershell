$loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
if (-Not (Test-Path -Path $loadEnvPath)) {
    $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
}
. ($loadEnvPath)
$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzsVirtualNetworkGatewayConnection.Recording.json'
$currentPath = $PSScriptRoot
while(-not $mockingPath) {
    $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
    $currentPath = Split-Path -Path $currentPath -Parent
}
. ($mockingPath | Select-Object -First 1).FullName

Describe 'Get-AzsVirtualNetworkGatewayConnection' {

    . $PSScriptRoot\Common.ps1

    BeforeEach {

        function ValidateConnectionState {
            param(
                $state
            )

            $state | Should Not Be $null
            $state.ConnectionStateStatus | Should Not Be $null
            $state.ProvisioningState | Should Not Be $null
            $state.ConnectionStateActiveGateway | Should Not Be $null

            if ($state.ConnectionStateStatus -eq "Disconnected")
            {
                $state.ConnectionErrorDetailedInfo | Should Not Be $null
                $state.ConnectionErrorStatus | Should Not Be $null
                $state.ConnectionErrorLastUpdatedTime | Should Not Be $null
            }
        }

        function ValidateResourceInfo {
            param(
                $resource
            )

            $resource | Should Not Be $null
            $resource.CapacityReserved | Should Not Be $null
            $resource.Id | Should Not Be $null
            $resource.LocalNetworkGatewayIPAddress | Should Not Be $null
            $resource.LocalNetworkGatewayName | Should Not Be $null
            $resource.VirtualNetworkGatewayIPAddress | Should Not Be $null
            $resource.VirtualNetworkGatewayName | Should Not Be $null
            $resource.Name | Should Not Be $null
            $resource.ResourceGroup | Should Not Be $null
            $resource.Sku | Should Not Be $null
            $resource.SubscriptionId | Should Not Be $null
            $resource.TotalStampCapacity | Should Not Be $null
        }
    }

    AfterEach {
        $global:Client = $null
    }

    It "TestGetAllVirtualNetworkGatewayConnections" -Skip:$('TestGetAllVirtualNetworkGatewayConnections' -in $global:SkippedTests) {
        $global:TestName = "TestGetAllVirtualNetworkGatewayConnections"

        $connections = Get-AzSVirtualNetworkGatewayConnection
        foreach ($conn in $connections) {
            ValidateResourceInfo $conn
            ValidateConnectionState $conn
        }
    }

    It "TestGetAllVirtualNetworkGatewayConnectionsOData" -Skip:$("TestGetAllVirtualNetworkGatewayConnectionsOData" -in $global:SkippedTests) {
        $global:TestName = "TestGetAllVirtualNetworkGatewayConnectionsOData"
        $connections = Get-AzSVirtualNetworkGatewayConnection -Top 1
        foreach ($conn in $connections) {
            ValidateResourceInfo $conn
            ValidateConnectionState $conn
        }
    }
}
