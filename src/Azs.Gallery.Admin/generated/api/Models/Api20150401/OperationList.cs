namespace Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Extensions;

    /// <summary>List of operations.</summary>
    public partial class OperationList :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOperationList,
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOperationListInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOperation[] _value;

        /// <summary>List of operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOperation[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="OperationList" /> instance.</summary>
        public OperationList()
        {

        }
    }
    /// List of operations.
    public partial interface IOperationList :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IJsonSerializable
    {
        /// <summary>List of operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of operations.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOperation) })]
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOperation[] Value { get; set; }

    }
    /// List of operations.
    internal partial interface IOperationListInternal

    {
        /// <summary>List of operations.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IOperation[] Value { get; set; }

    }
}