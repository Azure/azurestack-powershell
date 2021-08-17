namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Object which holds information related to edge gateways.</summary>
    public partial class EdgeGatewayModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayModel,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayModelInternal
    {

        /// <summary>Backing field for <see cref="AvailableCapacity" /> property.</summary>
        private long? _availableCapacity;

        /// <summary>The available network capacity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public long? AvailableCapacity { get => this._availableCapacity; set => this._availableCapacity = value; }

        /// <summary>Backing field for <see cref="NumberOfConnection" /> property.</summary>
        private int? _numberOfConnection;

        /// <summary>The current number of connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public int? NumberOfConnection { get => this._numberOfConnection; set => this._numberOfConnection = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>The current state of the edge gateway.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Backing field for <see cref="TotalCapacity" /> property.</summary>
        private long? _totalCapacity;

        /// <summary>The total network capacity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public long? TotalCapacity { get => this._totalCapacity; set => this._totalCapacity = value; }

        /// <summary>Creates an new <see cref="EdgeGatewayModel" /> instance.</summary>
        public EdgeGatewayModel()
        {

        }
    }
    /// Object which holds information related to edge gateways.
    public partial interface IEdgeGatewayModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The available network capacity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The available network capacity.",
        SerializedName = @"availableCapacity",
        PossibleTypes = new [] { typeof(long) })]
        long? AvailableCapacity { get; set; }
        /// <summary>The current number of connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The current number of connections.",
        SerializedName = @"numberOfConnections",
        PossibleTypes = new [] { typeof(int) })]
        int? NumberOfConnection { get; set; }
        /// <summary>The current state of the edge gateway.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The current state of the edge gateway.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string State { get; set; }
        /// <summary>The total network capacity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The total network capacity.",
        SerializedName = @"totalCapacity",
        PossibleTypes = new [] { typeof(long) })]
        long? TotalCapacity { get; set; }

    }
    /// Object which holds information related to edge gateways.
    internal partial interface IEdgeGatewayModelInternal

    {
        /// <summary>The available network capacity.</summary>
        long? AvailableCapacity { get; set; }
        /// <summary>The current number of connections.</summary>
        int? NumberOfConnection { get; set; }
        /// <summary>The current state of the edge gateway.</summary>
        string State { get; set; }
        /// <summary>The total network capacity.</summary>
        long? TotalCapacity { get; set; }

    }
}