namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Extensions;

    /// <summary>Pageable list of storage accounts.</summary>
    public partial class StorageAccountList :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountList,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountListInternal
    {

        /// <summary>Internal Acessors for OdataNextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountListInternal.OdataNextLink { get => this._odataNextLink; set { {_odataNextLink = value;} } }

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccount[] Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccountListInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="OdataNextLink" /> property.</summary>
        private string _odataNextLink;

        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string OdataNextLink { get => this._odataNextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccount[] _value;

        /// <summary>List of storage accounts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccount[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="StorageAccountList" /> instance.</summary>
        public StorageAccountList()
        {

        }
    }
    /// Pageable list of storage accounts.
    public partial interface IStorageAccountList :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IJsonSerializable
    {
        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"URI to the next page.",
        SerializedName = @"@odata.nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string OdataNextLink { get;  }
        /// <summary>List of storage accounts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of storage accounts.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccount) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccount[] Value { get;  }

    }
    /// Pageable list of storage accounts.
    internal partial interface IStorageAccountListInternal

    {
        /// <summary>URI to the next page.</summary>
        string OdataNextLink { get; set; }
        /// <summary>List of storage accounts.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageAccount[] Value { get; set; }

    }
}