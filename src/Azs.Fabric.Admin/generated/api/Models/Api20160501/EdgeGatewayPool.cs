namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>This object represents an edge gateway pool, which contains a list of gateways.</summary>
    public partial class EdgeGatewayPool :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayPool,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayPoolInternal,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.Resource();

        /// <summary>List of the edge gateways in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string[] EdgeGateway { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayPoolModelInternal)Property).EdgeGateway; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayPoolModelInternal)Property).EdgeGateway = value ?? null /* arrayOf */; }

        /// <summary>Gateway capacity in kilobits per second.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public int? GatewayCapacityKiloBitsPerSecond { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayPoolModelInternal)Property).GatewayCapacityKiloBitsPerSecond; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayPoolModelInternal)Property).GatewayCapacityKiloBitsPerSecond = value ?? default(int); }

        /// <summary>The gateway type, for example, S2sIPsec, S2sGre, and so on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string GatewayType { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayPoolModelInternal)Property).GatewayType; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayPoolModelInternal)Property).GatewayType = value ?? null; }

        /// <summary>The GRE VIP subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string GreVipSubnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayPoolModelInternal)Property).GreVipSubnet; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayPoolModelInternal)Property).GreVipSubnet = value ?? null; }

        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Id; }

        /// <summary>The region where the resource is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayPoolModel Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayPoolInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.EdgeGatewayPoolModel()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Type = value; }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Name; }

        /// <summary>The number of gateways in the pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public int? NumberOfGateways { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayPoolModelInternal)Property).NumberOfGateway; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayPoolModelInternal)Property).NumberOfGateway = value ?? default(int); }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayPoolModel _property;

        /// <summary>The properties of an edge gateway pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayPoolModel Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.EdgeGatewayPoolModel()); set => this._property = value; }

        /// <summary>The public IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string PublicIPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayPoolModelInternal)Property).PublicIPAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayPoolModelInternal)Property).PublicIPAddress = value ?? null; }

        /// <summary>The number of redundant gateways.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public long? RedundantGatewayCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayPoolModelInternal)Property).RedundantGatewayCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayPoolModelInternal)Property).RedundantGatewayCount = value ?? default(long); }

        /// <summary>List of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Tag = value ?? null /* model class */; }

        /// <summary>Type of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="EdgeGatewayPool" /> instance.</summary>
        public EdgeGatewayPool()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// This object represents an edge gateway pool, which contains a list of gateways.
    public partial interface IEdgeGatewayPool :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResource
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
        int? NumberOfGateways { get; set; }
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
    /// This object represents an edge gateway pool, which contains a list of gateways.
    internal partial interface IEdgeGatewayPoolInternal :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal
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
        int? NumberOfGateways { get; set; }
        /// <summary>The properties of an edge gateway pool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayPoolModel Property { get; set; }
        /// <summary>The public IP address.</summary>
        string PublicIPAddress { get; set; }
        /// <summary>The number of redundant gateways.</summary>
        long? RedundantGatewayCount { get; set; }

    }
}