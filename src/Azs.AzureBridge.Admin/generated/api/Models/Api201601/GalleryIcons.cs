namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Extensions;

    /// <summary>Icons for the gallery items.</summary>
    public partial class GalleryIcons :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IGalleryIcons,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IGalleryIconsInternal
    {

        /// <summary>Backing field for <see cref="Hero" /> property.</summary>
        private string _hero;

        /// <summary>The hero (815x290) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string Hero { get => this._hero; set => this._hero = value; }

        /// <summary>Backing field for <see cref="Large" /> property.</summary>
        private string _large;

        /// <summary>The large (115x115) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string Large { get => this._large; set => this._large = value; }

        /// <summary>Backing field for <see cref="Medium" /> property.</summary>
        private string _medium;

        /// <summary>The medium (90x90) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string Medium { get => this._medium; set => this._medium = value; }

        /// <summary>Backing field for <see cref="Small" /> property.</summary>
        private string _small;

        /// <summary>The small (40x40) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string Small { get => this._small; set => this._small = value; }

        /// <summary>Backing field for <see cref="Wide" /> property.</summary>
        private string _wide;

        /// <summary>The wide (255x115) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string Wide { get => this._wide; set => this._wide = value; }

        /// <summary>Creates an new <see cref="GalleryIcons" /> instance.</summary>
        public GalleryIcons()
        {

        }
    }
    /// Icons for the gallery items.
    public partial interface IGalleryIcons :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The hero (815x290) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The hero (815x290) icon relative path.",
        SerializedName = @"hero",
        PossibleTypes = new [] { typeof(string) })]
        string Hero { get; set; }
        /// <summary>The large (115x115) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The large (115x115) icon relative path.",
        SerializedName = @"large",
        PossibleTypes = new [] { typeof(string) })]
        string Large { get; set; }
        /// <summary>The medium (90x90) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The medium (90x90) icon relative path.",
        SerializedName = @"medium",
        PossibleTypes = new [] { typeof(string) })]
        string Medium { get; set; }
        /// <summary>The small (40x40) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The small (40x40) icon relative path.",
        SerializedName = @"small",
        PossibleTypes = new [] { typeof(string) })]
        string Small { get; set; }
        /// <summary>The wide (255x115) icon relative path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The wide (255x115) icon relative path.",
        SerializedName = @"wide",
        PossibleTypes = new [] { typeof(string) })]
        string Wide { get; set; }

    }
    /// Icons for the gallery items.
    internal partial interface IGalleryIconsInternal

    {
        /// <summary>The hero (815x290) icon relative path.</summary>
        string Hero { get; set; }
        /// <summary>The large (115x115) icon relative path.</summary>
        string Large { get; set; }
        /// <summary>The medium (90x90) icon relative path.</summary>
        string Medium { get; set; }
        /// <summary>The small (40x40) icon relative path.</summary>
        string Small { get; set; }
        /// <summary>The wide (255x115) icon relative path.</summary>
        string Wide { get; set; }

    }
}