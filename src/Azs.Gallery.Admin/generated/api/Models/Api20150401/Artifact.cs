namespace Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Extensions;

    /// <summary>Represents gallery item artifacts.</summary>
    public partial class Artifact :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IArtifact,
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IArtifactInternal
    {

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the artifact.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Support.ArtifactType? _type;

        /// <summary>Artifact type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Support.ArtifactType? Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="Uri" /> property.</summary>
        private string _uri;

        /// <summary>URI to the artifact.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.PropertyOrigin.Owned)]
        public string Uri { get => this._uri; set => this._uri = value; }

        /// <summary>Creates an new <see cref="Artifact" /> instance.</summary>
        public Artifact()
        {

        }
    }
    /// Represents gallery item artifacts.
    public partial interface IArtifact :
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Name of the artifact.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the artifact.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Artifact type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Artifact type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Support.ArtifactType) })]
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Support.ArtifactType? Type { get; set; }
        /// <summary>URI to the artifact.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the artifact.",
        SerializedName = @"uri",
        PossibleTypes = new [] { typeof(string) })]
        string Uri { get; set; }

    }
    /// Represents gallery item artifacts.
    internal partial interface IArtifactInternal

    {
        /// <summary>Name of the artifact.</summary>
        string Name { get; set; }
        /// <summary>Artifact type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Support.ArtifactType? Type { get; set; }
        /// <summary>URI to the artifact.</summary>
        string Uri { get; set; }

    }
}