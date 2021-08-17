namespace Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Extensions;

    /// <summary>Contains alert data.</summary>
    public partial class AlertModel :
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModel,
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal
    {

        /// <summary>Backing field for <see cref="AlertId" /> property.</summary>
        private string _alertId;

        /// <summary>Gets or sets the ID of the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string AlertId { get => this._alertId; set => this._alertId = value; }

        /// <summary>Backing field for <see cref="AlertProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelAlertProperties _alertProperty;

        /// <summary>Properties of the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelAlertProperties AlertProperty { get => (this._alertProperty = this._alertProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.AlertModelAlertProperties()); set => this._alertProperty = value; }

        /// <summary>Backing field for <see cref="ClosedByUserAlias" /> property.</summary>
        private string _closedByUserAlias;

        /// <summary>User alias who closed the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string ClosedByUserAlias { get => this._closedByUserAlias; set => this._closedByUserAlias = value; }

        /// <summary>Backing field for <see cref="ClosedTimestamp" /> property.</summary>
        private string _closedTimestamp;

        /// <summary>Timestamp when the alert was closed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string ClosedTimestamp { get => this._closedTimestamp; set => this._closedTimestamp = value; }

        /// <summary>Backing field for <see cref="CreatedTimestamp" /> property.</summary>
        private string _createdTimestamp;

        /// <summary>Timestamp when the alert was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string CreatedTimestamp { get => this._createdTimestamp; set => this._createdTimestamp = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IDictionary[] _description;

        /// <summary>Description of the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IDictionary[] Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="FaultId" /> property.</summary>
        private string _faultId;

        /// <summary>Gets or sets the fault ID of the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string FaultId { get => this._faultId; set => this._faultId = value; }

        /// <summary>Backing field for <see cref="FaultTypeId" /> property.</summary>
        private string _faultTypeId;

        /// <summary>Gets or sets the fault type ID of the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string FaultTypeId { get => this._faultTypeId; set => this._faultTypeId = value; }

        /// <summary>Backing field for <see cref="HasValidRemediationAction" /> property.</summary>
        private bool? _hasValidRemediationAction;

        /// <summary>Indicates if the alert can be remediated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public bool? HasValidRemediationAction { get => this._hasValidRemediationAction; set => this._hasValidRemediationAction = value; }

        /// <summary>Backing field for <see cref="ImpactedResourceDisplayName" /> property.</summary>
        private string _impactedResourceDisplayName;

        /// <summary>Display name for the impacted item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string ImpactedResourceDisplayName { get => this._impactedResourceDisplayName; set => this._impactedResourceDisplayName = value; }

        /// <summary>Backing field for <see cref="ImpactedResourceId" /> property.</summary>
        private string _impactedResourceId;

        /// <summary>Gets or sets the Resource ID for the impacted item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string ImpactedResourceId { get => this._impactedResourceId; set => this._impactedResourceId = value; }

        /// <summary>Backing field for <see cref="LastUpdatedTimestamp" /> property.</summary>
        private string _lastUpdatedTimestamp;

        /// <summary>Timestamp when the alert was last updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string LastUpdatedTimestamp { get => this._lastUpdatedTimestamp; set => this._lastUpdatedTimestamp = value; }

        /// <summary>Backing field for <see cref="Remediation" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IDictionary[] _remediation;

        /// <summary>Gets or sets the admin friendly remediation instructions for the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IDictionary[] Remediation { get => this._remediation; set => this._remediation = value; }

        /// <summary>Backing field for <see cref="ResourceProviderRegistrationId" /> property.</summary>
        private string _resourceProviderRegistrationId;

        /// <summary>Gets or sets the registration ID of the service the alert belongs to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string ResourceProviderRegistrationId { get => this._resourceProviderRegistrationId; set => this._resourceProviderRegistrationId = value; }

        /// <summary>Backing field for <see cref="ResourceRegistrationId" /> property.</summary>
        private string _resourceRegistrationId;

        /// <summary>
        /// Gets or sets the registration ID of the resource associated with the alert. If the alert is not associated with a resource,
        /// the resource registration ID is null.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string ResourceRegistrationId { get => this._resourceRegistrationId; set => this._resourceRegistrationId = value; }

        /// <summary>Backing field for <see cref="Severity" /> property.</summary>
        private string _severity;

        /// <summary>Severity of the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string Severity { get => this._severity; set => this._severity = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private string _state;

        /// <summary>State of the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string State { get => this._state; set => this._state = value; }

        /// <summary>Backing field for <see cref="Title" /> property.</summary>
        private string _title;

        /// <summary>Gets or sets the Resource ID for the impacted item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string Title { get => this._title; set => this._title = value; }

        /// <summary>Creates an new <see cref="AlertModel" /> instance.</summary>
        public AlertModel()
        {

        }
    }
    /// Contains alert data.
    public partial interface IAlertModel :
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the ID of the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the ID of the alert.",
        SerializedName = @"alertId",
        PossibleTypes = new [] { typeof(string) })]
        string AlertId { get; set; }
        /// <summary>Properties of the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Properties of the alert.",
        SerializedName = @"alertProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelAlertProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelAlertProperties AlertProperty { get; set; }
        /// <summary>User alias who closed the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"User alias who closed the alert.",
        SerializedName = @"closedByUserAlias",
        PossibleTypes = new [] { typeof(string) })]
        string ClosedByUserAlias { get; set; }
        /// <summary>Timestamp when the alert was closed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Timestamp when the alert was closed.",
        SerializedName = @"closedTimestamp",
        PossibleTypes = new [] { typeof(string) })]
        string ClosedTimestamp { get; set; }
        /// <summary>Timestamp when the alert was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Timestamp when the alert was created.",
        SerializedName = @"createdTimestamp",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedTimestamp { get; set; }
        /// <summary>Description of the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Description of the alert.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IDictionary) })]
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IDictionary[] Description { get; set; }
        /// <summary>Gets or sets the fault ID of the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the fault ID of the alert.",
        SerializedName = @"faultId",
        PossibleTypes = new [] { typeof(string) })]
        string FaultId { get; set; }
        /// <summary>Gets or sets the fault type ID of the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the fault type ID of the alert.",
        SerializedName = @"faultTypeId",
        PossibleTypes = new [] { typeof(string) })]
        string FaultTypeId { get; set; }
        /// <summary>Indicates if the alert can be remediated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Indicates if the alert can be remediated.",
        SerializedName = @"hasValidRemediationAction",
        PossibleTypes = new [] { typeof(bool) })]
        bool? HasValidRemediationAction { get; set; }
        /// <summary>Display name for the impacted item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name for the impacted item.",
        SerializedName = @"impactedResourceDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string ImpactedResourceDisplayName { get; set; }
        /// <summary>Gets or sets the Resource ID for the impacted item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the Resource ID for the impacted item.",
        SerializedName = @"impactedResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string ImpactedResourceId { get; set; }
        /// <summary>Timestamp when the alert was last updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Timestamp when the alert was last updated.",
        SerializedName = @"lastUpdatedTimestamp",
        PossibleTypes = new [] { typeof(string) })]
        string LastUpdatedTimestamp { get; set; }
        /// <summary>Gets or sets the admin friendly remediation instructions for the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the admin friendly remediation instructions for the alert.",
        SerializedName = @"remediation",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IDictionary) })]
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IDictionary[] Remediation { get; set; }
        /// <summary>Gets or sets the registration ID of the service the alert belongs to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the registration ID of the service the alert belongs to.",
        SerializedName = @"resourceProviderRegistrationId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceProviderRegistrationId { get; set; }
        /// <summary>
        /// Gets or sets the registration ID of the resource associated with the alert. If the alert is not associated with a resource,
        /// the resource registration ID is null.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the registration ID of the resource associated with the alert. If the alert is not associated with a resource, the resource registration ID is null.",
        SerializedName = @"resourceRegistrationId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceRegistrationId { get; set; }
        /// <summary>Severity of the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Severity of the alert.",
        SerializedName = @"severity",
        PossibleTypes = new [] { typeof(string) })]
        string Severity { get; set; }
        /// <summary>State of the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"State of the alert.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(string) })]
        string State { get; set; }
        /// <summary>Gets or sets the Resource ID for the impacted item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the Resource ID for the impacted item.",
        SerializedName = @"title",
        PossibleTypes = new [] { typeof(string) })]
        string Title { get; set; }

    }
    /// Contains alert data.
    internal partial interface IAlertModelInternal

    {
        /// <summary>Gets or sets the ID of the alert.</summary>
        string AlertId { get; set; }
        /// <summary>Properties of the alert.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelAlertProperties AlertProperty { get; set; }
        /// <summary>User alias who closed the alert.</summary>
        string ClosedByUserAlias { get; set; }
        /// <summary>Timestamp when the alert was closed.</summary>
        string ClosedTimestamp { get; set; }
        /// <summary>Timestamp when the alert was created.</summary>
        string CreatedTimestamp { get; set; }
        /// <summary>Description of the alert.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IDictionary[] Description { get; set; }
        /// <summary>Gets or sets the fault ID of the alert.</summary>
        string FaultId { get; set; }
        /// <summary>Gets or sets the fault type ID of the alert.</summary>
        string FaultTypeId { get; set; }
        /// <summary>Indicates if the alert can be remediated.</summary>
        bool? HasValidRemediationAction { get; set; }
        /// <summary>Display name for the impacted item.</summary>
        string ImpactedResourceDisplayName { get; set; }
        /// <summary>Gets or sets the Resource ID for the impacted item.</summary>
        string ImpactedResourceId { get; set; }
        /// <summary>Timestamp when the alert was last updated.</summary>
        string LastUpdatedTimestamp { get; set; }
        /// <summary>Gets or sets the admin friendly remediation instructions for the alert.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IDictionary[] Remediation { get; set; }
        /// <summary>Gets or sets the registration ID of the service the alert belongs to.</summary>
        string ResourceProviderRegistrationId { get; set; }
        /// <summary>
        /// Gets or sets the registration ID of the resource associated with the alert. If the alert is not associated with a resource,
        /// the resource registration ID is null.
        /// </summary>
        string ResourceRegistrationId { get; set; }
        /// <summary>Severity of the alert.</summary>
        string Severity { get; set; }
        /// <summary>State of the alert.</summary>
        string State { get; set; }
        /// <summary>Gets or sets the Resource ID for the impacted item.</summary>
        string Title { get; set; }

    }
}