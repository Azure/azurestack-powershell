namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>The linked resource access checks.</summary>
    public partial class AuthorizationActionMapping :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAuthorizationActionMapping,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAuthorizationActionMappingInternal
    {

        /// <summary>Backing field for <see cref="Desired" /> property.</summary>
        private string _desired;

        /// <summary>The desired action name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Desired { get => this._desired; set => this._desired = value; }

        /// <summary>Backing field for <see cref="Original" /> property.</summary>
        private string _original;

        /// <summary>The original action name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Original { get => this._original; set => this._original = value; }

        /// <summary>Creates an new <see cref="AuthorizationActionMapping" /> instance.</summary>
        public AuthorizationActionMapping()
        {

        }
    }
    /// The linked resource access checks.
    public partial interface IAuthorizationActionMapping :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The desired action name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The desired action name.",
        SerializedName = @"desired",
        PossibleTypes = new [] { typeof(string) })]
        string Desired { get; set; }
        /// <summary>The original action name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The original action name.",
        SerializedName = @"original",
        PossibleTypes = new [] { typeof(string) })]
        string Original { get; set; }

    }
    /// The linked resource access checks.
    internal partial interface IAuthorizationActionMappingInternal

    {
        /// <summary>The desired action name.</summary>
        string Desired { get; set; }
        /// <summary>The original action name.</summary>
        string Original { get; set; }

    }
}