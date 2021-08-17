namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>The move subscriptions action definition</summary>
    public partial class MoveSubscriptionsDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMoveSubscriptionsDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMoveSubscriptionsDefinitionInternal
    {

        /// <summary>Backing field for <see cref="Resources" /> property.</summary>
        private string[] _resources;

        /// <summary>A collection of subscriptions to move to the target delegated provider offer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string[] Resources { get => this._resources; set => this._resources = value; }

        /// <summary>Backing field for <see cref="TargetDelegatedProviderOffer" /> property.</summary>
        private string _targetDelegatedProviderOffer;

        /// <summary>
        /// The delegated provider offer identifier (from the Admin context) that the subscriptions to be moved to.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string TargetDelegatedProviderOffer { get => this._targetDelegatedProviderOffer; set => this._targetDelegatedProviderOffer = value; }

        /// <summary>Creates an new <see cref="MoveSubscriptionsDefinition" /> instance.</summary>
        public MoveSubscriptionsDefinition()
        {

        }
    }
    /// The move subscriptions action definition
    public partial interface IMoveSubscriptionsDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>A collection of subscriptions to move to the target delegated provider offer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"A collection of subscriptions to move to the target delegated provider offer.",
        SerializedName = @"resources",
        PossibleTypes = new [] { typeof(string) })]
        string[] Resources { get; set; }
        /// <summary>
        /// The delegated provider offer identifier (from the Admin context) that the subscriptions to be moved to.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The delegated provider offer identifier (from the Admin context) that the subscriptions to be moved to.",
        SerializedName = @"targetDelegatedProviderOffer",
        PossibleTypes = new [] { typeof(string) })]
        string TargetDelegatedProviderOffer { get; set; }

    }
    /// The move subscriptions action definition
    internal partial interface IMoveSubscriptionsDefinitionInternal

    {
        /// <summary>A collection of subscriptions to move to the target delegated provider offer.</summary>
        string[] Resources { get; set; }
        /// <summary>
        /// The delegated provider offer identifier (from the Admin context) that the subscriptions to be moved to.
        /// </summary>
        string TargetDelegatedProviderOffer { get; set; }

    }
}