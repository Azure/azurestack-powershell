namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>The fan-out linked notification rule.</summary>
    public partial class FanoutLinkedNotificationRule :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IFanoutLinkedNotificationRule,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IFanoutLinkedNotificationRuleInternal
    {

        /// <summary>Backing field for <see cref="Actions" /> property.</summary>
        private string[] _actions;

        /// <summary>The list of actions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string[] Actions { get => this._actions; set => this._actions = value; }

        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public string EndpointNextLink { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderEndpointListInternal)Endpoints).NextLink; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderEndpointListInternal)Endpoints).NextLink = value ?? null; }

        /// <summary>List of the resource provider endpoints.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderEndpoint[] EndpointValue { get => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderEndpointListInternal)Endpoints).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderEndpointListInternal)Endpoints).Value = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Endpoints" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderEndpointList _endpoints;

        /// <summary>The list of endpoint uris.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderEndpointList Endpoints { get => (this._endpoints = this._endpoints ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ResourceProviderEndpointList()); set => this._endpoints = value; }

        /// <summary>Internal Acessors for Endpoints</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderEndpointList Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IFanoutLinkedNotificationRuleInternal.Endpoints { get => (this._endpoints = this._endpoints ?? new Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ResourceProviderEndpointList()); set { {_endpoints = value;} } }

        /// <summary>Creates an new <see cref="FanoutLinkedNotificationRule" /> instance.</summary>
        public FanoutLinkedNotificationRule()
        {

        }
    }
    /// The fan-out linked notification rule.
    public partial interface IFanoutLinkedNotificationRule :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The list of actions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of actions.",
        SerializedName = @"actions",
        PossibleTypes = new [] { typeof(string) })]
        string[] Actions { get; set; }
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

    }
    /// The fan-out linked notification rule.
    internal partial interface IFanoutLinkedNotificationRuleInternal

    {
        /// <summary>The list of actions.</summary>
        string[] Actions { get; set; }
        /// <summary>URI to next page.</summary>
        string EndpointNextLink { get; set; }
        /// <summary>List of the resource provider endpoints.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderEndpoint[] EndpointValue { get; set; }
        /// <summary>The list of endpoint uris.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderEndpointList Endpoints { get; set; }

    }
}