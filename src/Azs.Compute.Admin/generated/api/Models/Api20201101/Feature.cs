namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Subscription features that can be toggled.</summary>
    public partial class Feature :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeature,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeatureInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResource __crpResource = new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.CrpResource();

        /// <summary>List of subscription identifiers which have the feature enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public string[] EnabledTenantSubscriptionId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeaturePropertiesInternal)Property).EnabledTenantSubscriptionId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeaturePropertiesInternal)Property).EnabledTenantSubscriptionId = value ?? null /* arrayOf */; }

        /// <summary>The name of the feature.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public string FeatureName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeaturePropertiesInternal)Property).FeatureName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeaturePropertiesInternal)Property).FeatureName = value ?? null; }

        /// <summary>The state of the global feature.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.GlobalFeatureState? GlobalFeatureSettingGlobalFeatureState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeaturePropertiesInternal)Property).GlobalFeatureSettingGlobalFeatureState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeaturePropertiesInternal)Property).GlobalFeatureSettingGlobalFeatureState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.GlobalFeatureState)""); }

        /// <summary>ID of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Id; }

        /// <summary>Location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Location = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Type = value; }

        /// <summary>Internal Acessors for GlobalFeatureSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IGlobalFeatureSettings Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeatureInternal.GlobalFeatureSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeaturePropertiesInternal)Property).GlobalFeatureSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeaturePropertiesInternal)Property).GlobalFeatureSetting = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeatureProperties Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeatureInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.FeatureProperties()); set { {_property = value;} } }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeatureProperties _property;

        /// <summary>Feature properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeatureProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.FeatureProperties()); set => this._property = value; }

        /// <summary>Type of Resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal)__crpResource).Type; }

        /// <summary>Creates an new <see cref="Feature" /> instance.</summary>
        public Feature()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__crpResource), __crpResource);
            await eventListener.AssertObjectIsValid(nameof(__crpResource), __crpResource);
        }
    }
    /// Subscription features that can be toggled.
    public partial interface IFeature :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResource
    {
        /// <summary>List of subscription identifiers which have the feature enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of subscription identifiers which have the feature enabled.",
        SerializedName = @"enabledTenantSubscriptionIds",
        PossibleTypes = new [] { typeof(string) })]
        string[] EnabledTenantSubscriptionId { get; set; }
        /// <summary>The name of the feature.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the feature.",
        SerializedName = @"featureName",
        PossibleTypes = new [] { typeof(string) })]
        string FeatureName { get; set; }
        /// <summary>The state of the global feature.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The state of the global feature.",
        SerializedName = @"globalFeatureState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.GlobalFeatureState) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.GlobalFeatureState? GlobalFeatureSettingGlobalFeatureState { get; set; }

    }
    /// Subscription features that can be toggled.
    internal partial interface IFeatureInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.ICrpResourceInternal
    {
        /// <summary>List of subscription identifiers which have the feature enabled.</summary>
        string[] EnabledTenantSubscriptionId { get; set; }
        /// <summary>The name of the feature.</summary>
        string FeatureName { get; set; }
        /// <summary>Higher-priority global feature flags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IGlobalFeatureSettings GlobalFeatureSetting { get; set; }
        /// <summary>The state of the global feature.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.GlobalFeatureState? GlobalFeatureSettingGlobalFeatureState { get; set; }
        /// <summary>Feature properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeatureProperties Property { get; set; }

    }
}