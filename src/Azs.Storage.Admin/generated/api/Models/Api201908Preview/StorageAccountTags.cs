namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Extensions;

    /// <summary>Resource tags.</summary>
    public partial class StorageAccountTags :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountTags,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountTagsInternal
    {

        /// <summary>Creates an new <see cref="StorageAccountTags" /> instance.</summary>
        public StorageAccountTags()
        {

        }
    }
    /// Resource tags.
    public partial interface IStorageAccountTags :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IAssociativeArray<string>
    {

    }
    /// Resource tags.
    internal partial interface IStorageAccountTagsInternal

    {

    }
}