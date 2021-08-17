namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>The extension properties definition.</summary>
    public partial class ExtensionPropertiesDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionPropertiesDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IExtensionPropertiesDefinitionInternal
    {

        /// <summary>Backing field for <see cref="QuotaCreateBladeName" /> property.</summary>
        private string _quotaCreateBladeName;

        /// <summary>The quota create blade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string QuotaCreateBladeName { get => this._quotaCreateBladeName; set => this._quotaCreateBladeName = value; }

        /// <summary>Backing field for <see cref="ResourceProviderDashboardBladeName" /> property.</summary>
        private string _resourceProviderDashboardBladeName;

        /// <summary>The resource provider dashboard blade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string ResourceProviderDashboardBladeName { get => this._resourceProviderDashboardBladeName; set => this._resourceProviderDashboardBladeName = value; }

        /// <summary>Creates an new <see cref="ExtensionPropertiesDefinition" /> instance.</summary>
        public ExtensionPropertiesDefinition()
        {

        }
    }
    /// The extension properties definition.
    public partial interface IExtensionPropertiesDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The quota create blade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The quota create blade.",
        SerializedName = @"quotaCreateBladeName",
        PossibleTypes = new [] { typeof(string) })]
        string QuotaCreateBladeName { get; set; }
        /// <summary>The resource provider dashboard blade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resource provider dashboard blade.",
        SerializedName = @"resourceProviderDashboardBladeName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceProviderDashboardBladeName { get; set; }

    }
    /// The extension properties definition.
    internal partial interface IExtensionPropertiesDefinitionInternal

    {
        /// <summary>The quota create blade.</summary>
        string QuotaCreateBladeName { get; set; }
        /// <summary>The resource provider dashboard blade.</summary>
        string ResourceProviderDashboardBladeName { get; set; }

    }
}