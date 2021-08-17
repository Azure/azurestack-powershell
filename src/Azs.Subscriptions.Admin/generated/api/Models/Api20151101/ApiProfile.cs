namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>Represents the API profile.</summary>
    public partial class ApiProfile :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApiProfile,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApiProfileInternal
    {

        /// <summary>Backing field for <see cref="ApiVersion" /> property.</summary>
        private string _apiVersion;

        /// <summary>The API version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string ApiVersion { get => this._apiVersion; set => this._apiVersion = value; }

        /// <summary>Backing field for <see cref="ProfileVersion" /> property.</summary>
        private string _profileVersion;

        /// <summary>The profile version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string ProfileVersion { get => this._profileVersion; set => this._profileVersion = value; }

        /// <summary>Creates an new <see cref="ApiProfile" /> instance.</summary>
        public ApiProfile()
        {

        }
    }
    /// Represents the API profile.
    public partial interface IApiProfile :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The API version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The API version.",
        SerializedName = @"apiVersion",
        PossibleTypes = new [] { typeof(string) })]
        string ApiVersion { get; set; }
        /// <summary>The profile version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The profile version.",
        SerializedName = @"profileVersion",
        PossibleTypes = new [] { typeof(string) })]
        string ProfileVersion { get; set; }

    }
    /// Represents the API profile.
    internal partial interface IApiProfileInternal

    {
        /// <summary>The API version.</summary>
        string ApiVersion { get; set; }
        /// <summary>The profile version.</summary>
        string ProfileVersion { get; set; }

    }
}