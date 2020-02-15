### Example 1: Remove a Platform Image
```powershell
PS C:\>Remove-AzsPlatformImage -Location northwest -Offer UbuntuServer -Publisher Microsoft -Sku 16.04-LTS -Version 1.0.0
```

A successful call to remove a platform image will not return any output

### Example 2: Remove a Platform Image the Does Not Exist
```powershell
PS C:\>  Remove-AzsPlatformImage -Location northwest -Offer UbuntuServer -Publisher Microsoft -Sku 16.04-LTS -Version 1.1.6

```

A successful call to remove a platform image that doesn't exist will not return any output

