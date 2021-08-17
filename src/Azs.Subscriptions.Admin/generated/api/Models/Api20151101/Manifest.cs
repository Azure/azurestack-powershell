namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>The manifest.</summary>
    public partial class Manifest :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IManifest,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IManifestInternal
    {

        /// <summary>Backing field for <see cref="AlwaysRoutable" /> property.</summary>
        private bool? _alwaysRoutable;

        /// <summary>
        /// A value indicating whether the manifest is always routable by all subscriptions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        public bool? AlwaysRoutable { get => this._alwaysRoutable; set => this._alwaysRoutable = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>A value indicating whether this resource provider is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="ExtensionCollection" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionCollectionDefinition _extensionCollection;

        /// <summary>The extensions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionCollectionDefinition ExtensionCollection { get => (this._extensionCollection = this._extensionCollection ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ExtensionCollectionDefinition()); set => this._extensionCollection = value; }

        /// <summary>
        /// The version of the format a.b[.c[.d]]. see System.Version documentation for more details.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        public string ExtensionCollectionVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionCollectionDefinitionInternal)ExtensionCollection).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionCollectionDefinitionInternal)ExtensionCollection).Version = value ?? null; }

        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        public string ExtensionNextLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionCollectionDefinitionInternal)ExtensionCollection).ExtensionNextLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionCollectionDefinitionInternal)ExtensionCollection).ExtensionNextLink = value ?? null; }

        /// <summary>List of the extensions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionDefinition[] ExtensionValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionCollectionDefinitionInternal)ExtensionCollection).ExtensionValue; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionCollectionDefinitionInternal)ExtensionCollection).ExtensionValue = value ?? null /* arrayOf */; }

        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        public string LinkedNotificationRuleNextLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IFanoutLinkedNotificationRuleListInternal)LinkedNotificationRules).NextLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IFanoutLinkedNotificationRuleListInternal)LinkedNotificationRules).NextLink = value ?? null; }

        /// <summary>List of the linked notification rules.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IFanoutLinkedNotificationRule[] LinkedNotificationRuleValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IFanoutLinkedNotificationRuleListInternal)LinkedNotificationRules).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IFanoutLinkedNotificationRuleListInternal)LinkedNotificationRules).Value = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="LinkedNotificationRules" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IFanoutLinkedNotificationRuleList _linkedNotificationRules;

        /// <summary>The linked notification rules.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IFanoutLinkedNotificationRuleList LinkedNotificationRules { get => (this._linkedNotificationRules = this._linkedNotificationRules ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.FanoutLinkedNotificationRuleList()); set => this._linkedNotificationRules = value; }

        /// <summary>Backing field for <see cref="Metadata" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.IAny _metadata;

        /// <summary>The metadata.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.FormatTable(Index = 1)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.IAny Metadata { get => (this._metadata = this._metadata ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Any()); set => this._metadata = value; }

        /// <summary>Internal Acessors for ExtensionCollection</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionCollectionDefinition Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IManifestInternal.ExtensionCollection { get => (this._extensionCollection = this._extensionCollection ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ExtensionCollectionDefinition()); set { {_extensionCollection = value;} } }

        /// <summary>Internal Acessors for ExtensionCollectionExtensions</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionList Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IManifestInternal.ExtensionCollectionExtensions { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionCollectionDefinitionInternal)ExtensionCollection).Extensions; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionCollectionDefinitionInternal)ExtensionCollection).Extensions = value; }

        /// <summary>Internal Acessors for LinkedNotificationRules</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IFanoutLinkedNotificationRuleList Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IManifestInternal.LinkedNotificationRules { get => (this._linkedNotificationRules = this._linkedNotificationRules ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.FanoutLinkedNotificationRuleList()); set { {_linkedNotificationRules = value;} } }

        /// <summary>Internal Acessors for ProviderAuthorization</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderAuthorization Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IManifestInternal.ProviderAuthorization { get => (this._providerAuthorization = this._providerAuthorization ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ResourceProviderAuthorization()); set { {_providerAuthorization = value;} } }

        /// <summary>Internal Acessors for ResourceHydrationAccounts</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAzureResourceHydrationAccountList Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IManifestInternal.ResourceHydrationAccounts { get => (this._resourceHydrationAccounts = this._resourceHydrationAccounts ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.AzureResourceHydrationAccountList()); set { {_resourceHydrationAccounts = value;} } }

        /// <summary>Internal Acessors for ResourceTypes</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceTypeList Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IManifestInternal.ResourceTypes { get => (this._resourceTypes = this._resourceTypes ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ResourceTypeList()); set { {_resourceTypes = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The unique identifier of the registration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.FormatTable(Index = 0)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Namespace" /> property.</summary>
        private string _namespace;

        /// <summary>The namespace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        public string Namespace { get => this._namespace; set => this._namespace = value; }

        /// <summary>Backing field for <see cref="ProviderAuthorization" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderAuthorization _providerAuthorization;

        /// <summary>The resource provider authorization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderAuthorization ProviderAuthorization { get => (this._providerAuthorization = this._providerAuthorization ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ResourceProviderAuthorization()); set => this._providerAuthorization = value; }

        /// <summary>The application id of resource provider in AAD.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        public string ProviderAuthorizationApplicationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderAuthorizationInternal)ProviderAuthorization).ApplicationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderAuthorizationInternal)ProviderAuthorization).ApplicationId = value ?? null; }

        /// <summary>The role definition identifier against which a role assignment is created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        public string ProviderAuthorizationRoleDefinitionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderAuthorizationInternal)ProviderAuthorization).RoleDefinitionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderAuthorizationInternal)ProviderAuthorization).RoleDefinitionId = value ?? null; }

        /// <summary>Backing field for <see cref="ProviderLocation" /> property.</summary>
        private string _providerLocation;

        /// <summary>The location of the provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        public string ProviderLocation { get => this._providerLocation; set => this._providerLocation = value; }

        /// <summary>Backing field for <see cref="ProviderType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceProviderType? _providerType;

        /// <summary>The type of the provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceProviderType? ProviderType { get => this._providerType; set => this._providerType = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ManifestProvisioningState? _provisioningState;

        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ManifestProvisioningState? ProvisioningState { get => this._provisioningState; set => this._provisioningState = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        public string ResourceHydrationAccountNextLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAzureResourceHydrationAccountListInternal)ResourceHydrationAccounts).NextLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAzureResourceHydrationAccountListInternal)ResourceHydrationAccounts).NextLink = value ?? null; }

        /// <summary>List of the resource hydration accounts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAzureResourceHydrationAccount[] ResourceHydrationAccountValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAzureResourceHydrationAccountListInternal)ResourceHydrationAccounts).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAzureResourceHydrationAccountListInternal)ResourceHydrationAccounts).Value = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ResourceHydrationAccounts" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAzureResourceHydrationAccountList _resourceHydrationAccounts;

        /// <summary>The resource hydration accounts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAzureResourceHydrationAccountList ResourceHydrationAccounts { get => (this._resourceHydrationAccounts = this._resourceHydrationAccounts ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.AzureResourceHydrationAccountList()); set => this._resourceHydrationAccounts = value; }

        /// <summary>Backing field for <see cref="ResourceLocation" /> property.</summary>
        private string _resourceLocation;

        /// <summary>The location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        public string ResourceLocation { get => this._resourceLocation; set => this._resourceLocation = value; }

        /// <summary>Backing field for <see cref="ResourceTags" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.IAny _resourceTags;

        /// <summary>The resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.IAny ResourceTags { get => (this._resourceTags = this._resourceTags ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Any()); set => this._resourceTags = value; }

        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        public string ResourceTypeNextLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceTypeListInternal)ResourceTypes).NextLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceTypeListInternal)ResourceTypes).NextLink = value ?? null; }

        /// <summary>List of the resource types.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceType[] ResourceTypeValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceTypeListInternal)ResourceTypes).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceTypeListInternal)ResourceTypes).Value = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ResourceTypes" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceTypeList _resourceTypes;

        /// <summary>The resource types</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceTypeList ResourceTypes { get => (this._resourceTypes = this._resourceTypes ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ResourceTypeList()); set => this._resourceTypes = value; }

        /// <summary>Backing field for <see cref="RoutingResourceManagerType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceManagerType? _routingResourceManagerType;

        /// <summary>The routing resource manager type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceManagerType? RoutingResourceManagerType { get => this._routingResourceManagerType; set => this._routingResourceManagerType = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The subscription ID under which RP is registered.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="Manifest" /> instance.</summary>
        public Manifest()
        {

        }
    }
    /// The manifest.
    public partial interface IManifest :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>
        /// A value indicating whether the manifest is always routable by all subscriptions.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether the manifest is always routable by all subscriptions.",
        SerializedName = @"alwaysRoutable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AlwaysRoutable { get; set; }
        /// <summary>The display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The display name.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>A value indicating whether this resource provider is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether this resource provider is enabled.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }
        /// <summary>
        /// The version of the format a.b[.c[.d]]. see System.Version documentation for more details.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The version of the format a.b[.c[.d]]. see System.Version documentation for more details.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string ExtensionCollectionVersion { get; set; }
        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string ExtensionNextLink { get; set; }
        /// <summary>List of the extensions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of the extensions.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionDefinition) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionDefinition[] ExtensionValue { get; set; }
        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string LinkedNotificationRuleNextLink { get; set; }
        /// <summary>List of the linked notification rules.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of the linked notification rules.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IFanoutLinkedNotificationRule) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IFanoutLinkedNotificationRule[] LinkedNotificationRuleValue { get; set; }
        /// <summary>The metadata.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The metadata.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.IAny Metadata { get; set; }
        /// <summary>The unique identifier of the registration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The unique identifier of the registration.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The namespace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The namespace.",
        SerializedName = @"namespace",
        PossibleTypes = new [] { typeof(string) })]
        string Namespace { get; set; }
        /// <summary>The application id of resource provider in AAD.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The application id of resource provider in AAD.",
        SerializedName = @"applicationId",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderAuthorizationApplicationId { get; set; }
        /// <summary>The role definition identifier against which a role assignment is created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The role definition identifier against which a role assignment is created.",
        SerializedName = @"roleDefinitionId",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderAuthorizationRoleDefinitionId { get; set; }
        /// <summary>The location of the provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The location of the provider.",
        SerializedName = @"providerLocation",
        PossibleTypes = new [] { typeof(string) })]
        string ProviderLocation { get; set; }
        /// <summary>The type of the provider.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the provider.",
        SerializedName = @"providerType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceProviderType) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceProviderType? ProviderType { get; set; }
        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The provisioning state.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ManifestProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ManifestProvisioningState? ProvisioningState { get; set; }
        /// <summary>The name of the resource group.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the resource group.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceHydrationAccountNextLink { get; set; }
        /// <summary>List of the resource hydration accounts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of the resource hydration accounts.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAzureResourceHydrationAccount) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAzureResourceHydrationAccount[] ResourceHydrationAccountValue { get; set; }
        /// <summary>The location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The location of the resource.",
        SerializedName = @"resourceLocation",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceLocation { get; set; }
        /// <summary>The resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource tags.",
        SerializedName = @"resourceTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.IAny ResourceTags { get; set; }
        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceTypeNextLink { get; set; }
        /// <summary>List of the resource types.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of the resource types.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceType) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceType[] ResourceTypeValue { get; set; }
        /// <summary>The routing resource manager type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The routing resource manager type.",
        SerializedName = @"routingResourceManagerType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceManagerType) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceManagerType? RoutingResourceManagerType { get; set; }
        /// <summary>The subscription ID under which RP is registered.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The subscription ID under which RP is registered.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }

    }
    /// The manifest.
    internal partial interface IManifestInternal

    {
        /// <summary>
        /// A value indicating whether the manifest is always routable by all subscriptions.
        /// </summary>
        bool? AlwaysRoutable { get; set; }
        /// <summary>The display name.</summary>
        string DisplayName { get; set; }
        /// <summary>A value indicating whether this resource provider is enabled.</summary>
        bool? Enabled { get; set; }
        /// <summary>The extensions.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionCollectionDefinition ExtensionCollection { get; set; }
        /// <summary>The extensions.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionList ExtensionCollectionExtensions { get; set; }
        /// <summary>
        /// The version of the format a.b[.c[.d]]. see System.Version documentation for more details.
        /// </summary>
        string ExtensionCollectionVersion { get; set; }
        /// <summary>URI to next page.</summary>
        string ExtensionNextLink { get; set; }
        /// <summary>List of the extensions.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionDefinition[] ExtensionValue { get; set; }
        /// <summary>URI to next page.</summary>
        string LinkedNotificationRuleNextLink { get; set; }
        /// <summary>List of the linked notification rules.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IFanoutLinkedNotificationRule[] LinkedNotificationRuleValue { get; set; }
        /// <summary>The linked notification rules.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IFanoutLinkedNotificationRuleList LinkedNotificationRules { get; set; }
        /// <summary>The metadata.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.IAny Metadata { get; set; }
        /// <summary>The unique identifier of the registration.</summary>
        string Name { get; set; }
        /// <summary>The namespace.</summary>
        string Namespace { get; set; }
        /// <summary>The resource provider authorization.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderAuthorization ProviderAuthorization { get; set; }
        /// <summary>The application id of resource provider in AAD.</summary>
        string ProviderAuthorizationApplicationId { get; set; }
        /// <summary>The role definition identifier against which a role assignment is created.</summary>
        string ProviderAuthorizationRoleDefinitionId { get; set; }
        /// <summary>The location of the provider.</summary>
        string ProviderLocation { get; set; }
        /// <summary>The type of the provider.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceProviderType? ProviderType { get; set; }
        /// <summary>The provisioning state.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ManifestProvisioningState? ProvisioningState { get; set; }
        /// <summary>The name of the resource group.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>URI to next page.</summary>
        string ResourceHydrationAccountNextLink { get; set; }
        /// <summary>List of the resource hydration accounts.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAzureResourceHydrationAccount[] ResourceHydrationAccountValue { get; set; }
        /// <summary>The resource hydration accounts.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAzureResourceHydrationAccountList ResourceHydrationAccounts { get; set; }
        /// <summary>The location of the resource.</summary>
        string ResourceLocation { get; set; }
        /// <summary>The resource tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.IAny ResourceTags { get; set; }
        /// <summary>URI to next page.</summary>
        string ResourceTypeNextLink { get; set; }
        /// <summary>List of the resource types.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceType[] ResourceTypeValue { get; set; }
        /// <summary>The resource types</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceTypeList ResourceTypes { get; set; }
        /// <summary>The routing resource manager type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceManagerType? RoutingResourceManagerType { get; set; }
        /// <summary>The subscription ID under which RP is registered.</summary>
        string SubscriptionId { get; set; }

    }
}