namespace Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Extensions;

    /// <summary>Group of images.</summary>
    public partial class ImageGroup :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IImageGroup,
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IImageGroupInternal
    {

        /// <summary>Backing field for <see cref="Context" /> property.</summary>
        private string _context;

        /// <summary>Image group identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string Context { get => this._context; set => this._context = value; }

        /// <summary>Backing field for <see cref="Item" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IImage[] _item;

        /// <summary>List of images.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IImage[] Item { get => this._item; }

        /// <summary>Internal Acessors for Item</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IImage[] Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IImageGroupInternal.Item { get => this._item; set { {_item = value;} } }

        /// <summary>Creates an new <see cref="ImageGroup" /> instance.</summary>
        public ImageGroup()
        {

        }
    }
    /// Group of images.
    public partial interface IImageGroup :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Image group identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Image group identifier.",
        SerializedName = @"context",
        PossibleTypes = new [] { typeof(string) })]
        string Context { get; set; }
        /// <summary>List of images.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of images.",
        SerializedName = @"items",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IImage) })]
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IImage[] Item { get;  }

    }
    /// Group of images.
    internal partial interface IImageGroupInternal

    {
        /// <summary>Image group identifier.</summary>
        string Context { get; set; }
        /// <summary>List of images.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IImage[] Item { get; set; }

    }
}