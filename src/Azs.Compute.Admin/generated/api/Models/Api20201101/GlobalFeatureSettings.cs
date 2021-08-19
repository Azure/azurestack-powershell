namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Higher-priority global feature flags.</summary>
    public partial class GlobalFeatureSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IGlobalFeatureSettings,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IGlobalFeatureSettingsInternal
    {

        /// <summary>Backing field for <see cref="GlobalFeatureState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.GlobalFeatureState? _globalFeatureState;

        /// <summary>The state of the global feature.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.GlobalFeatureState? GlobalFeatureState { get => this._globalFeatureState; set => this._globalFeatureState = value; }

        /// <summary>Creates an new <see cref="GlobalFeatureSettings" /> instance.</summary>
        public GlobalFeatureSettings()
        {

        }
    }
    /// Higher-priority global feature flags.
    public partial interface IGlobalFeatureSettings :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The state of the global feature.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The state of the global feature.",
        SerializedName = @"globalFeatureState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.GlobalFeatureState) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.GlobalFeatureState? GlobalFeatureState { get; set; }

    }
    /// Higher-priority global feature flags.
    internal partial interface IGlobalFeatureSettingsInternal

    {
        /// <summary>The state of the global feature.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.GlobalFeatureState? GlobalFeatureState { get; set; }

    }
}