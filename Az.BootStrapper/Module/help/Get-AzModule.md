---
external help file: Az.Bootstrapper-help.xml
online version: 
schema: 2.0.0
---

# Get-AzModule

## SYNOPSIS
Returns the versions of an Az module that support a given profile.

## SYNTAX

```
Get-AzModule [-Profile] <String> [-Module] <String> [<CommonParameters>]
```

## DESCRIPTION
Returns the versions of an Az module that support a given profile.

## EXAMPLES

### Example 1
```
PS C:\> Get-AzModule -Profile 2019-03-01-hybrid -Module Az.Storage

1.0.4.4
```

The version of the Az.Storage module that supports profile 2019-03-01-hybrid is version 1.0.4.3.

## PARAMETERS

### -Module
The Az module to retrieve the version for.

```yaml
Type: String
Parameter Sets: (All)
Aliases: 

Required: True
Position: 1
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Profile
The profile version to check for the given module.

```yaml
Type: String
Parameter Sets: (All)
Aliases: 
Accepted values: 2019-03-01-hybrid

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### System.String

## NOTES

## RELATED LINKS

