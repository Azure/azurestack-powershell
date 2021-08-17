namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Extensions;

    /// <summary>Properties of a load balancer.</summary>
    public partial class LoadBalancerProperty :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ILoadBalancerProperty,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ILoadBalancerPropertyInternal,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResource __provisionedResource = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ProvisionedResource();

        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResource __tenantResource = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.TenantResource();

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal)__provisionedResource).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal)__provisionedResource).ProvisioningState = value; }

        /// <summary>Internal Acessors for SubscriptionId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal.SubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal)__tenantResource).SubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal)__tenantResource).SubscriptionId = value; }

        /// <summary>Internal Acessors for Uri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal.Uri { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal)__tenantResource).Uri; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal)__tenantResource).Uri = value; }

        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inherited)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal)__provisionedResource).ProvisioningState; }

        /// <summary>Backing field for <see cref="PublicIPAddress" /> property.</summary>
        private string[] _publicIPAddress;

        /// <summary>List of public IP addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public string[] PublicIPAddress { get => this._publicIPAddress; set => this._publicIPAddress = value; }

        /// <summary>The subscription ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inherited)]
        public string SubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal)__tenantResource).SubscriptionId; }

        /// <summary>The tenant resource URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inherited)]
        public string Uri { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal)__tenantResource).Uri; }

        /// <summary>Creates an new <see cref="LoadBalancerProperty" /> instance.</summary>
        public LoadBalancerProperty()
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
            await eventListener.AssertNotNull(nameof(__tenantResource), __tenantResource);
            await eventListener.AssertObjectIsValid(nameof(__tenantResource), __tenantResource);
        }
    }
    /// Properties of a load balancer.
    public partial interface ILoadBalancerProperty :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResource,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResource
    {
        /// <summary>List of public IP addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of public IP addresses.",
        SerializedName = @"publicIpAddresses",
        PossibleTypes = new [] { typeof(string) })]
        string[] PublicIPAddress { get; set; }

    }
    /// Properties of a load balancer.
    internal partial interface ILoadBalancerPropertyInternal :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal
    {
        /// <summary>List of public IP addresses.</summary>
        string[] PublicIPAddress { get; set; }

    }
}