### Example 1: Remove-AzsGalleryItem
```powershell
PS C:\> Remove-AzsGalleryItem -Name TestUbuntu.Test.1.0.0

```
Deletes TestUbuntu.Test.1.0.0 from Azure Stack gallery.

### Example 2: Remove-AzsGalleryItem through pipeline
```powershell
PS C:\> Get-AzsGalleryItem -Name TestUbuntu.Test.1.0.0 | Remove-AzsGalleryItem

```
Deletes TestUbuntu.Test.1.0.0 through pipeline.
