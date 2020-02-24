$global:SkippedTests = @(
)

if ($global:TestMode -ne "PlayBack") {
    $global:Location = (Get-AzLocation)[0].Location
    $global:ResourceGroupName = -join("System.",(Get-AzLocation)[0].Location)
}
else {
    $global:Location = "redmond"
    $global:ResourceGroupName = "System.redmond"
}