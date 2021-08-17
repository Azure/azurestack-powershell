namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Extensions;

    /// <summary>This resource represents an IP Address.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.DoNotFormat]
    public partial class PublicIPAddress :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IPublicIPAddress,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IPublicIPAddressInternal,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.Resource();

        /// <summary>The allocation method.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.AllocationMethodType? AllocationMethod { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IPublicIPAddressPropertiesInternal)Property).AllocationMethod; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IPublicIPAddressPropertiesInternal)Property).AllocationMethod = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.AllocationMethodType)""); }

        /// <summary>The IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public string IPAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IPublicIPAddressPropertiesInternal)Property).IPAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IPublicIPAddressPropertiesInternal)Property).IPAddress = value ?? null; }

        /// <summary>The IP pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public string IPPool { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IPublicIPAddressPropertiesInternal)Property).IPPool; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IPublicIPAddressPropertiesInternal)Property).IPPool = value ?? null; }

        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Id; }

        /// <summary>Region location of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Location; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IPublicIPAddressProperties Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IPublicIPAddressInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.PublicIPAddressProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IPublicIPAddressInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for SubscriptionId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IPublicIPAddressInternal.SubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal)Property).SubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal)Property).SubscriptionId = value; }

        /// <summary>Internal Acessors for TenantResourceUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IPublicIPAddressInternal.TenantResourceUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal)Property).Uri; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal)Property).Uri = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Location</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal.Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Location = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Type = value; }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IPublicIPAddressProperties _property;

        /// <summary>Properties of an IP Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IPublicIPAddressProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.PublicIPAddressProperties()); set => this._property = value; }

        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal)Property).ProvisioningState; }

        /// <summary>The subscription ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public string SubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal)Property).SubscriptionId; }

        /// <summary>List of key value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Tag = value ?? null /* model class */; }

        /// <summary>The tenant resource URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public string TenantResourceUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal)Property).Uri; }

        /// <summary>Type of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="PublicIPAddress" /> instance.</summary>
        public PublicIPAddress()
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
    /// This resource represents an IP Address.
    public partial interface IPublicIPAddress :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResource
    {
        /// <summary>The allocation method.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The allocation method.",
        SerializedName = @"allocationMethod",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.AllocationMethodType) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.AllocationMethodType? AllocationMethod { get; set; }
        /// <summary>The IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The IP address.",
        SerializedName = @"ipAddress",
        PossibleTypes = new [] { typeof(string) })]
        string IPAddress { get; set; }
        /// <summary>The IP pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The IP pool.",
        SerializedName = @"ipPool",
        PossibleTypes = new [] { typeof(string) })]
        string IPPool { get; set; }
        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }
        /// <summary>The subscription ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The subscription ID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get;  }
        /// <summary>The tenant resource URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The tenant resource URI.",
        SerializedName = @"tenantResourceUri",
        PossibleTypes = new [] { typeof(string) })]
        string TenantResourceUri { get;  }

    }
    /// This resource represents an IP Address.
    internal partial interface IPublicIPAddressInternal :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal
    {
        /// <summary>The allocation method.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.AllocationMethodType? AllocationMethod { get; set; }
        /// <summary>The IP address.</summary>
        string IPAddress { get; set; }
        /// <summary>The IP pool.</summary>
        string IPPool { get; set; }
        /// <summary>Properties of an IP Address.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IPublicIPAddressProperties Property { get; set; }
        /// <summary>The provisioning state.</summary>
        string ProvisioningState { get; set; }
        /// <summary>The subscription ID.</summary>
        string SubscriptionId { get; set; }
        /// <summary>The tenant resource URI.</summary>
        string TenantResourceUri { get; set; }

    }
}