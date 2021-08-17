namespace Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Extensions;

    /// <summary>Model which holds information related to update location.</summary>
    public partial class UpdateLocationModel :
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationModel,
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Models.Api20160501.IUpdateLocationModelInternal
    {

        /// <summary>Backing field for <see cref="CurrentOemVersion" /> property.</summary>
        private string _currentOemVersion;

        /// <summary>Current OEM version of your AzureStack deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public string CurrentOemVersion { get => this._currentOemVersion; set => this._currentOemVersion = value; }

        /// <summary>Backing field for <see cref="CurrentVersion" /> property.</summary>
        private string _currentVersion;

        /// <summary>Current version of your AzureStack deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public string CurrentVersion { get => this._currentVersion; set => this._currentVersion = value; }

        /// <summary>Backing field for <see cref="LastUpdated" /> property.</summary>
        private global::System.DateTime? _lastUpdated;

        /// <summary>Date of last update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? LastUpdated { get => this._lastUpdated; set => this._lastUpdated = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState? _state;

        /// <summary>State with respect to the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState? State { get => this._state; set => this._state = value; }

        /// <summary>Creates an new <see cref="UpdateLocationModel" /> instance.</summary>
        public UpdateLocationModel()
        {

        }
    }
    /// Model which holds information related to update location.
    public partial interface IUpdateLocationModel :
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Current OEM version of your AzureStack deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Current OEM version of your AzureStack deployment.",
        SerializedName = @"currentOemVersion",
        PossibleTypes = new [] { typeof(string) })]
        string CurrentOemVersion { get; set; }
        /// <summary>Current version of your AzureStack deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Current version of your AzureStack deployment.",
        SerializedName = @"currentVersion",
        PossibleTypes = new [] { typeof(string) })]
        string CurrentVersion { get; set; }
        /// <summary>Date of last update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Date of last update.",
        SerializedName = @"lastUpdated",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastUpdated { get; set; }
        /// <summary>State with respect to the update.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"State with respect to the update.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState) })]
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState? State { get; set; }

    }
    /// Model which holds information related to update location.
    internal partial interface IUpdateLocationModelInternal

    {
        /// <summary>Current OEM version of your AzureStack deployment.</summary>
        string CurrentOemVersion { get; set; }
        /// <summary>Current version of your AzureStack deployment.</summary>
        string CurrentVersion { get; set; }
        /// <summary>Date of last update.</summary>
        global::System.DateTime? LastUpdated { get; set; }
        /// <summary>State with respect to the update.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.UpdateAdmin.Support.RegionUpdateState? State { get; set; }

    }
}