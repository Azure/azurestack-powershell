namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>
    /// This resource represents a gateway, which provides the configuration needed to provide gateway services to virtual networks.
    /// </summary>
    public partial class EdgeGateway :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGateway,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayInternal,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.Resource();

        /// <summary>The available network capacity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public long? AvailableCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayModelInternal)Property).AvailableCapacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayModelInternal)Property).AvailableCapacity = value ?? default(long); }

        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Id; }

        /// <summary>The region where the resource is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayModel Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.EdgeGatewayModel()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Type = value; }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Name; }

        /// <summary>The current number of connections.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public int? NumberOfConnections { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayModelInternal)Property).NumberOfConnection; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayModelInternal)Property).NumberOfConnection = value ?? default(int); }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayModel _property;

        /// <summary>Object which holds information related to edge gateways.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayModel Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.EdgeGatewayModel()); set => this._property = value; }

        /// <summary>The current state of the edge gateway.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string State { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayModelInternal)Property).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayModelInternal)Property).State = value ?? null; }

        /// <summary>List of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Tag = value ?? null /* model class */; }

        /// <summary>The total network capacity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public long? TotalCapacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayModelInternal)Property).TotalCapacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayModelInternal)Property).TotalCapacity = value ?? default(long); }

        /// <summary>Type of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="EdgeGateway" /> instance.</summary>
        public EdgeGateway()
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
    /// This resource represents a gateway, which provides the configuration needed to provide gateway services to virtual networks.
    public partial interface IEdgeGateway :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResource
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
        int? NumberOfConnections { get; set; }
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
    /// This resource represents a gateway, which provides the configuration needed to provide gateway services to virtual networks.
    internal partial interface IEdgeGatewayInternal :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal
    {
        /// <summary>The available network capacity.</summary>
        long? AvailableCapacity { get; set; }
        /// <summary>The current number of connections.</summary>
        int? NumberOfConnections { get; set; }
        /// <summary>Object which holds information related to edge gateways.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IEdgeGatewayModel Property { get; set; }
        /// <summary>The current state of the edge gateway.</summary>
        string State { get; set; }
        /// <summary>The total network capacity.</summary>
        long? TotalCapacity { get; set; }

    }
}