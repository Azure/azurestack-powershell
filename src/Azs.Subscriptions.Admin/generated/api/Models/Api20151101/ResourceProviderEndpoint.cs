namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>The API versions supported by the endpoint.</summary>
    public partial class ResourceProviderEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderEndpoint,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IResourceProviderEndpointInternal
    {

        /// <summary>Backing field for <see cref="ApiVersions" /> property.</summary>
        private string[] _apiVersions;

        /// <summary>The API versions supported by the endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string[] ApiVersions { get => this._apiVersions; set => this._apiVersions = value; }

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>The enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Backing field for <see cref="EndpointUri" /> property.</summary>
        private string _endpointUri;

        /// <summary>The endpoint uri.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string EndpointUri { get => this._endpointUri; set => this._endpointUri = value; }

        /// <summary>Backing field for <see cref="Timeout" /> property.</summary>
        private string _timeout;

        /// <summary>The timeout.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Timeout { get => this._timeout; set => this._timeout = value; }

        /// <summary>Creates an new <see cref="ResourceProviderEndpoint" /> instance.</summary>
        public ResourceProviderEndpoint()
        {

        }
    }
    /// The API versions supported by the endpoint.
    public partial interface IResourceProviderEndpoint :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The API versions supported by the endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The API versions supported by the endpoint.",
        SerializedName = @"apiVersions",
        PossibleTypes = new [] { typeof(string) })]
        string[] ApiVersions { get; set; }
        /// <summary>The enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The enabled.",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }
        /// <summary>The endpoint uri.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The endpoint uri.",
        SerializedName = @"endpointUri",
        PossibleTypes = new [] { typeof(string) })]
        string EndpointUri { get; set; }
        /// <summary>The timeout.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The timeout.",
        SerializedName = @"timeout",
        PossibleTypes = new [] { typeof(string) })]
        string Timeout { get; set; }

    }
    /// The API versions supported by the endpoint.
    internal partial interface IResourceProviderEndpointInternal

    {
        /// <summary>The API versions supported by the endpoint.</summary>
        string[] ApiVersions { get; set; }
        /// <summary>The enabled.</summary>
        bool? Enabled { get; set; }
        /// <summary>The endpoint uri.</summary>
        string EndpointUri { get; set; }
        /// <summary>The timeout.</summary>
        string Timeout { get; set; }

    }
}