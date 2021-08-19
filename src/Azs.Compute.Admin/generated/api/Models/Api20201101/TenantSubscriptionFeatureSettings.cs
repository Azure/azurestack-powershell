namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>The feature settings for the tenant subscription.</summary>
    public partial class TenantSubscriptionFeatureSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.ITenantSubscriptionFeatureSettings,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.ITenantSubscriptionFeatureSettingsInternal
    {

        /// <summary>Backing field for <see cref="TenantSubscriptionId" /> property.</summary>
        private string _tenantSubscriptionId;

        /// <summary>The tenant subscription identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string TenantSubscriptionId { get => this._tenantSubscriptionId; set => this._tenantSubscriptionId = value; }

        /// <summary>Creates an new <see cref="TenantSubscriptionFeatureSettings" /> instance.</summary>
        public TenantSubscriptionFeatureSettings()
        {

        }
    }
    /// The feature settings for the tenant subscription.
    public partial interface ITenantSubscriptionFeatureSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The tenant subscription identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tenant subscription identifier.",
        SerializedName = @"tenantSubscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string TenantSubscriptionId { get; set; }

    }
    /// The feature settings for the tenant subscription.
    internal partial interface ITenantSubscriptionFeatureSettingsInternal

    {
        /// <summary>The tenant subscription identifier.</summary>
        string TenantSubscriptionId { get; set; }

    }
}