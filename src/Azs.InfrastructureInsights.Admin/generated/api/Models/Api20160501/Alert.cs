namespace Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Extensions;

    /// <summary>This object represents an alert resource.</summary>
    public partial class Alert :
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlert,
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertInternal,
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.ITrackedResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.ITrackedResource __trackedResource = new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.TrackedResource();

        /// <summary>Gets or sets the ID of the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.DoNotFormat]
        public string AlertId { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).AlertId; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).AlertId = value ?? null; }

        /// <summary>Properties of the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelAlertProperties AlertProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).AlertProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).AlertProperty = value ?? null /* model class */; }

        /// <summary>User alias who closed the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.DoNotFormat]
        public string ClosedByUserAlias { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).ClosedByUserAlias; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).ClosedByUserAlias = value ?? null; }

        /// <summary>Timestamp when the alert was closed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.FormatTable(Index = 5, Label = @"Closed", Width = 20)]
        public string ClosedTimestamp { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).ClosedTimestamp; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).ClosedTimestamp = value ?? null; }

        /// <summary>Timestamp when the alert was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.FormatTable(Index = 4, Label = @"Created")]
        public string CreatedTimestamp { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).CreatedTimestamp; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).CreatedTimestamp = value ?? null; }

        /// <summary>Description of the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IDictionary[] Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).Description = value ?? null /* arrayOf */; }

        /// <summary>Gets or sets the fault ID of the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.DoNotFormat]
        public string FaultId { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).FaultId; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).FaultId = value ?? null; }

        /// <summary>Gets or sets the fault type ID of the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.DoNotFormat]
        public string FaultTypeId { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).FaultTypeId; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).FaultTypeId = value ?? null; }

        /// <summary>Indicates if the alert can be remediated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.DoNotFormat]
        public bool? HasValidRemediationAction { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).HasValidRemediationAction; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).HasValidRemediationAction = value ?? default(bool); }

        /// <summary>Fully qualified resource Id for the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IResourceInternal)__trackedResource).Id; }

        /// <summary>Display name for the impacted item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.FormatTable(Index = 3, Label = @"Impacted Resource", Width = 24)]
        public string ImpactedResourceDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).ImpactedResourceDisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).ImpactedResourceDisplayName = value ?? null; }

        /// <summary>Gets or sets the Resource ID for the impacted item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.DoNotFormat]
        public string ImpactedResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).ImpactedResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).ImpactedResourceId = value ?? null; }

        /// <summary>Timestamp when the alert was last updated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.DoNotFormat]
        public string LastUpdatedTimestamp { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).LastUpdatedTimestamp; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).LastUpdatedTimestamp = value ?? null; }

        /// <summary>The Azure Region where the resource lives</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.DoNotFormat]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.ITrackedResourceInternal)__trackedResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.ITrackedResourceInternal)__trackedResource).Location = value ?? null; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModel Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.AlertModel()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IResourceInternal)__trackedResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IResourceInternal)__trackedResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IResourceInternal)__trackedResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IResourceInternal)__trackedResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IResourceInternal)__trackedResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IResourceInternal)__trackedResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.DoNotFormat]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IResourceInternal)__trackedResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModel _property;

        /// <summary>Contains information related to alerts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModel Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.AlertModel()); set => this._property = value; }

        /// <summary>Gets or sets the admin friendly remediation instructions for the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IDictionary[] Remediation { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).Remediation; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).Remediation = value ?? null /* arrayOf */; }

        /// <summary>Gets or sets the registration ID of the service the alert belongs to.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.DoNotFormat]
        public string ResourceProviderRegistrationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).ResourceProviderRegistrationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).ResourceProviderRegistrationId = value ?? null; }

        /// <summary>
        /// Gets or sets the registration ID of the resource associated with the alert. If the alert is not associated with a resource,
        /// the resource registration ID is null.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.DoNotFormat]
        public string ResourceRegistrationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).ResourceRegistrationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).ResourceRegistrationId = value ?? null; }

        /// <summary>Severity of the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.FormatTable(Index = 2, Width = 10)]
        public string Severity { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).Severity; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).Severity = value ?? null; }

        /// <summary>State of the alert.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.FormatTable(Index = 1, Width = 10)]
        public string State { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).State = value ?? null; }

        /// <summary>Resource tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.ITrackedResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.ITrackedResourceInternal)__trackedResource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.ITrackedResourceInternal)__trackedResource).Tag = value ?? null /* model class */; }

        /// <summary>Gets or sets the Resource ID for the impacted item.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.FormatTable(Index = 0, Width = 24)]
        public string Title { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).Title; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModelInternal)Property).Title = value ?? null; }

        /// <summary>The type of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IResourceInternal)__trackedResource).Type; }

        /// <summary>Creates an new <see cref="Alert" /> instance.</summary>
        public Alert()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__trackedResource), __trackedResource);
            await eventListener.AssertObjectIsValid(nameof(__trackedResource), __trackedResource);
        }
    }
    /// This object represents an alert resource.
    public partial interface IAlert :
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.ITrackedResource
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
    /// This object represents an alert resource.
    internal partial interface IAlertInternal :
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.ITrackedResourceInternal
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
        /// <summary>Contains information related to alerts.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertModel Property { get; set; }
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