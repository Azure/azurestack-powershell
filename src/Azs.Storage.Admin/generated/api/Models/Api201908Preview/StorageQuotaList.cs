namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Extensions;

    /// <summary>Pageable list of storage quotas.</summary>
    public partial class StorageQuotaList :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuotaList,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuotaListInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuota[] _value;

        /// <summary>List of storage quotas.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuota[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="StorageQuotaList" /> instance.</summary>
        public StorageQuotaList()
        {

        }
    }
    /// Pageable list of storage quotas.
    public partial interface IStorageQuotaList :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IJsonSerializable
    {
        /// <summary>List of storage quotas.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of storage quotas.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuota) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuota[] Value { get; set; }

    }
    /// Pageable list of storage quotas.
    internal partial interface IStorageQuotaListInternal

    {
        /// <summary>List of storage quotas.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuota[] Value { get; set; }

    }
}