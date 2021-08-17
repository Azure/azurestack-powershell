namespace Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.Extensions;

    /// <summary>List of Operations</summary>
    public partial class OperationList :
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IOperationList,
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IOperationListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URI to the next page of operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IOperation[] _value;

        /// <summary>Array of operations</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IOperation[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="OperationList" /> instance.</summary>
        public OperationList()
        {

        }
    }
    /// List of Operations
    public partial interface IOperationList :
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.IJsonSerializable
    {
        /// <summary>URI to the next page of operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the next page of operations.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Array of operations</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Array of operations",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IOperation) })]
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IOperation[] Value { get; set; }

    }
    /// List of Operations
    internal partial interface IOperationListInternal

    {
        /// <summary>URI to the next page of operations.</summary>
        string NextLink { get; set; }
        /// <summary>Array of operations</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IOperation[] Value { get; set; }

    }
}