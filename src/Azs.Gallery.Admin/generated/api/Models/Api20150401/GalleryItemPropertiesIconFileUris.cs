namespace Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Extensions;

    /// <summary>URIs to icon files.</summary>
    public partial class GalleryItemPropertiesIconFileUris :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesIconFileUris,
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IGalleryItemPropertiesIconFileUrisInternal
    {

        /// <summary>Backing field for <see cref="Hero" /> property.</summary>
        private string _hero;

        /// <summary>URI to the hero icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string Hero { get => this._hero; set => this._hero = value; }

        /// <summary>Backing field for <see cref="Large" /> property.</summary>
        private string _large;

        /// <summary>URI to the large icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string Large { get => this._large; set => this._large = value; }

        /// <summary>Backing field for <see cref="Medium" /> property.</summary>
        private string _medium;

        /// <summary>URI to the medium icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string Medium { get => this._medium; set => this._medium = value; }

        /// <summary>Backing field for <see cref="Small" /> property.</summary>
        private string _small;

        /// <summary>URI to the small icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string Small { get => this._small; set => this._small = value; }

        /// <summary>Backing field for <see cref="Wide" /> property.</summary>
        private string _wide;

        /// <summary>URI to the wide icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string Wide { get => this._wide; set => this._wide = value; }

        /// <summary>Creates an new <see cref="GalleryItemPropertiesIconFileUris" /> instance.</summary>
        public GalleryItemPropertiesIconFileUris()
        {

        }
    }
    /// URIs to icon files.
    public partial interface IGalleryItemPropertiesIconFileUris :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IJsonSerializable
    {
        /// <summary>URI to the hero icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the hero icon.",
        SerializedName = @"hero",
        PossibleTypes = new [] { typeof(string) })]
        string Hero { get; set; }
        /// <summary>URI to the large icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the large icon.",
        SerializedName = @"large",
        PossibleTypes = new [] { typeof(string) })]
        string Large { get; set; }
        /// <summary>URI to the medium icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the medium icon.",
        SerializedName = @"medium",
        PossibleTypes = new [] { typeof(string) })]
        string Medium { get; set; }
        /// <summary>URI to the small icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the small icon.",
        SerializedName = @"small",
        PossibleTypes = new [] { typeof(string) })]
        string Small { get; set; }
        /// <summary>URI to the wide icon.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the wide icon.",
        SerializedName = @"wide",
        PossibleTypes = new [] { typeof(string) })]
        string Wide { get; set; }

    }
    /// URIs to icon files.
    internal partial interface IGalleryItemPropertiesIconFileUrisInternal

    {
        /// <summary>URI to the hero icon.</summary>
        string Hero { get; set; }
        /// <summary>URI to the large icon.</summary>
        string Large { get; set; }
        /// <summary>URI to the medium icon.</summary>
        string Medium { get; set; }
        /// <summary>URI to the small icon.</summary>
        string Small { get; set; }
        /// <summary>URI to the wide icon.</summary>
        string Wide { get; set; }

    }
}