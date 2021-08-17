namespace Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Extensions;

    /// <summary>Location of gallery item payload.</summary>
    public partial class GalleryItemUriPayload :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemUriPayload,
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemUriPayloadInternal
    {

        /// <summary>Backing field for <see cref="GalleryItemUri" /> property.</summary>
        private string _galleryItemUri;

        /// <summary>URI for your gallery package that has already been uploaded online.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string GalleryItemUri { get => this._galleryItemUri; set => this._galleryItemUri = value; }

        /// <summary>Creates an new <see cref="GalleryItemUriPayload" /> instance.</summary>
        public GalleryItemUriPayload()
        {

        }
    }
    /// Location of gallery item payload.
    public partial interface IGalleryItemUriPayload :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IJsonSerializable
    {
        /// <summary>URI for your gallery package that has already been uploaded online.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI for your gallery package that has already been uploaded online.",
        SerializedName = @"galleryItemUri",
        PossibleTypes = new [] { typeof(string) })]
        string GalleryItemUri { get; set; }

    }
    /// Location of gallery item payload.
    internal partial interface IGalleryItemUriPayloadInternal

    {
        /// <summary>URI for your gallery package that has already been uploaded online.</summary>
        string GalleryItemUri { get; set; }

    }
}