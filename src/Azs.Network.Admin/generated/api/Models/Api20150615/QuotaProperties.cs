namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Extensions;

    /// <summary>Properties of a quota.</summary>
    public partial class QuotaProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaProperties,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResource __provisionedResource = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ProvisionedResource();

        /// <summary>Backing field for <see cref="MaxLoadBalancersPerSubscription" /> property.</summary>
        private long? _maxLoadBalancersPerSubscription;

        /// <summary>Maximum number of load balancers a tenant subscription can provision.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public long? MaxLoadBalancersPerSubscription { get => this._maxLoadBalancersPerSubscription; set => this._maxLoadBalancersPerSubscription = value; }

        /// <summary>Backing field for <see cref="MaxNicsPerSubscription" /> property.</summary>
        private long? _maxNicsPerSubscription;

        /// <summary>Maximum number of NICs a tenant subscription can provision.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public long? MaxNicsPerSubscription { get => this._maxNicsPerSubscription; set => this._maxNicsPerSubscription = value; }

        /// <summary>Backing field for <see cref="MaxPublicIpsPerSubscription" /> property.</summary>
        private long? _maxPublicIpsPerSubscription;

        /// <summary>Maximum number of public IP addresses a tenant subscription can provision.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public long? MaxPublicIpsPerSubscription { get => this._maxPublicIpsPerSubscription; set => this._maxPublicIpsPerSubscription = value; }

        /// <summary>Backing field for <see cref="MaxSecurityGroupsPerSubscription" /> property.</summary>
        private long? _maxSecurityGroupsPerSubscription;

        /// <summary>Maximum number of security groups a tenant subscription can provision.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public long? MaxSecurityGroupsPerSubscription { get => this._maxSecurityGroupsPerSubscription; set => this._maxSecurityGroupsPerSubscription = value; }

        /// <summary>
        /// Backing field for <see cref="MaxVirtualNetworkGatewayConnectionsPerSubscription" /> property.
        /// </summary>
        private long? _maxVirtualNetworkGatewayConnectionsPerSubscription;

        /// <summary>
        /// Maximum number of virtual network gateway Connections a tenant subscription can provision.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public long? MaxVirtualNetworkGatewayConnectionsPerSubscription { get => this._maxVirtualNetworkGatewayConnectionsPerSubscription; set => this._maxVirtualNetworkGatewayConnectionsPerSubscription = value; }

        /// <summary>
        /// Backing field for <see cref="MaxVirtualNetworkGatewaysPerSubscription" /> property.
        /// </summary>
        private long? _maxVirtualNetworkGatewaysPerSubscription;

        /// <summary>Maximum number of virtual network gateways a tenant subscription can provision.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public long? MaxVirtualNetworkGatewaysPerSubscription { get => this._maxVirtualNetworkGatewaysPerSubscription; set => this._maxVirtualNetworkGatewaysPerSubscription = value; }

        /// <summary>Backing field for <see cref="MaxVnetsPerSubscription" /> property.</summary>
        private long? _maxVnetsPerSubscription;

        /// <summary>Maximum number of virtual networks a tenant subscription can provision.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public long? MaxVnetsPerSubscription { get => this._maxVnetsPerSubscription; set => this._maxVnetsPerSubscription = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal)__provisionedResource).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal)__provisionedResource).ProvisioningState = value; }

        /// <summary>Internal Acessors for MigrationPhase</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.MigrationPhaseType? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IQuotaPropertiesInternal.MigrationPhase { get => this._migrationPhase; set { {_migrationPhase = value;} } }

        /// <summary>Backing field for <see cref="MigrationPhase" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.MigrationPhaseType? _migrationPhase;

        /// <summary>State of migration such as None, Prepare, Commit, and Abort.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.MigrationPhaseType? MigrationPhase { get => this._migrationPhase; }

        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inherited)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal)__provisionedResource).ProvisioningState; }

        /// <summary>Creates an new <see cref="QuotaProperties" /> instance.</summary>
        public QuotaProperties()
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
            await eventListener.AssertNotNull(nameof(__provisionedResource), __provisionedResource);
            await eventListener.AssertObjectIsValid(nameof(__provisionedResource), __provisionedResource);
        }
    }
    /// Properties of a quota.
    public partial interface IQuotaProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResource
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

    }
    /// Properties of a quota.
    internal partial interface IQuotaPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal
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

    }
}