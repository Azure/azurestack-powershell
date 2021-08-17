namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>The data contract for specifying extensions in resource provider manifests.</summary>
    public partial class ExtensionDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionDefinitionInternal
    {

        /// <summary>Internal Acessors for Properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionPropertiesDefinition Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionDefinitionInternal.Properties { get => (this._properties = this._properties ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ExtensionPropertiesDefinition()); set { {_properties = value;} } }

        /// <summary>Internal Acessors for ResourceAccess</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceAccessList Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionDefinitionInternal.ResourceAccess { get => (this._resourceAccess = this._resourceAccess ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ResourceAccessList()); set { {_resourceAccess = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="ObsoleteBundlesBitmask" /> property.</summary>
        private int? _obsoleteBundlesBitmask;

        /// <summary>The obsolete bundles bitmask.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public int? ObsoleteBundlesBitmask { get => this._obsoleteBundlesBitmask; set => this._obsoleteBundlesBitmask = value; }

        /// <summary>Backing field for <see cref="Properties" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionPropertiesDefinition _properties;

        /// <summary>The extension properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionPropertiesDefinition Properties { get => (this._properties = this._properties ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ExtensionPropertiesDefinition()); set => this._properties = value; }

        /// <summary>The quota create blade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string QuotaCreateBladeName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionPropertiesDefinitionInternal)Properties).QuotaCreateBladeName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionPropertiesDefinitionInternal)Properties).QuotaCreateBladeName = value ?? null; }

        /// <summary>Backing field for <see cref="ResourceAccess" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceAccessList _resourceAccess;

        /// <summary>The resource access.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceAccessList ResourceAccess { get => (this._resourceAccess = this._resourceAccess ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ResourceAccessList()); set => this._resourceAccess = value; }

        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string ResourceAccessNextLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceAccessListInternal)ResourceAccess).NextLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceAccessListInternal)ResourceAccess).NextLink = value ?? null; }

        /// <summary>List of the resource access.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceAccess[] ResourceAccessValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceAccessListInternal)ResourceAccess).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceAccessListInternal)ResourceAccess).Value = value ?? null /* arrayOf */; }

        /// <summary>The resource provider dashboard blade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string ResourceProviderDashboardBladeName { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionPropertiesDefinitionInternal)Properties).ResourceProviderDashboardBladeName; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionPropertiesDefinitionInternal)Properties).ResourceProviderDashboardBladeName = value ?? null; }

        /// <summary>Backing field for <see cref="Uri" /> property.</summary>
        private string _uri;

        /// <summary>The Uri</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Uri { get => this._uri; set => this._uri = value; }

        /// <summary>Creates an new <see cref="ExtensionDefinition" /> instance.</summary>
        public ExtensionDefinition()
        {

        }
    }
    /// The data contract for specifying extensions in resource provider manifests.
    public partial interface IExtensionDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The obsolete bundles bitmask.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The obsolete bundles bitmask.",
        SerializedName = @"obsoleteBundlesBitmask",
        PossibleTypes = new [] { typeof(int) })]
        int? ObsoleteBundlesBitmask { get; set; }
        /// <summary>The quota create blade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The quota create blade.",
        SerializedName = @"quotaCreateBladeName",
        PossibleTypes = new [] { typeof(string) })]
        string QuotaCreateBladeName { get; set; }
        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceAccessNextLink { get; set; }
        /// <summary>List of the resource access.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of the resource access.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceAccess) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceAccess[] ResourceAccessValue { get; set; }
        /// <summary>The resource provider dashboard blade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource provider dashboard blade.",
        SerializedName = @"resourceProviderDashboardBladeName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceProviderDashboardBladeName { get; set; }
        /// <summary>The Uri</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Uri",
        SerializedName = @"uri",
        PossibleTypes = new [] { typeof(string) })]
        string Uri { get; set; }

    }
    /// The data contract for specifying extensions in resource provider manifests.
    internal partial interface IExtensionDefinitionInternal

    {
        /// <summary>The name.</summary>
        string Name { get; set; }
        /// <summary>The obsolete bundles bitmask.</summary>
        int? ObsoleteBundlesBitmask { get; set; }
        /// <summary>The extension properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionPropertiesDefinition Properties { get; set; }
        /// <summary>The quota create blade.</summary>
        string QuotaCreateBladeName { get; set; }
        /// <summary>The resource access.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceAccessList ResourceAccess { get; set; }
        /// <summary>URI to next page.</summary>
        string ResourceAccessNextLink { get; set; }
        /// <summary>List of the resource access.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceAccess[] ResourceAccessValue { get; set; }
        /// <summary>The resource provider dashboard blade.</summary>
        string ResourceProviderDashboardBladeName { get; set; }
        /// <summary>The Uri</summary>
        string Uri { get; set; }

    }
}