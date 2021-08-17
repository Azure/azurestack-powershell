namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Extensions;

    /// <summary>Network quota resource.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.DoNotFormat]
    public partial class Quota :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuota,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.Resource();

        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Id; }

        /// <summary>Region location of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Location; }

        /// <summary>Maximum number of load balancers a tenant subscription can provision.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? MaxLoadBalancersPerSubscription { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)Property).MaxLoadBalancersPerSubscription; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)Property).MaxLoadBalancersPerSubscription = value ?? default(long); }

        /// <summary>Maximum number of NICs a tenant subscription can provision.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? MaxNicsPerSubscription { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)Property).MaxNicsPerSubscription; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)Property).MaxNicsPerSubscription = value ?? default(long); }

        /// <summary>Maximum number of public IP addresses a tenant subscription can provision.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? MaxPublicIpsPerSubscription { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)Property).MaxPublicIpsPerSubscription; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)Property).MaxPublicIpsPerSubscription = value ?? default(long); }

        /// <summary>Maximum number of security groups a tenant subscription can provision.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? MaxSecurityGroupsPerSubscription { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)Property).MaxSecurityGroupsPerSubscription; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)Property).MaxSecurityGroupsPerSubscription = value ?? default(long); }

        /// <summary>
        /// Maximum number of virtual network gateway Connections a tenant subscription can provision.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? MaxVirtualNetworkGatewayConnectionsPerSubscription { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)Property).MaxVirtualNetworkGatewayConnectionsPerSubscription; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)Property).MaxVirtualNetworkGatewayConnectionsPerSubscription = value ?? default(long); }

        /// <summary>Maximum number of virtual network gateways a tenant subscription can provision.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? MaxVirtualNetworkGatewaysPerSubscription { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)Property).MaxVirtualNetworkGatewaysPerSubscription; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)Property).MaxVirtualNetworkGatewaysPerSubscription = value ?? default(long); }

        /// <summary>Maximum number of virtual networks a tenant subscription can provision.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? MaxVnetsPerSubscription { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)Property).MaxVnetsPerSubscription; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)Property).MaxVnetsPerSubscription = value ?? default(long); }

        /// <summary>Internal Acessors for MigrationPhase</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.MigrationPhaseType? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal.MigrationPhase { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)Property).MigrationPhase; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)Property).MigrationPhase = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaProperties Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.QuotaProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Location</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal.Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Location = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Type = value; }

        /// <summary>State of migration such as None, Prepare, Commit, and Abort.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.MigrationPhaseType? MigrationPhase { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal)Property).MigrationPhase; }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaProperties _property;

        /// <summary>Network quota properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.QuotaProperties()); set => this._property = value; }

        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal)Property).ProvisioningState; }

        /// <summary>List of key value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Tag = value ?? null /* model class */; }

        /// <summary>Type of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="Quota" /> instance.</summary>
        public Quota()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Network quota resource.
    public partial interface IQuota :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResource
    {
        /// <summary>Maximum number of load balancers a tenant subscription can provision.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum number of load balancers a tenant subscription can provision.",
        SerializedName = @"maxLoadBalancersPerSubscription",
        PossibleTypes = new [] { typeof(long) })]
        long? MaxLoadBalancersPerSubscription { get; set; }
        /// <summary>Maximum number of NICs a tenant subscription can provision.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum number of NICs a tenant subscription can provision.",
        SerializedName = @"maxNicsPerSubscription",
        PossibleTypes = new [] { typeof(long) })]
        long? MaxNicsPerSubscription { get; set; }
        /// <summary>Maximum number of public IP addresses a tenant subscription can provision.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum number of public IP addresses a tenant subscription can provision.",
        SerializedName = @"maxPublicIpsPerSubscription",
        PossibleTypes = new [] { typeof(long) })]
        long? MaxPublicIpsPerSubscription { get; set; }
        /// <summary>Maximum number of security groups a tenant subscription can provision.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum number of security groups a tenant subscription can provision.",
        SerializedName = @"maxSecurityGroupsPerSubscription",
        PossibleTypes = new [] { typeof(long) })]
        long? MaxSecurityGroupsPerSubscription { get; set; }
        /// <summary>
        /// Maximum number of virtual network gateway Connections a tenant subscription can provision.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum number of virtual network gateway Connections a tenant subscription can provision.",
        SerializedName = @"maxVirtualNetworkGatewayConnectionsPerSubscription",
        PossibleTypes = new [] { typeof(long) })]
        long? MaxVirtualNetworkGatewayConnectionsPerSubscription { get; set; }
        /// <summary>Maximum number of virtual network gateways a tenant subscription can provision.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum number of virtual network gateways a tenant subscription can provision.",
        SerializedName = @"maxVirtualNetworkGatewaysPerSubscription",
        PossibleTypes = new [] { typeof(long) })]
        long? MaxVirtualNetworkGatewaysPerSubscription { get; set; }
        /// <summary>Maximum number of virtual networks a tenant subscription can provision.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum number of virtual networks a tenant subscription can provision.",
        SerializedName = @"maxVnetsPerSubscription",
        PossibleTypes = new [] { typeof(long) })]
        long? MaxVnetsPerSubscription { get; set; }
        /// <summary>State of migration such as None, Prepare, Commit, and Abort.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"State of migration such as None, Prepare, Commit, and Abort.",
        SerializedName = @"migrationPhase",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.MigrationPhaseType) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.MigrationPhaseType? MigrationPhase { get;  }
        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }

    }
    /// Network quota resource.
    internal partial interface IQuotaInternal :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal
    {
        /// <summary>Maximum number of load balancers a tenant subscription can provision.</summary>
        long? MaxLoadBalancersPerSubscription { get; set; }
        /// <summary>Maximum number of NICs a tenant subscription can provision.</summary>
        long? MaxNicsPerSubscription { get; set; }
        /// <summary>Maximum number of public IP addresses a tenant subscription can provision.</summary>
        long? MaxPublicIpsPerSubscription { get; set; }
        /// <summary>Maximum number of security groups a tenant subscription can provision.</summary>
        long? MaxSecurityGroupsPerSubscription { get; set; }
        /// <summary>
        /// Maximum number of virtual network gateway Connections a tenant subscription can provision.
        /// </summary>
        long? MaxVirtualNetworkGatewayConnectionsPerSubscription { get; set; }
        /// <summary>Maximum number of virtual network gateways a tenant subscription can provision.</summary>
        long? MaxVirtualNetworkGatewaysPerSubscription { get; set; }
        /// <summary>Maximum number of virtual networks a tenant subscription can provision.</summary>
        long? MaxVnetsPerSubscription { get; set; }
        /// <summary>State of migration such as None, Prepare, Commit, and Abort.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.MigrationPhaseType? MigrationPhase { get; set; }
        /// <summary>Network quota properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaProperties Property { get; set; }
        /// <summary>The provisioning state.</summary>
        string ProvisioningState { get; set; }

    }
}