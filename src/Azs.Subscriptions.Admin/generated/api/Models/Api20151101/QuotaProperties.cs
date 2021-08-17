namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>Quotas for DelegatedProviders.</summary>
    public partial class QuotaProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IQuotaProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IQuotaPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AllowCustomPortalBranding" /> property.</summary>
        private bool? _allowCustomPortalBranding;

        /// <summary>Value indicating whether custom portal branding is allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public bool? AllowCustomPortalBranding { get => this._allowCustomPortalBranding; set => this._allowCustomPortalBranding = value; }

        /// <summary>Creates an new <see cref="QuotaProperties" /> instance.</summary>
        public QuotaProperties()
        {

        }
    }
    /// Quotas for DelegatedProviders.
    public partial interface IQuotaProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Value indicating whether custom portal branding is allowed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Value indicating whether custom portal branding is allowed.",
        SerializedName = @"allowCustomPortalBranding",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AllowCustomPortalBranding { get; set; }

    }
    /// Quotas for DelegatedProviders.
    internal partial interface IQuotaPropertiesInternal

    {
        /// <summary>Value indicating whether custom portal branding is allowed.</summary>
        bool? AllowCustomPortalBranding { get; set; }

    }
}