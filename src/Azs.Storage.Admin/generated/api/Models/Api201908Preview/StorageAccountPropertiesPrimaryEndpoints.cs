namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Extensions;

    /// <summary>
    /// The URLs that are used to perform a retrieval of a public BLOB, queue, or table object.
    /// </summary>
    public partial class StorageAccountPropertiesPrimaryEndpoints :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesPrimaryEndpoints,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountPropertiesPrimaryEndpointsInternal
    {

        /// <summary>
        /// Creates an new <see cref="StorageAccountPropertiesPrimaryEndpoints" /> instance.
        /// </summary>
        public StorageAccountPropertiesPrimaryEndpoints()
        {

        }
    }
    /// The URLs that are used to perform a retrieval of a public BLOB, queue, or table object.
    public partial interface IStorageAccountPropertiesPrimaryEndpoints :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IAssociativeArray<string>
    {

    }
    /// The URLs that are used to perform a retrieval of a public BLOB, queue, or table object.
    internal partial interface IStorageAccountPropertiesPrimaryEndpointsInternal

    {

    }
}