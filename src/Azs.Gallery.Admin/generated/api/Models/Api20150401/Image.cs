namespace Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Extensions;

    /// <summary>Represents an image item.</summary>
    public partial class Image :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IImage,
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IImageInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>ID of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Type of image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="Uri" /> property.</summary>
        private string _uri;

        /// <summary>URI to the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string Uri { get => this._uri; set => this._uri = value; }

        /// <summary>Creates an new <see cref="Image" /> instance.</summary>
        public Image()
        {

        }
    }
    /// Represents an image item.
    public partial interface IImage :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IJsonSerializable
    {
        /// <summary>ID of the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ID of the image.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>Type of image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of image.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }
        /// <summary>URI to the image.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the image.",
        SerializedName = @"uri",
        PossibleTypes = new [] { typeof(string) })]
        string Uri { get; set; }

    }
    /// Represents an image item.
    internal partial interface IImageInternal

    {
        /// <summary>ID of the image.</summary>
        string Id { get; set; }
        /// <summary>Type of image.</summary>
        string Type { get; set; }
        /// <summary>URI to the image.</summary>
        string Uri { get; set; }

    }
}