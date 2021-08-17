namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Extensions;

    /// <summary>Pageable list of supported operations.</summary>
    public partial class OperationList :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationList,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperationListInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperation[] _value;

        /// <summary>List of operations</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperation[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="OperationList" /> instance.</summary>
        public OperationList()
        {

        }
    }
    /// Pageable list of supported operations.
    public partial interface IOperationList :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IJsonSerializable
    {
        /// <summary>List of operations</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of operations",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperation) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperation[] Value { get; set; }

    }
    /// Pageable list of supported operations.
    internal partial interface IOperationListInternal

    {
        /// <summary>List of operations</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IOperation[] Value { get; set; }

    }
}