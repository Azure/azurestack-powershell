namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>The resource type definition.</summary>
    public partial class ResourceType :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceType,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceTypeInternal
    {

        /// <summary>Backing field for <see cref="AllowedUnauthorizedActions" /> property.</summary>
        private string[] _allowedUnauthorizedActions;

        /// <summary>The allowed unauthorized actions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string[] AllowedUnauthorizedActions { get => this._allowedUnauthorizedActions; set => this._allowedUnauthorizedActions = value; }

        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string ApiProfileNextLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApiProfileListInternal)ApiProfiles).NextLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApiProfileListInternal)ApiProfiles).NextLink = value ?? null; }

        /// <summary>List of the API profiles.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApiProfile[] ApiProfileValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApiProfileListInternal)ApiProfiles).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApiProfileListInternal)ApiProfiles).Value = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ApiProfiles" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApiProfileList _apiProfiles;

        /// <summary>The API profiles.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApiProfileList ApiProfiles { get => (this._apiProfiles = this._apiProfiles ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ApiProfileList()); set => this._apiProfiles = value; }

        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string AuthorizationActionMappingNextLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAuthorizationActionMappingListInternal)AuthorizationActionMappings).NextLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAuthorizationActionMappingListInternal)AuthorizationActionMappings).NextLink = value ?? null; }

        /// <summary>List of the read-only actions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAuthorizationActionMapping[] AuthorizationActionMappingValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAuthorizationActionMappingListInternal)AuthorizationActionMappings).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAuthorizationActionMappingListInternal)AuthorizationActionMappings).Value = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="AuthorizationActionMappings" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAuthorizationActionMappingList _authorizationActionMappings;

        /// <summary>The read-only actions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAuthorizationActionMappingList AuthorizationActionMappings { get => (this._authorizationActionMappings = this._authorizationActionMappings ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.AuthorizationActionMappingList()); set => this._authorizationActionMappings = value; }

        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string EndpointNextLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderEndpointListInternal)Endpoints).NextLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderEndpointListInternal)Endpoints).NextLink = value ?? null; }

        /// <summary>List of the resource provider endpoints.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderEndpoint[] EndpointValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderEndpointListInternal)Endpoints).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderEndpointListInternal)Endpoints).Value = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Endpoints" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderEndpointList _endpoints;

        /// <summary>The resource provider endpoints.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderEndpointList Endpoints { get => (this._endpoints = this._endpoints ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ResourceProviderEndpointList()); set => this._endpoints = value; }

        /// <summary>Backing field for <see cref="InGlobalLocation" /> property.</summary>
        private bool? _inGlobalLocation;

        /// <summary>A value indicating whether the resource type is in global location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public bool? InGlobalLocation { get => this._inGlobalLocation; set => this._inGlobalLocation = value; }

        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string LinkedAccessCheckNextLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedAccessCheckListInternal)LinkedAccessChecks).NextLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedAccessCheckListInternal)LinkedAccessChecks).NextLink = value ?? null; }

        /// <summary>List of the linked access checks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedAccessCheck[] LinkedAccessCheckValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedAccessCheckListInternal)LinkedAccessChecks).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedAccessCheckListInternal)LinkedAccessChecks).Value = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="LinkedAccessChecks" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedAccessCheckList _linkedAccessChecks;

        /// <summary>The linked access checks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedAccessCheckList LinkedAccessChecks { get => (this._linkedAccessChecks = this._linkedAccessChecks ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.LinkedAccessCheckList()); set => this._linkedAccessChecks = value; }

        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string LinkedNotificationRuleNextLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedNotificationRuleListInternal)LinkedNotificationRules).NextLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedNotificationRuleListInternal)LinkedNotificationRules).NextLink = value ?? null; }

        /// <summary>List of the linked notification rules.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedNotificationRule[] LinkedNotificationRuleValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedNotificationRuleListInternal)LinkedNotificationRules).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedNotificationRuleListInternal)LinkedNotificationRules).Value = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="LinkedNotificationRules" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedNotificationRuleList _linkedNotificationRules;

        /// <summary>The linked notification rules.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedNotificationRuleList LinkedNotificationRules { get => (this._linkedNotificationRules = this._linkedNotificationRules ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.LinkedNotificationRuleList()); set => this._linkedNotificationRules = value; }

        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string LinkedOperationRuleNextLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedOperationRuleListInternal)LinkedOperationRules).NextLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedOperationRuleListInternal)LinkedOperationRules).NextLink = value ?? null; }

        /// <summary>List of the linked operation rules.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedOperationRule[] LinkedOperationRuleValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedOperationRuleListInternal)LinkedOperationRules).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedOperationRuleListInternal)LinkedOperationRules).Value = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="LinkedOperationRules" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedOperationRuleList _linkedOperationRules;

        /// <summary>The linked operation rules.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedOperationRuleList LinkedOperationRules { get => (this._linkedOperationRules = this._linkedOperationRules ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.LinkedOperationRuleList()); set => this._linkedOperationRules = value; }

        /// <summary>Backing field for <see cref="MarketplaceType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MarketplaceType? _marketplaceType;

        /// <summary>The resource type behavior in the marketplace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MarketplaceType? MarketplaceType { get => this._marketplaceType; set => this._marketplaceType = value; }

        /// <summary>Backing field for <see cref="MeteredResourceIds" /> property.</summary>
        private string[] _meteredResourceIds;

        /// <summary>The metered resource ids.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string[] MeteredResourceIds { get => this._meteredResourceIds; set => this._meteredResourceIds = value; }

        /// <summary>Internal Acessors for ApiProfiles</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApiProfileList Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceTypeInternal.ApiProfiles { get => (this._apiProfiles = this._apiProfiles ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ApiProfileList()); set { {_apiProfiles = value;} } }

        /// <summary>Internal Acessors for AuthorizationActionMappings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAuthorizationActionMappingList Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceTypeInternal.AuthorizationActionMappings { get => (this._authorizationActionMappings = this._authorizationActionMappings ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.AuthorizationActionMappingList()); set { {_authorizationActionMappings = value;} } }

        /// <summary>Internal Acessors for Endpoints</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderEndpointList Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceTypeInternal.Endpoints { get => (this._endpoints = this._endpoints ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ResourceProviderEndpointList()); set { {_endpoints = value;} } }

        /// <summary>Internal Acessors for LinkedAccessChecks</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedAccessCheckList Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceTypeInternal.LinkedAccessChecks { get => (this._linkedAccessChecks = this._linkedAccessChecks ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.LinkedAccessCheckList()); set { {_linkedAccessChecks = value;} } }

        /// <summary>Internal Acessors for LinkedNotificationRules</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedNotificationRuleList Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceTypeInternal.LinkedNotificationRules { get => (this._linkedNotificationRules = this._linkedNotificationRules ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.LinkedNotificationRuleList()); set { {_linkedNotificationRules = value;} } }

        /// <summary>Internal Acessors for LinkedOperationRules</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedOperationRuleList Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceTypeInternal.LinkedOperationRules { get => (this._linkedOperationRules = this._linkedOperationRules ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.LinkedOperationRuleList()); set { {_linkedOperationRules = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="ResourceDeletionPolicy" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceDeletionPolicy? _resourceDeletionPolicy;

        /// <summary>The resource deletion policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceDeletionPolicy? ResourceDeletionPolicy { get => this._resourceDeletionPolicy; set => this._resourceDeletionPolicy = value; }

        /// <summary>Backing field for <see cref="RoutingType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.RoutingType? _routingType;

        /// <summary>The resource routing type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.RoutingType? RoutingType { get => this._routingType; set => this._routingType = value; }

        /// <summary>Creates an new <see cref="ResourceType" /> instance.</summary>
        public ResourceType()
        {

        }
    }
    /// The resource type definition.
    public partial interface IResourceType :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The allowed unauthorized actions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The allowed unauthorized actions.",
        SerializedName = @"allowedUnauthorizedActions",
        PossibleTypes = new [] { typeof(string) })]
        string[] AllowedUnauthorizedActions { get; set; }
        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string ApiProfileNextLink { get; set; }
        /// <summary>List of the API profiles.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of the API profiles.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApiProfile) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApiProfile[] ApiProfileValue { get; set; }
        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string AuthorizationActionMappingNextLink { get; set; }
        /// <summary>List of the read-only actions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of the read-only actions.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAuthorizationActionMapping) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAuthorizationActionMapping[] AuthorizationActionMappingValue { get; set; }
        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string EndpointNextLink { get; set; }
        /// <summary>List of the resource provider endpoints.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of the resource provider endpoints.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderEndpoint) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderEndpoint[] EndpointValue { get; set; }
        /// <summary>A value indicating whether the resource type is in global location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether the resource type is in global location.",
        SerializedName = @"inGlobalLocation",
        PossibleTypes = new [] { typeof(bool) })]
        bool? InGlobalLocation { get; set; }
        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string LinkedAccessCheckNextLink { get; set; }
        /// <summary>List of the linked access checks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of the linked access checks.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedAccessCheck) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedAccessCheck[] LinkedAccessCheckValue { get; set; }
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
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedNotificationRule) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedNotificationRule[] LinkedNotificationRuleValue { get; set; }
        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string LinkedOperationRuleNextLink { get; set; }
        /// <summary>List of the linked operation rules.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of the linked operation rules.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedOperationRule) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedOperationRule[] LinkedOperationRuleValue { get; set; }
        /// <summary>The resource type behavior in the marketplace.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource type behavior in the marketplace.",
        SerializedName = @"marketplaceType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MarketplaceType) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MarketplaceType? MarketplaceType { get; set; }
        /// <summary>The metered resource ids.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The metered resource ids.",
        SerializedName = @"meteredResourceIds",
        PossibleTypes = new [] { typeof(string) })]
        string[] MeteredResourceIds { get; set; }
        /// <summary>The name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The resource deletion policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource deletion policy.",
        SerializedName = @"resourceDeletionPolicy",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceDeletionPolicy) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceDeletionPolicy? ResourceDeletionPolicy { get; set; }
        /// <summary>The resource routing type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource routing type.",
        SerializedName = @"routingType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.RoutingType) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.RoutingType? RoutingType { get; set; }

    }
    /// The resource type definition.
    internal partial interface IResourceTypeInternal

    {
        /// <summary>The allowed unauthorized actions.</summary>
        string[] AllowedUnauthorizedActions { get; set; }
        /// <summary>URI to next page.</summary>
        string ApiProfileNextLink { get; set; }
        /// <summary>List of the API profiles.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApiProfile[] ApiProfileValue { get; set; }
        /// <summary>The API profiles.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApiProfileList ApiProfiles { get; set; }
        /// <summary>URI to next page.</summary>
        string AuthorizationActionMappingNextLink { get; set; }
        /// <summary>List of the read-only actions.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAuthorizationActionMapping[] AuthorizationActionMappingValue { get; set; }
        /// <summary>The read-only actions.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAuthorizationActionMappingList AuthorizationActionMappings { get; set; }
        /// <summary>URI to next page.</summary>
        string EndpointNextLink { get; set; }
        /// <summary>List of the resource provider endpoints.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderEndpoint[] EndpointValue { get; set; }
        /// <summary>The resource provider endpoints.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderEndpointList Endpoints { get; set; }
        /// <summary>A value indicating whether the resource type is in global location.</summary>
        bool? InGlobalLocation { get; set; }
        /// <summary>URI to next page.</summary>
        string LinkedAccessCheckNextLink { get; set; }
        /// <summary>List of the linked access checks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedAccessCheck[] LinkedAccessCheckValue { get; set; }
        /// <summary>The linked access checks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedAccessCheckList LinkedAccessChecks { get; set; }
        /// <summary>URI to next page.</summary>
        string LinkedNotificationRuleNextLink { get; set; }
        /// <summary>List of the linked notification rules.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedNotificationRule[] LinkedNotificationRuleValue { get; set; }
        /// <summary>The linked notification rules.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedNotificationRuleList LinkedNotificationRules { get; set; }
        /// <summary>URI to next page.</summary>
        string LinkedOperationRuleNextLink { get; set; }
        /// <summary>List of the linked operation rules.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedOperationRule[] LinkedOperationRuleValue { get; set; }
        /// <summary>The linked operation rules.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ILinkedOperationRuleList LinkedOperationRules { get; set; }
        /// <summary>The resource type behavior in the marketplace.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MarketplaceType? MarketplaceType { get; set; }
        /// <summary>The metered resource ids.</summary>
        string[] MeteredResourceIds { get; set; }
        /// <summary>The name.</summary>
        string Name { get; set; }
        /// <summary>The resource deletion policy.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ResourceDeletionPolicy? ResourceDeletionPolicy { get; set; }
        /// <summary>The resource routing type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.RoutingType? RoutingType { get; set; }

    }
}