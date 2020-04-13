### Example 1:
```powershell
PS C:\> Stop-AzsDiskMigrationJob -Name TestJob

CreationTime : 2/26/2020 11:06:40 AM
EndTime      : 2/26/2020 11:07:24 AM
Id           : /subscriptions/627fecef-520e-4c18-94e0-8f0665ba86a7/providers/Microsoft.Compute.Admin/locations/redmond/diskmigrati
               onjobs/TestJob
Location     : redmond
MigrationId  : TestJob
Name         : redmond/TestJob
StartTime    : 2/26/2020 11:06:40 AM
Status       : Canceled
Subtask      : {47774498-6bc7-4ce2-98ca-738739ded2fc, b09ac623-f71d-480c-98bc-88fa3f603f2c}
TargetShare  : \\SU1FileServer.s31r1801.masd.stbtest.microsoft.com\SU1_ObjStore_4
Type         : Microsoft.Compute.Admin/locations/diskmigrationjobs
```

Cancel a managed disk migration job.
