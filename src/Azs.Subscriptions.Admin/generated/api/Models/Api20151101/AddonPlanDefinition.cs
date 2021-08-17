namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>Contains the name of the desired plan to be linked or unlinked from an offer.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
    public partial class AddonPlanDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAddonPlanDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAddonPlanDefinitionInternal
    {

        /// <summary>Backing field for <see cref="MaxAcquisitionCount" /> property.</summary>
        private int? _maxAcquisitionCount;

        /// <summary>
        /// Maximum number of instances that can be acquired by a single subscription. If not specified, the assumed value is 1.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public int? MaxAcquisitionCount { get => this._maxAcquisitionCount; set => this._maxAcquisitionCount = value; }

        /// <summary>Backing field for <see cref="PlanId" /> property.</summary>
        private string _planId;

        /// <summary>Plan identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string PlanId { get => this._planId; set => this._planId = value; }

        /// <summary>Creates an new <see cref="AddonPlanDefinition" /> instance.</summary>
        public AddonPlanDefinition()
        {

        }
    }
    /// Contains the name of the desired plan to be linked or unlinked from an offer.
    public partial interface IAddonPlanDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Maximum number of instances that can be acquired by a single subscription. If not specified, the assumed value is 1.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum number of instances that can be acquired by a single subscription. If not specified, the assumed value is 1.",
        SerializedName = @"maxAcquisitionCount",
        PossibleTypes = new [] { typeof(int) })]
        int? MaxAcquisitionCount { get; set; }
        /// <summary>Plan identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Plan identifier.",
        SerializedName = @"planId",
        PossibleTypes = new [] { typeof(string) })]
        string PlanId { get; set; }

    }
    /// Contains the name of the desired plan to be linked or unlinked from an offer.
    internal partial interface IAddonPlanDefinitionInternal

    {
        /// <summary>
        /// Maximum number of instances that can be acquired by a single subscription. If not specified, the assumed value is 1.
        /// </summary>
        int? MaxAcquisitionCount { get; set; }
        /// <summary>Plan identifier.</summary>
        string PlanId { get; set; }

    }
}