namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Properties of features.</summary>
    public partial class FeatureProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeatureProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeaturePropertiesInternal
    {

        /// <summary>Backing field for <see cref="EnabledTenantSubscriptionId" /> property.</summary>
        private string[] _enabledTenantSubscriptionId;

        /// <summary>List of subscription identifiers which have the feature enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string[] EnabledTenantSubscriptionId { get => this._enabledTenantSubscriptionId; set => this._enabledTenantSubscriptionId = value; }

        /// <summary>Backing field for <see cref="FeatureName" /> property.</summary>
        private string _featureName;

        /// <summary>The name of the feature.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string FeatureName { get => this._featureName; set => this._featureName = value; }

        /// <summary>Backing field for <see cref="GlobalFeatureSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IGlobalFeatureSettings _globalFeatureSetting;

        /// <summary>Higher-priority global feature flags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IGlobalFeatureSettings GlobalFeatureSetting { get => (this._globalFeatureSetting = this._globalFeatureSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.GlobalFeatureSettings()); set => this._globalFeatureSetting = value; }

        /// <summary>The state of the global feature.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.GlobalFeatureState? GlobalFeatureSettingGlobalFeatureState { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IGlobalFeatureSettingsInternal)GlobalFeatureSetting).GlobalFeatureState; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IGlobalFeatureSettingsInternal)GlobalFeatureSetting).GlobalFeatureState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.GlobalFeatureState)""); }

        /// <summary>Internal Acessors for GlobalFeatureSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IGlobalFeatureSettings Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeaturePropertiesInternal.GlobalFeatureSetting { get => (this._globalFeatureSetting = this._globalFeatureSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.GlobalFeatureSettings()); set { {_globalFeatureSetting = value;} } }

        /// <summary>Creates an new <see cref="FeatureProperties" /> instance.</summary>
        public FeatureProperties()
        {

        }
    }
    /// Properties of features.
    public partial interface IFeatureProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable
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
    /// Properties of features.
    internal partial interface IFeaturePropertiesInternal

    {
        /// <summary>List of subscription identifiers which have the feature enabled.</summary>
        string[] EnabledTenantSubscriptionId { get; set; }
        /// <summary>The name of the feature.</summary>
        string FeatureName { get; set; }
        /// <summary>Higher-priority global feature flags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IGlobalFeatureSettings GlobalFeatureSetting { get; set; }
        /// <summary>The state of the global feature.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.GlobalFeatureState? GlobalFeatureSettingGlobalFeatureState { get; set; }

    }
}