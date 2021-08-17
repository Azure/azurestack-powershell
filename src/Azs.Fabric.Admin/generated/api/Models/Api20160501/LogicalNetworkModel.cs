namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Properties of a logical network.</summary>
    public partial class LogicalNetworkModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkModel,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkModelInternal
    {

        /// <summary>Backing field for <see cref="Metadata" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkModelMetadata _metadata;

        /// <summary>Metadata related to the logical network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkModelMetadata Metadata { get => (this._metadata = this._metadata ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.LogicalNetworkModelMetadata()); set => this._metadata = value; }

        /// <summary>Backing field for <see cref="NetworkVirtualizationEnabled" /> property.</summary>
        private bool? _networkVirtualizationEnabled;

        /// <summary>
        /// Flag to indicate that the network virtualization is enabled on the logical network.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public bool? NetworkVirtualizationEnabled { get => this._networkVirtualizationEnabled; set => this._networkVirtualizationEnabled = value; }

        /// <summary>Backing field for <see cref="Subnet" /> property.</summary>
        private string[] _subnet;

        /// <summary>List of subnets belonging to the logical network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string[] Subnet { get => this._subnet; set => this._subnet = value; }

        /// <summary>Creates an new <see cref="LogicalNetworkModel" /> instance.</summary>
        public LogicalNetworkModel()
        {

        }
    }
    /// Properties of a logical network.
    public partial interface ILogicalNetworkModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Metadata related to the logical network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Metadata related to the logical network.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkModelMetadata) })]
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkModelMetadata Metadata { get; set; }
        /// <summary>
        /// Flag to indicate that the network virtualization is enabled on the logical network.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to indicate that the network virtualization is enabled on the logical network.",
        SerializedName = @"networkVirtualizationEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? NetworkVirtualizationEnabled { get; set; }
        /// <summary>List of subnets belonging to the logical network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of subnets belonging to the logical network.",
        SerializedName = @"subnets",
        PossibleTypes = new [] { typeof(string) })]
        string[] Subnet { get; set; }

    }
    /// Properties of a logical network.
    internal partial interface ILogicalNetworkModelInternal

    {
        /// <summary>Metadata related to the logical network.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkModelMetadata Metadata { get; set; }
        /// <summary>
        /// Flag to indicate that the network virtualization is enabled on the logical network.
        /// </summary>
        bool? NetworkVirtualizationEnabled { get; set; }
        /// <summary>List of subnets belonging to the logical network.</summary>
        string[] Subnet { get; set; }

    }
}