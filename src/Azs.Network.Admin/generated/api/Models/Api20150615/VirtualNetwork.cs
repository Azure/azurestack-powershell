namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Extensions;

    /// <summary>This represents a virtual network.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.DoNotFormat]
    public partial class VirtualNetwork :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetwork,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkInternal,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.Resource();

        /// <summary>List of NIC errors associated with the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkConfigurationStatus[] ConfigurationStateHostError { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)Property).ConfigurationStateHostError; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)Property).ConfigurationStateHostError = value ?? null /* arrayOf */; }

        /// <summary>Last updated time for the running state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public global::System.DateTime? ConfigurationStateLastUpdatedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)Property).ConfigurationStateLastUpdatedTime; }

        /// <summary>The virtual network status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStateStatusType? ConfigurationStateStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)Property).ConfigurationStateStatus; }

        /// <summary>List of NIC errors associated with the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkConfigurationStatus[] ConfigurationStateVirtualNetworkInterfaceError { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)Property).ConfigurationStateVirtualNetworkInterfaceError; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)Property).ConfigurationStateVirtualNetworkInterfaceError = value ?? null /* arrayOf */; }

        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Id; }

        /// <summary>Region location of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Location; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Location</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal.Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Location = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for ConfigurationState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkConfigurationState Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkInternal.ConfigurationState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)Property).ConfigurationState; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)Property).ConfigurationState = value; }

        /// <summary>Internal Acessors for ConfigurationStateLastUpdatedTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkInternal.ConfigurationStateLastUpdatedTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)Property).ConfigurationStateLastUpdatedTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)Property).ConfigurationStateLastUpdatedTime = value; }

        /// <summary>Internal Acessors for ConfigurationStateStatus</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStateStatusType? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkInternal.ConfigurationStateStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)Property).ConfigurationStateStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkPropertiesInternal)Property).ConfigurationStateStatus = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkProperties Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.VirtualNetworkProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IProvisionedResourceInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for SubscriptionId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkInternal.SubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal)Property).SubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal)Property).SubscriptionId = value; }

        /// <summary>Internal Acessors for TenantResourceUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkInternal.TenantResourceUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal)Property).Uri; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ITenantResourceInternal)Property).Uri = value; }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkProperties _property;

        /// <summary>Properties of a virtual network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.VirtualNetworkProperties()); set => this._property = value; }

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

        /// <summary>Creates an new <see cref="VirtualNetwork" /> instance.</summary>
        public VirtualNetwork()
        {

        }
    }
    /// This represents a virtual network.
    public partial interface IVirtualNetwork :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResource
    {
        /// <summary>List of NIC errors associated with the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of NIC errors associated with the resource.",
        SerializedName = @"hostErrors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkConfigurationStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkConfigurationStatus[] ConfigurationStateHostError { get; set; }
        /// <summary>Last updated time for the running state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Last updated time for the running state.",
        SerializedName = @"lastUpdatedTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ConfigurationStateLastUpdatedTime { get;  }
        /// <summary>The virtual network status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The virtual network status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStateStatusType) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStateStatusType? ConfigurationStateStatus { get;  }
        /// <summary>List of NIC errors associated with the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of NIC errors associated with the resource.",
        SerializedName = @"virtualNetworkInterfaceErrors",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkConfigurationStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkConfigurationStatus[] ConfigurationStateVirtualNetworkInterfaceError { get; set; }
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
    /// This represents a virtual network.
    internal partial interface IVirtualNetworkInternal :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal
    {
        /// <summary>The virtual network configuration state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkConfigurationState ConfigurationState { get; set; }
        /// <summary>List of NIC errors associated with the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkConfigurationStatus[] ConfigurationStateHostError { get; set; }
        /// <summary>Last updated time for the running state.</summary>
        global::System.DateTime? ConfigurationStateLastUpdatedTime { get; set; }
        /// <summary>The virtual network status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Support.VirtualNetworkConfigurationStateStatusType? ConfigurationStateStatus { get; set; }
        /// <summary>List of NIC errors associated with the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkConfigurationStatus[] ConfigurationStateVirtualNetworkInterfaceError { get; set; }
        /// <summary>Properties of a virtual network.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IVirtualNetworkProperties Property { get; set; }
        /// <summary>The provisioning state.</summary>
        string ProvisioningState { get; set; }
        /// <summary>The subscription ID.</summary>
        string SubscriptionId { get; set; }
        /// <summary>The tenant resource URI.</summary>
        string TenantResourceUri { get; set; }

    }
}