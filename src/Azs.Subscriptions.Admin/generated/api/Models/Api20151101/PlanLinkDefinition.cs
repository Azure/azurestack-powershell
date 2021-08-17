namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>Definition for linking and unlinking plans to offers.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
    public partial class PlanLinkDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanLinkDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanLinkDefinitionInternal
    {

        /// <summary>Backing field for <see cref="MaxAcquisitionCount" /> property.</summary>
        private int? _maxAcquisitionCount;

        /// <summary>The maximum acquisition count by subscribers</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public int? MaxAcquisitionCount { get => this._maxAcquisitionCount; set => this._maxAcquisitionCount = value; }

        /// <summary>Backing field for <see cref="PlanLinkType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.PlanLinkType? _planLinkType;

        /// <summary>Type of the plan link.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.PlanLinkType? PlanLinkType { get => this._planLinkType; set => this._planLinkType = value; }

        /// <summary>Backing field for <see cref="PlanName" /> property.</summary>
        private string _planName;

        /// <summary>Name of the plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string PlanName { get => this._planName; set => this._planName = value; }

        /// <summary>Creates an new <see cref="PlanLinkDefinition" /> instance.</summary>
        public PlanLinkDefinition()
        {

        }
    }
    /// Definition for linking and unlinking plans to offers.
    public partial interface IPlanLinkDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The maximum acquisition count by subscribers</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The maximum acquisition count by subscribers",
        SerializedName = @"maxAcquisitionCount",
        PossibleTypes = new [] { typeof(int) })]
        int? MaxAcquisitionCount { get; set; }
        /// <summary>Type of the plan link.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Type of the plan link.",
        SerializedName = @"planLinkType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.PlanLinkType) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.PlanLinkType? PlanLinkType { get; set; }
        /// <summary>Name of the plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the plan.",
        SerializedName = @"planName",
        PossibleTypes = new [] { typeof(string) })]
        string PlanName { get; set; }

    }
    /// Definition for linking and unlinking plans to offers.
    internal partial interface IPlanLinkDefinitionInternal

    {
        /// <summary>The maximum acquisition count by subscribers</summary>
        int? MaxAcquisitionCount { get; set; }
        /// <summary>Type of the plan link.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.PlanLinkType? PlanLinkType { get; set; }
        /// <summary>Name of the plan.</summary>
        string PlanName { get; set; }

    }
}