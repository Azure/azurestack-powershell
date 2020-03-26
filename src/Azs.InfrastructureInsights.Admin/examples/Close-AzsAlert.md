

### Example 1:
```powershell
PS C:\> $alert | Close-AzsAlert  -AlertProperty @{"Name"=$alert.AlertId}
```
Close alert with pipe.

### Example 2:
```powershell
PS C:\> Close-AzsAlert -Name 7f58eb8b-e39f-45d0-8ae7-9920b8f22f5f -user foobar -AlertProperty @{"Name"="7f58eb8b-e39f-45d0-8ae7-9920b8f22f5f"}
```

Close an alert by Name.