namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Extensions;

    /// <summary>Undelete storage account information.</summary>
    public partial class UndeleteStorageAccount :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IUndeleteStorageAccount,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IUndeleteStorageAccountInternal
    {

        /// <summary>Backing field for <see cref="AccountId" /> property.</summary>
        private string _accountId;

        /// <summary>The internal wac id for storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string AccountId { get => this._accountId; }

        /// <summary>Internal Acessors for AccountId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IUndeleteStorageAccountInternal.AccountId { get => this._accountId; set { {_accountId = value;} } }

        /// <summary>Internal Acessors for NewAccountName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IUndeleteStorageAccountInternal.NewAccountName { get => this._newAccountName; set { {_newAccountName = value;} } }

        /// <summary>Backing field for <see cref="NewAccountName" /> property.</summary>
        private string _newAccountName;

        /// <summary>The new account name for the restored account if defined.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string NewAccountName { get => this._newAccountName; }

        /// <summary>Creates an new <see cref="UndeleteStorageAccount" /> instance.</summary>
        public UndeleteStorageAccount()
        {

        }
    }
    /// Undelete storage account information.
    public partial interface IUndeleteStorageAccount :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The internal wac id for storage account.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The internal wac id for storage account.",
        SerializedName = @"accountId",
        PossibleTypes = new [] { typeof(string) })]
        string AccountId { get;  }
        /// <summary>The new account name for the restored account if defined.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The new account name for the restored account if defined.",
        SerializedName = @"newAccountName",
        PossibleTypes = new [] { typeof(string) })]
        string NewAccountName { get;  }

    }
    /// Undelete storage account information.
    internal partial interface IUndeleteStorageAccountInternal

    {
        /// <summary>The internal wac id for storage account.</summary>
        string AccountId { get; set; }
        /// <summary>The new account name for the restored account if defined.</summary>
        string NewAccountName { get; set; }

    }
}