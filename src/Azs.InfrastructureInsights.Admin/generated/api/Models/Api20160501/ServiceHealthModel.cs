namespace Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Extensions;

    /// <summary>Holds information about the health of a service.</summary>
    public partial class ServiceHealthModel :
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IServiceHealthModel,
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IServiceHealthModelInternal,
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

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Name of the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Health state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inherited)]
        public string HealthState { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal)__baseHealth).HealthState; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal)__baseHealth).HealthState = value ?? null; }

        /// <summary>Backing field for <see cref="InfraUri" /> property.</summary>
        private string _infraUri;

        /// <summary>The route prefix to the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string InfraUri { get => this._infraUri; set => this._infraUri = value; }

        /// <summary>Namespace of the health resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inherited)]
        public string Namespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal)__baseHealth).Namespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal)__baseHealth).Namespace = value ?? null; }

        /// <summary>Registration ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inherited)]
        public string RegistrationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal)__baseHealth).RegistrationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal)__baseHealth).RegistrationId = value ?? null; }

        /// <summary>Route prefix.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Inherited)]
        public string RoutePrefix { get => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal)__baseHealth).RoutePrefix; set => ((Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal)__baseHealth).RoutePrefix = value ?? null; }

        /// <summary>Backing field for <see cref="ServiceLocation" /> property.</summary>
        private string _serviceLocation;

        /// <summary>Location of the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string ServiceLocation { get => this._serviceLocation; set => this._serviceLocation = value; }

        /// <summary>Creates an new <see cref="ServiceHealthModel" /> instance.</summary>
        public ServiceHealthModel()
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
    /// Holds information about the health of a service.
    public partial interface IServiceHealthModel :
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealth
    {
        /// <summary>Name of the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the service.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The route prefix to the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The route prefix to the service.",
        SerializedName = @"infraURI",
        PossibleTypes = new [] { typeof(string) })]
        string InfraUri { get; set; }
        /// <summary>Location of the service.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Location of the service.",
        SerializedName = @"serviceLocation",
        PossibleTypes = new [] { typeof(string) })]
        string ServiceLocation { get; set; }

    }
    /// Holds information about the health of a service.
    internal partial interface IServiceHealthModelInternal :
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IBaseHealthInternal
    {
        /// <summary>Name of the service.</summary>
        string DisplayName { get; set; }
        /// <summary>The route prefix to the service.</summary>
        string InfraUri { get; set; }
        /// <summary>Location of the service.</summary>
        string ServiceLocation { get; set; }

    }
}