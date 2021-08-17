namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>Represents the acquisition of an add-on plan for a subscription.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.DoNotFormat]
    public partial class PlanAcquisition :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanAcquisition,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IPlanAcquisitionInternal
    {

        /// <summary>Backing field for <see cref="AcquisitionId" /> property.</summary>
        private string _acquisitionId;

        /// <summary>Acquisition identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string AcquisitionId { get => this._acquisitionId; set => this._acquisitionId = value; }

        /// <summary>Backing field for <see cref="AcquisitionTime" /> property.</summary>
        private global::System.DateTime? _acquisitionTime;

        /// <summary>Acquisition time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? AcquisitionTime { get => this._acquisitionTime; set => this._acquisitionTime = value; }

        /// <summary>Backing field for <see cref="ExternalReferenceId" /> property.</summary>
        private string _externalReferenceId;

        /// <summary>External reference identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string ExternalReferenceId { get => this._externalReferenceId; set => this._externalReferenceId = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Identifier in the tenant subscription context.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="PlanId" /> property.</summary>
        private string _planId;

        /// <summary>Plan identifier in the tenant subscription context.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public string PlanId { get => this._planId; set => this._planId = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ProvisioningState? _provisioningState;

        /// <summary>State of the provisioning.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; set => this._provisioningState = value; }

        /// <summary>Creates an new <see cref="PlanAcquisition" /> instance.</summary>
        public PlanAcquisition()
        {

        }
    }
    /// Represents the acquisition of an add-on plan for a subscription.
    public partial interface IPlanAcquisition :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Acquisition identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Acquisition identifier.",
        SerializedName = @"acquisitionId",
        PossibleTypes = new [] { typeof(string) })]
        string AcquisitionId { get; set; }
        /// <summary>Acquisition time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Acquisition time.",
        SerializedName = @"acquisitionTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? AcquisitionTime { get; set; }
        /// <summary>External reference identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"External reference identifier.",
        SerializedName = @"externalReferenceId",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalReferenceId { get; set; }
        /// <summary>Identifier in the tenant subscription context.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identifier in the tenant subscription context.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>Plan identifier in the tenant subscription context.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Plan identifier in the tenant subscription context.",
        SerializedName = @"planId",
        PossibleTypes = new [] { typeof(string) })]
        string PlanId { get; set; }
        /// <summary>State of the provisioning.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"State of the provisioning.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ProvisioningState? ProvisioningState { get; set; }

    }
    /// Represents the acquisition of an add-on plan for a subscription.
    internal partial interface IPlanAcquisitionInternal

    {
        /// <summary>Acquisition identifier.</summary>
        string AcquisitionId { get; set; }
        /// <summary>Acquisition time.</summary>
        global::System.DateTime? AcquisitionTime { get; set; }
        /// <summary>External reference identifier.</summary>
        string ExternalReferenceId { get; set; }
        /// <summary>Identifier in the tenant subscription context.</summary>
        string Id { get; set; }
        /// <summary>Plan identifier in the tenant subscription context.</summary>
        string PlanId { get; set; }
        /// <summary>State of the provisioning.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.ProvisioningState? ProvisioningState { get; set; }

    }
}