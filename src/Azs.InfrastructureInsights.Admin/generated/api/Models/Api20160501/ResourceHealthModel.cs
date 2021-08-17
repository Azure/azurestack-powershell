namespace Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Extensions;

    /// <summary>Health information related to a resource.</summary>
    public partial class ResourceHealthModel :
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IResourceHealthModel,
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IResourceHealthModelInternal,
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealth"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealth __baseHealth = new Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.BaseHealth();

        /// <summary>Alert summary.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IAlertSummary AlertSummary { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal)__baseHealth).AlertSummary; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal)__baseHealth).AlertSummary = value ?? null /* model class */; }

        /// <summary>The number of critical alerts for the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inherited)]
        public int? AlertSummaryCriticalAlertCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal)__baseHealth).AlertSummaryCriticalAlertCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal)__baseHealth).AlertSummaryCriticalAlertCount = value ?? default(int); }

        /// <summary>The number of warning alerts for the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inherited)]
        public int? AlertSummaryWarningAlertCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal)__baseHealth).AlertSummaryWarningAlertCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal)__baseHealth).AlertSummaryWarningAlertCount = value ?? default(int); }

        /// <summary>Health state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inherited)]
        public string HealthState { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal)__baseHealth).HealthState; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal)__baseHealth).HealthState = value ?? null; }

        /// <summary>Namespace of the health resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inherited)]
        public string Namespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal)__baseHealth).Namespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal)__baseHealth).Namespace = value ?? null; }

        /// <summary>Registration ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inherited)]
        public string RegistrationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal)__baseHealth).RegistrationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal)__baseHealth).RegistrationId = value ?? null; }

        /// <summary>Backing field for <see cref="ResourceDisplayName" /> property.</summary>
        private string _resourceDisplayName;

        /// <summary>Resource display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string ResourceDisplayName { get => this._resourceDisplayName; set => this._resourceDisplayName = value; }

        /// <summary>Backing field for <see cref="ResourceLocation" /> property.</summary>
        private string _resourceLocation;

        /// <summary>Resource location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string ResourceLocation { get => this._resourceLocation; set => this._resourceLocation = value; }

        /// <summary>Backing field for <see cref="ResourceName" /> property.</summary>
        private string _resourceName;

        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string ResourceName { get => this._resourceName; set => this._resourceName = value; }

        /// <summary>Backing field for <see cref="ResourceType" /> property.</summary>
        private string _resourceType;

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string ResourceType { get => this._resourceType; set => this._resourceType = value; }

        /// <summary>Backing field for <see cref="ResourceUri" /> property.</summary>
        private string _resourceUri;

        /// <summary>Gets or sets the resource URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string ResourceUri { get => this._resourceUri; set => this._resourceUri = value; }

        /// <summary>Route prefix.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inherited)]
        public string RoutePrefix { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal)__baseHealth).RoutePrefix; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal)__baseHealth).RoutePrefix = value ?? null; }

        /// <summary>Backing field for <see cref="RpRegistrationId" /> property.</summary>
        private string _rpRegistrationId;

        /// <summary>Gets or sets the resource provider registration ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string RpRegistrationId { get => this._rpRegistrationId; set => this._rpRegistrationId = value; }

        /// <summary>Backing field for <see cref="UsageMetric" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IUsageMetrics[] _usageMetric;

        /// <summary>Usage metrics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IUsageMetrics[] UsageMetric { get => this._usageMetric; set => this._usageMetric = value; }

        /// <summary>Creates an new <see cref="ResourceHealthModel" /> instance.</summary>
        public ResourceHealthModel()
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
            await eventListener.AssertNotNull(nameof(__baseHealth), __baseHealth);
            await eventListener.AssertObjectIsValid(nameof(__baseHealth), __baseHealth);
        }
    }
    /// Health information related to a resource.
    public partial interface IResourceHealthModel :
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealth
    {
        /// <summary>Resource display name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource display name.",
        SerializedName = @"resourceDisplayName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceDisplayName { get; set; }
        /// <summary>Resource location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource location.",
        SerializedName = @"resourceLocation",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceLocation { get; set; }
        /// <summary>Resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource name.",
        SerializedName = @"resourceName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceName { get; set; }
        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Resource type.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceType { get; set; }
        /// <summary>Gets or sets the resource URI.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the resource URI.",
        SerializedName = @"resourceURI",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceUri { get; set; }
        /// <summary>Gets or sets the resource provider registration ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the resource provider registration ID.",
        SerializedName = @"rpRegistrationId",
        PossibleTypes = new [] { typeof(string) })]
        string RpRegistrationId { get; set; }
        /// <summary>Usage metrics.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Usage metrics.",
        SerializedName = @"usageMetrics",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IUsageMetrics) })]
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IUsageMetrics[] UsageMetric { get; set; }

    }
    /// Health information related to a resource.
    internal partial interface IResourceHealthModelInternal :
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal
    {
        /// <summary>Resource display name.</summary>
        string ResourceDisplayName { get; set; }
        /// <summary>Resource location.</summary>
        string ResourceLocation { get; set; }
        /// <summary>Resource name.</summary>
        string ResourceName { get; set; }
        /// <summary>Resource type.</summary>
        string ResourceType { get; set; }
        /// <summary>Gets or sets the resource URI.</summary>
        string ResourceUri { get; set; }
        /// <summary>Gets or sets the resource provider registration ID.</summary>
        string RpRegistrationId { get; set; }
        /// <summary>Usage metrics.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IUsageMetrics[] UsageMetric { get; set; }

    }
}