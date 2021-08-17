namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Provisioning status of the resource.</summary>
    public partial class ProvisioningStateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IProvisioningStateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IProvisioningStatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning status of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; set => this._provisioningState = value; }

        /// <summary>Creates an new <see cref="ProvisioningStateProperties" /> instance.</summary>
        public ProvisioningStateProperties()
        {

        }
    }
    /// Provisioning status of the resource.
    public partial interface IProvisioningStateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Provisioning status of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provisioning status of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get; set; }

    }
    /// Provisioning status of the resource.
    internal partial interface IProvisioningStatePropertiesInternal

    {
        /// <summary>Provisioning status of the resource.</summary>
        string ProvisioningState { get; set; }

    }
}