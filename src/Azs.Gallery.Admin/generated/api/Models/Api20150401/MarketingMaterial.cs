namespace Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Extensions;

    /// <summary>Marketing material for a gallery item.</summary>
    public partial class MarketingMaterial :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IMarketingMaterial,
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IMarketingMaterialInternal
    {

        /// <summary>Backing field for <see cref="LearnUri" /> property.</summary>
        private string _learnUri;

        /// <summary>URI to educational material.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string LearnUri { get => this._learnUri; set => this._learnUri = value; }

        /// <summary>Backing field for <see cref="Path" /> property.</summary>
        private string _path;

        /// <summary>Path to the marketing site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string Path { get => this._path; set => this._path = value; }

        /// <summary>Creates an new <see cref="MarketingMaterial" /> instance.</summary>
        public MarketingMaterial()
        {

        }
    }
    /// Marketing material for a gallery item.
    public partial interface IMarketingMaterial :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IJsonSerializable
    {
        /// <summary>URI to educational material.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to educational material.",
        SerializedName = @"learnUri",
        PossibleTypes = new [] { typeof(string) })]
        string LearnUri { get; set; }
        /// <summary>Path to the marketing site.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Path to the marketing site.",
        SerializedName = @"path",
        PossibleTypes = new [] { typeof(string) })]
        string Path { get; set; }

    }
    /// Marketing material for a gallery item.
    internal partial interface IMarketingMaterialInternal

    {
        /// <summary>URI to educational material.</summary>
        string LearnUri { get; set; }
        /// <summary>Path to the marketing site.</summary>
        string Path { get; set; }

    }
}