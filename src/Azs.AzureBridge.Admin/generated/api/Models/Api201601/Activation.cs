namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Extensions;

    /// <summary>Holds properties related to activation.</summary>
    public partial class Activation :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IActivation,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IActivationInternal
    {

        /// <summary>Backing field for <see cref="AzureRegistrationResourceIdentifier" /> property.</summary>
        private string _azureRegistrationResourceIdentifier;

        /// <summary>Azure registration resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string AzureRegistrationResourceIdentifier { get => this._azureRegistrationResourceIdentifier; set => this._azureRegistrationResourceIdentifier = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Name displayed for the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="Expiration" /> property.</summary>
        private string _expiration;

        /// <summary>The activation expiration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string Expiration { get => this._expiration; set => this._expiration = value; }

        /// <summary>Backing field for <see cref="MarketplaceSyndicationEnabled" /> property.</summary>
        private bool? _marketplaceSyndicationEnabled;

        /// <summary>Value indicating whether the marketplace syndication feature is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public bool? MarketplaceSyndicationEnabled { get => this._marketplaceSyndicationEnabled; set => this._marketplaceSyndicationEnabled = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState? _provisioningState;

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; set => this._provisioningState = value; }

        /// <summary>Backing field for <see cref="UsageReportingEnabled" /> property.</summary>
        private bool? _usageReportingEnabled;

        /// <summary>Value indicating whether the usage reporting feature is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public bool? UsageReportingEnabled { get => this._usageReportingEnabled; set => this._usageReportingEnabled = value; }

        /// <summary>Creates an new <see cref="Activation" /> instance.</summary>
        public Activation()
        {

        }
    }
    /// Holds properties related to activation.
    public partial interface IActivation :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Azure registration resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Azure registration resource identifier.",
        SerializedName = @"azureRegistrationResourceIdentifier",
        PossibleTypes = new [] { typeof(string) })]
        string AzureRegistrationResourceIdentifier { get; set; }
        /// <summary>Name displayed for the product.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name displayed for the product.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The activation expiration.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The activation expiration.",
        SerializedName = @"expiration",
        PossibleTypes = new [] { typeof(string) })]
        string Expiration { get; set; }
        /// <summary>Value indicating whether the marketplace syndication feature is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Value indicating whether the marketplace syndication feature is enabled.",
        SerializedName = @"marketplaceSyndicationEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? MarketplaceSyndicationEnabled { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Value indicating whether the usage reporting feature is enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Value indicating whether the usage reporting feature is enabled.",
        SerializedName = @"usageReportingEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UsageReportingEnabled { get; set; }

    }
    /// Holds properties related to activation.
    internal partial interface IActivationInternal

    {
        /// <summary>Azure registration resource identifier.</summary>
        string AzureRegistrationResourceIdentifier { get; set; }
        /// <summary>Name displayed for the product.</summary>
        string DisplayName { get; set; }
        /// <summary>The activation expiration.</summary>
        string Expiration { get; set; }
        /// <summary>Value indicating whether the marketplace syndication feature is enabled.</summary>
        bool? MarketplaceSyndicationEnabled { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Value indicating whether the usage reporting feature is enabled.</summary>
        bool? UsageReportingEnabled { get; set; }

    }
}