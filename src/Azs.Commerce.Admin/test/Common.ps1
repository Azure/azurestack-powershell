$global:SkippedTests = @(
)

$global:ReportedStartTime = "2019-12-10T19:00:00.0000000+00:00"
$global:ReportedEndTime = "2019-12-10T20:00:00.0000000+00:00"
$global:AggregationGranularity = "Hourly"

function ValidateAzsSubscriberUsage {
    param(
        [Parameter(Mandatory = $true)]
        $usageRecords
    )

    $usageRecords.Count                         | Should BeGreaterThan 0 
    foreach ($record in $usageRecords)
    {
        $record.UsageStartTime                  | Should Not Be $null
        $record.UsageEndTime                    | Should Not Be $null
        ## Pester v3 does not support BeGreaterOrEqual
        $record.Quantity -ge 0                  | Should Be $true
        $record.MeterId                         | Should Not Be $null
        $record.SubscriptionId                  | Should Not Be $null
        
        # resource data is stored as a JSON inside InstanceData.
        $resource = ($record.InstanceData | ConvertFrom-Json).'Microsoft.Resources'
        $resource                               | Should Not Be $null
        $resource.resourceUri                   | Should Not Be $null
        $resource.location                      | Should Not Be $null
        
        # tags and additionalInfo value can be empty but should still exist
        $resource | Get-Member "tags"           | Should Not Be $null
        $resource | Get-Member "additionalInfo" | Should Not Be $null
    }
}