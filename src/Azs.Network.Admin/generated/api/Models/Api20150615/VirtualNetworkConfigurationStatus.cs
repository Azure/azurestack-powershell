namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Extensions;

    /// <summary>Virtual network configuration status.</summary>
    public partial class VirtualNetworkConfigurationStatus :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkConfigurationStatus,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkConfigurationStatusInternal
    {

        /// <summary>Backing field for <see cref="LastUpdatedTime" /> property.</summary>
        private global::System.DateTime? _lastUpdatedTime;

        /// <summary>Last updated time for the configuration status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? LastUpdatedTime { get => this._lastUpdatedTime; }

        /// <summary>Internal Acessors for LastUpdatedTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkConfigurationStatusInternal.LastUpdatedTime { get => this._lastUpdatedTime; set { {_lastUpdatedTime = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStatusType? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkConfigurationStatusInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStatusType? _status;

        /// <summary>The virtual network configuration status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStatusType? Status { get => this._status; }

        /// <summary>Creates an new <see cref="VirtualNetworkConfigurationStatus" /> instance.</summary>
        public VirtualNetworkConfigurationStatus()
        {

        }
    }
    /// Virtual network configuration status.
    public partial interface IVirtualNetworkConfigurationStatus :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Last updated time for the configuration status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Last updated time for the configuration status.",
        SerializedName = @"lastUpdatedTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastUpdatedTime { get;  }
        /// <summary>The virtual network configuration status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The virtual network configuration status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStatusType) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStatusType? Status { get;  }

    }
    /// Virtual network configuration status.
    internal partial interface IVirtualNetworkConfigurationStatusInternal

    {
        /// <summary>Last updated time for the configuration status.</summary>
        global::System.DateTime? LastUpdatedTime { get; set; }
        /// <summary>The virtual network configuration status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStatusType? Status { get; set; }

    }
}