namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Description of a bare metal node used for scale unit scale out operations.</summary>
    public partial class DeploymentJsonPhysicalNodeParameters :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IDeploymentJsonPhysicalNodeParameters,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IDeploymentJsonPhysicalNodeParametersInternal
    {

        /// <summary>Backing field for <see cref="BmcipAddress" /> property.</summary>
        private string _bmcipAddress;

        /// <summary>BMC address of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string BmcipAddress { get => this._bmcipAddress; set => this._bmcipAddress = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Computer name of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Creates an new <see cref="DeploymentJsonPhysicalNodeParameters" /> instance.</summary>
        public DeploymentJsonPhysicalNodeParameters()
        {

        }
    }
    /// Description of a bare metal node used for scale unit scale out operations.
    public partial interface IDeploymentJsonPhysicalNodeParameters :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>BMC address of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"BMC address of the physical machine.",
        SerializedName = @"bmcIpAddress",
        PossibleTypes = new [] { typeof(string) })]
        string BmcipAddress { get; set; }
        /// <summary>Computer name of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Computer name of the physical machine.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

    }
    /// Description of a bare metal node used for scale unit scale out operations.
    internal partial interface IDeploymentJsonPhysicalNodeParametersInternal

    {
        /// <summary>BMC address of the physical machine.</summary>
        string BmcipAddress { get; set; }
        /// <summary>Computer name of the physical machine.</summary>
        string Name { get; set; }

    }
}