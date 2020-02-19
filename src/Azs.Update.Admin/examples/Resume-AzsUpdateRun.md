### Example 1: Resume-AzsUpdateRun By Name and UpdateName
```powershell
PS C:\> Resume-AzsUpdateRun -UpdateName northwest/Microsoft1.1907.0.10 -Name 45aaeb26-805b-495b-9c8c-d5da5542dbf4

```

Commandlet allows you to rerun a specific failed update run.
Note that there is a requirement that the update version is strictly greater than the current version.

