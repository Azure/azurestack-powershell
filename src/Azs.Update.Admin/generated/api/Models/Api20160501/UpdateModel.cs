namespace Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Extensions;

    /// <summary>Properties of an update.</summary>
    public partial class UpdateModel :
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModel,
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateModelInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Name of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="InstalledDate" /> property.</summary>
        private global::System.DateTime? _installedDate;

        /// <summary>Date update was installed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? InstalledDate { get => this._installedDate; set => this._installedDate = value; }

        /// <summary>Backing field for <see cref="KbLink" /> property.</summary>
        private string _kbLink;

        /// <summary>Link to the KB article about the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public string KbLink { get => this._kbLink; set => this._kbLink = value; }

        /// <summary>Backing field for <see cref="MinOemVersionRequired" /> property.</summary>
        private string _minOemVersionRequired;

        /// <summary>The minimum OEM version required to install.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public string MinOemVersionRequired { get => this._minOemVersionRequired; set => this._minOemVersionRequired = value; }

        /// <summary>Backing field for <see cref="MinVersionRequired" /> property.</summary>
        private string _minVersionRequired;

        /// <summary>The minimum version required to install.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public string MinVersionRequired { get => this._minVersionRequired; set => this._minVersionRequired = value; }

        /// <summary>Backing field for <see cref="OemVersion" /> property.</summary>
        private string _oemVersion;

        /// <summary>OEM version of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public string OemVersion { get => this._oemVersion; set => this._oemVersion = value; }

        /// <summary>Backing field for <see cref="PackagePath" /> property.</summary>
        private string _packagePath;

        /// <summary>Path to the update package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public string PackagePath { get => this._packagePath; set => this._packagePath = value; }

        /// <summary>Backing field for <see cref="PackageSizeInMb" /> property.</summary>
        private long? _packageSizeInMb;

        /// <summary>Size of update package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public long? PackageSizeInMb { get => this._packageSizeInMb; set => this._packageSizeInMb = value; }

        /// <summary>Backing field for <see cref="Publisher" /> property.</summary>
        private string _publisher;

        /// <summary>Publisher of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public string Publisher { get => this._publisher; set => this._publisher = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateState? _state;

        /// <summary>Current state of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateState? State { get => this._state; set => this._state = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>Version of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="UpdateModel" /> instance.</summary>
        public UpdateModel()
        {

        }
    }
    /// Properties of an update.
    public partial interface IUpdateModel :
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Description of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of the update.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Name of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the update.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>Date update was installed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Date update was installed.",
        SerializedName = @"installedDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? InstalledDate { get; set; }
        /// <summary>Link to the KB article about the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Link to the KB article about the update.",
        SerializedName = @"kbLink",
        PossibleTypes = new [] { typeof(string) })]
        string KbLink { get; set; }
        /// <summary>The minimum OEM version required to install.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The minimum OEM version required to install.",
        SerializedName = @"minOemVersionRequired",
        PossibleTypes = new [] { typeof(string) })]
        string MinOemVersionRequired { get; set; }
        /// <summary>The minimum version required to install.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The minimum version required to install.",
        SerializedName = @"minVersionRequired",
        PossibleTypes = new [] { typeof(string) })]
        string MinVersionRequired { get; set; }
        /// <summary>OEM version of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"OEM version of the update.",
        SerializedName = @"oemVersion",
        PossibleTypes = new [] { typeof(string) })]
        string OemVersion { get; set; }
        /// <summary>Path to the update package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Path to the update package.",
        SerializedName = @"packagePath",
        PossibleTypes = new [] { typeof(string) })]
        string PackagePath { get; set; }
        /// <summary>Size of update package.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Size of update package.",
        SerializedName = @"packageSizeInMb",
        PossibleTypes = new [] { typeof(long) })]
        long? PackageSizeInMb { get; set; }
        /// <summary>Publisher of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Publisher of the update.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string Publisher { get; set; }
        /// <summary>Current state of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Current state of the update.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateState) })]
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateState? State { get; set; }
        /// <summary>Version of the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Version of the update.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// Properties of an update.
    internal partial interface IUpdateModelInternal

    {
        /// <summary>Description of the update.</summary>
        string Description { get; set; }
        /// <summary>Name of the update.</summary>
        string DisplayName { get; set; }
        /// <summary>Date update was installed.</summary>
        global::System.DateTime? InstalledDate { get; set; }
        /// <summary>Link to the KB article about the update.</summary>
        string KbLink { get; set; }
        /// <summary>The minimum OEM version required to install.</summary>
        string MinOemVersionRequired { get; set; }
        /// <summary>The minimum version required to install.</summary>
        string MinVersionRequired { get; set; }
        /// <summary>OEM version of the update.</summary>
        string OemVersion { get; set; }
        /// <summary>Path to the update package.</summary>
        string PackagePath { get; set; }
        /// <summary>Size of update package.</summary>
        long? PackageSizeInMb { get; set; }
        /// <summary>Publisher of the update.</summary>
        string Publisher { get; set; }
        /// <summary>Current state of the update.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.UpdateState? State { get; set; }
        /// <summary>Version of the update.</summary>
        string Version { get; set; }

    }
}