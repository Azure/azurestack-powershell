namespace Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Extensions;

    /// <summary>List of gallery items.</summary>
    public partial class GalleryItemList :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemList,
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemListInternal
    {

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItem[] _value;

        /// <summary>List of gallery items.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItem[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="GalleryItemList" /> instance.</summary>
        public GalleryItemList()
        {

        }
    }
    /// List of gallery items.
    public partial interface IGalleryItemList :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IJsonSerializable
    {
        /// <summary>List of gallery items.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of gallery items.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItem) })]
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItem[] Value { get; set; }

    }
    /// List of gallery items.
    internal partial interface IGalleryItemListInternal

    {
        /// <summary>List of gallery items.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItem[] Value { get; set; }

    }
}