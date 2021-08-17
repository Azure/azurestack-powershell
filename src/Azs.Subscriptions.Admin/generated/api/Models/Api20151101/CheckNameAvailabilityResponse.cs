namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>The check name availability response definition</summary>
    public partial class CheckNameAvailabilityResponse :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ICheckNameAvailabilityResponse,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ICheckNameAvailabilityResponseInternal
    {

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>The message explaining the reason.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Backing field for <see cref="NameAvailable" /> property.</summary>
        private bool? _nameAvailable;

        /// <summary>A value indicating whether the name is available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public bool? NameAvailable { get => this._nameAvailable; set => this._nameAvailable = value; }

        /// <summary>Backing field for <see cref="Reason" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.NameUnavailabilityReason? _reason;

        /// <summary>The reason for the unavailability of the name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.NameUnavailabilityReason? Reason { get => this._reason; set => this._reason = value; }

        /// <summary>Creates an new <see cref="CheckNameAvailabilityResponse" /> instance.</summary>
        public CheckNameAvailabilityResponse()
        {

        }
    }
    /// The check name availability response definition
    public partial interface ICheckNameAvailabilityResponse :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The message explaining the reason.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The message explaining the reason.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>A value indicating whether the name is available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether the name is available.",
        SerializedName = @"nameAvailable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? NameAvailable { get; set; }
        /// <summary>The reason for the unavailability of the name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The reason for the unavailability of the name.",
        SerializedName = @"reason",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.NameUnavailabilityReason) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.NameUnavailabilityReason? Reason { get; set; }

    }
    /// The check name availability response definition
    internal partial interface ICheckNameAvailabilityResponseInternal

    {
        /// <summary>The message explaining the reason.</summary>
        string Message { get; set; }
        /// <summary>A value indicating whether the name is available.</summary>
        bool? NameAvailable { get; set; }
        /// <summary>The reason for the unavailability of the name.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.NameUnavailabilityReason? Reason { get; set; }

    }
}