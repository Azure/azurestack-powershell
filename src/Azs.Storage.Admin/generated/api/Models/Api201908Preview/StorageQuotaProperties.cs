namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Extensions;

    /// <summary>Storage quota properties.</summary>
    public partial class StorageQuotaProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuotaProperties,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuotaPropertiesInternal
    {

        /// <summary>Backing field for <see cref="CapacityInGb" /> property.</summary>
        private int? _capacityInGb;

        /// <summary>Maximum capacity (GB).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public int? CapacityInGb { get => this._capacityInGb; set => this._capacityInGb = value; }

        /// <summary>Backing field for <see cref="NumberOfStorageAccount" /> property.</summary>
        private int? _numberOfStorageAccount;

        /// <summary>Total number of storage accounts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public int? NumberOfStorageAccount { get => this._numberOfStorageAccount; set => this._numberOfStorageAccount = value; }

        /// <summary>Creates an new <see cref="StorageQuotaProperties" /> instance.</summary>
        public StorageQuotaProperties()
        {

        }
    }
    /// Storage quota properties.
    public partial interface IStorageQuotaProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Maximum capacity (GB).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum capacity (GB).",
        SerializedName = @"capacityInGb",
        PossibleTypes = new [] { typeof(int) })]
        int? CapacityInGb { get; set; }
        /// <summary>Total number of storage accounts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Total number of storage accounts.",
        SerializedName = @"numberOfStorageAccounts",
        PossibleTypes = new [] { typeof(int) })]
        int? NumberOfStorageAccount { get; set; }

    }
    /// Storage quota properties.
    internal partial interface IStorageQuotaPropertiesInternal

    {
        /// <summary>Maximum capacity (GB).</summary>
        int? CapacityInGb { get; set; }
        /// <summary>Total number of storage accounts.</summary>
        int? NumberOfStorageAccount { get; set; }

    }
}