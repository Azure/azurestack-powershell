namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Provisioning status of the resource.</summary>
    public partial class ProvisioningState :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IProvisioningState,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IProvisioningStateInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IProvisioningStateProperties Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IProvisioningStateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ProvisioningStateProperties()); set { {_property = value;} } }

        /// <summary>Provisioning status of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string PropertiesProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IProvisioningStatePropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IProvisioningStatePropertiesInternal)Property).ProvisioningState = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IProvisioningStateProperties _property;

        /// <summary>Provisioning status of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IProvisioningStateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ProvisioningStateProperties()); set => this._property = value; }

        /// <summary>Creates an new <see cref="ProvisioningState" /> instance.</summary>
        public ProvisioningState()
        {

        }
    }
    /// Provisioning status of the resource.
    public partial interface IProvisioningState :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Provisioning status of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provisioning status of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string PropertiesProvisioningState { get; set; }

    }
    /// Provisioning status of the resource.
    internal partial interface IProvisioningStateInternal

    {
        /// <summary>Provisioning status of the resource.</summary>
        string PropertiesProvisioningState { get; set; }
        /// <summary>Provisioning status of the resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IProvisioningStateProperties Property { get; set; }

    }
}