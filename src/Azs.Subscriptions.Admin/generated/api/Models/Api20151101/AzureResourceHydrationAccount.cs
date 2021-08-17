namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>The API versions supported by the endpoint.</summary>
    public partial class AzureResourceHydrationAccount :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAzureResourceHydrationAccount,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAzureResourceHydrationAccountInternal
    {

        /// <summary>Backing field for <see cref="AccountName" /> property.</summary>
        private string _accountName;

        /// <summary>The account name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string AccountName { get => this._accountName; set => this._accountName = value; }

        /// <summary>Backing field for <see cref="EncryptedKey" /> property.</summary>
        private string _encryptedKey;

        /// <summary>The encrypted key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string EncryptedKey { get => this._encryptedKey; set => this._encryptedKey = value; }

        /// <summary>Backing field for <see cref="MaxChildResourceConsistencyJobLimit" /> property.</summary>
        private int? _maxChildResourceConsistencyJobLimit;

        /// <summary>The next child resource consistency job limit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public int? MaxChildResourceConsistencyJobLimit { get => this._maxChildResourceConsistencyJobLimit; set => this._maxChildResourceConsistencyJobLimit = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The subscription identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="AzureResourceHydrationAccount" /> instance.</summary>
        public AzureResourceHydrationAccount()
        {

        }
    }
    /// The API versions supported by the endpoint.
    public partial interface IAzureResourceHydrationAccount :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The account name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The account name.",
        SerializedName = @"accountName",
        PossibleTypes = new [] { typeof(string) })]
        string AccountName { get; set; }
        /// <summary>The encrypted key.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The encrypted key.",
        SerializedName = @"encryptedKey",
        PossibleTypes = new [] { typeof(string) })]
        string EncryptedKey { get; set; }
        /// <summary>The next child resource consistency job limit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The next child resource consistency job limit.",
        SerializedName = @"maxChildResourceConsistencyJobLimit",
        PossibleTypes = new [] { typeof(int) })]
        int? MaxChildResourceConsistencyJobLimit { get; set; }
        /// <summary>The subscription identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The subscription identifier.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }

    }
    /// The API versions supported by the endpoint.
    internal partial interface IAzureResourceHydrationAccountInternal

    {
        /// <summary>The account name.</summary>
        string AccountName { get; set; }
        /// <summary>The encrypted key.</summary>
        string EncryptedKey { get; set; }
        /// <summary>The next child resource consistency job limit.</summary>
        int? MaxChildResourceConsistencyJobLimit { get; set; }
        /// <summary>The subscription identifier.</summary>
        string SubscriptionId { get; set; }

    }
}