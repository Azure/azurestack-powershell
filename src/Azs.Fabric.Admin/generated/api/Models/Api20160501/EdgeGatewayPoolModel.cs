namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>An object that contains the properties of an edge gateway pool.</summary>
    public partial class EdgeGatewayPoolModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayPoolModel,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayPoolModelInternal
    {

        /// <summary>Backing field for <see cref="EdgeGateway" /> property.</summary>
        private string[] _edgeGateway;

        /// <summary>List of the edge gateways in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string[] EdgeGateway { get => this._edgeGateway; set => this._edgeGateway = value; }

        /// <summary>Backing field for <see cref="GatewayCapacityKiloBitsPerSecond" /> property.</summary>
        private int? _gatewayCapacityKiloBitsPerSecond;

        /// <summary>Gateway capacity in kilobits per second.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public int? GatewayCapacityKiloBitsPerSecond { get => this._gatewayCapacityKiloBitsPerSecond; set => this._gatewayCapacityKiloBitsPerSecond = value; }

        /// <summary>Backing field for <see cref="GatewayType" /> property.</summary>
        private string _gatewayType;

        /// <summary>The gateway type, for example, S2sIPsec, S2sGre, and so on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string GatewayType { get => this._gatewayType; set => this._gatewayType = value; }

        /// <summary>Backing field for <see cref="GreVipSubnet" /> property.</summary>
        private string _greVipSubnet;

        /// <summary>The GRE VIP subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string GreVipSubnet { get => this._greVipSubnet; set => this._greVipSubnet = value; }

        /// <summary>Backing field for <see cref="NumberOfGateway" /> property.</summary>
        private int? _numberOfGateway;

        /// <summary>The number of gateways in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public int? NumberOfGateway { get => this._numberOfGateway; set => this._numberOfGateway = value; }

        /// <summary>Backing field for <see cref="PublicIPAddress" /> property.</summary>
        private string _publicIPAddress;

        /// <summary>The public IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string PublicIPAddress { get => this._publicIPAddress; set => this._publicIPAddress = value; }

        /// <summary>Backing field for <see cref="RedundantGatewayCount" /> property.</summary>
        private long? _redundantGatewayCount;

        /// <summary>The number of redundant gateways.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public long? RedundantGatewayCount { get => this._redundantGatewayCount; set => this._redundantGatewayCount = value; }

        /// <summary>Creates an new <see cref="EdgeGatewayPoolModel" /> instance.</summary>
        public EdgeGatewayPoolModel()
        {

        }
    }
    /// An object that contains the properties of an edge gateway pool.
    public partial interface IEdgeGatewayPoolModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>List of the edge gateways in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of the edge gateways in the pool.",
        SerializedName = @"edgeGateways",
        PossibleTypes = new [] { typeof(string) })]
        string[] EdgeGateway { get; set; }
        /// <summary>Gateway capacity in kilobits per second.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gateway capacity in kilobits per second.",
        SerializedName = @"gatewayCapacityKiloBitsPerSecond",
        PossibleTypes = new [] { typeof(int) })]
        int? GatewayCapacityKiloBitsPerSecond { get; set; }
        /// <summary>The gateway type, for example, S2sIPsec, S2sGre, and so on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The gateway type, for example, S2sIPsec, S2sGre, and so on.",
        SerializedName = @"gatewayType",
        PossibleTypes = new [] { typeof(string) })]
        string GatewayType { get; set; }
        /// <summary>The GRE VIP subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The GRE VIP subnet.",
        SerializedName = @"greVipSubnet",
        PossibleTypes = new [] { typeof(string) })]
        string GreVipSubnet { get; set; }
        /// <summary>The number of gateways in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of gateways in the pool.",
        SerializedName = @"numberOfGateways",
        PossibleTypes = new [] { typeof(int) })]
        int? NumberOfGateway { get; set; }
        /// <summary>The public IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The public IP address.",
        SerializedName = @"publicIpAddress",
        PossibleTypes = new [] { typeof(string) })]
        string PublicIPAddress { get; set; }
        /// <summary>The number of redundant gateways.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of redundant gateways.",
        SerializedName = @"redundantGatewayCount",
        PossibleTypes = new [] { typeof(long) })]
        long? RedundantGatewayCount { get; set; }

    }
    /// An object that contains the properties of an edge gateway pool.
    internal partial interface IEdgeGatewayPoolModelInternal

    {
        /// <summary>List of the edge gateways in the pool.</summary>
        string[] EdgeGateway { get; set; }
        /// <summary>Gateway capacity in kilobits per second.</summary>
        int? GatewayCapacityKiloBitsPerSecond { get; set; }
        /// <summary>The gateway type, for example, S2sIPsec, S2sGre, and so on.</summary>
        string GatewayType { get; set; }
        /// <summary>The GRE VIP subnet.</summary>
        string GreVipSubnet { get; set; }
        /// <summary>The number of gateways in the pool.</summary>
        int? NumberOfGateway { get; set; }
        /// <summary>The public IP address.</summary>
        string PublicIPAddress { get; set; }
        /// <summary>The number of redundant gateways.</summary>
        long? RedundantGatewayCount { get; set; }

    }
}