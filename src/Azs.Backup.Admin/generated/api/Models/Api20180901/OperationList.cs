namespace Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Extensions;

    /// <summary>List of Operations</summary>
    public partial class OperationList :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IOperationList,
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IOperationListInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IOperationListInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IOperation[] Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IOperationListInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URI to the next page of operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IOperation[] _value;

        /// <summary>Array of operations</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IOperation[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="OperationList" /> instance.</summary>
        public OperationList()
        {

        }
    }
    /// List of Operations
    public partial interface IOperationList :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.IJsonSerializable
    {
        /// <summary>URI to the next page of operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"URI to the next page of operations.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>Array of operations</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Array of operations",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IOperation) })]
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IOperation[] Value { get;  }

    }
    /// List of Operations
    internal partial interface IOperationListInternal

    {
        /// <summary>URI to the next page of operations.</summary>
        string NextLink { get; set; }
        /// <summary>Array of operations</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IOperation[] Value { get; set; }

    }
}