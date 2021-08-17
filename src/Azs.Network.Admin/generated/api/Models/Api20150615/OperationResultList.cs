namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Extensions;

    /// <summary>List of Operation Results</summary>
    public partial class OperationResultList :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IOperationResultList,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IOperationResultListInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IOperationResultListInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IOperationResult[] Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IOperationResultListInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URI to the next page of operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IOperationResult[] _value;

        /// <summary>Array of operation results</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IOperationResult[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="OperationResultList" /> instance.</summary>
        public OperationResultList()
        {

        }
    }
    /// List of Operation Results
    public partial interface IOperationResultList :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.IJsonSerializable
    {
        /// <summary>URI to the next page of operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"URI to the next page of operations.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>Array of operation results</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Array of operation results",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IOperationResult) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IOperationResult[] Value { get;  }

    }
    /// List of Operation Results
    internal partial interface IOperationResultListInternal

    {
        /// <summary>URI to the next page of operations.</summary>
        string NextLink { get; set; }
        /// <summary>Array of operation results</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IOperationResult[] Value { get; set; }

    }
}