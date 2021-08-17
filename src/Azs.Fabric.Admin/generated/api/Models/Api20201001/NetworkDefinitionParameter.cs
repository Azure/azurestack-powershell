namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>A definition of the network received from a new cluster operation.</summary>
    public partial class NetworkDefinitionParameter :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.INetworkDefinitionParameter,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.INetworkDefinitionParameterInternal
    {

        /// <summary>Backing field for <see cref="Subnet" /> property.</summary>
        private string[] _subnet;

        /// <summary>The subnet IP mask in the example format 10.0.0.0/25.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string[] Subnet { get => this._subnet; set => this._subnet = value; }

        /// <summary>Backing field for <see cref="VlanId" /> property.</summary>
        private string[] _vlanId;

        /// <summary>The Vlan ID of the subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string[] VlanId { get => this._vlanId; set => this._vlanId = value; }

        /// <summary>Creates an new <see cref="NetworkDefinitionParameter" /> instance.</summary>
        public NetworkDefinitionParameter()
        {

        }
    }
    /// A definition of the network received from a new cluster operation.
    public partial interface INetworkDefinitionParameter :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The subnet IP mask in the example format 10.0.0.0/25.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The subnet IP mask in the example format 10.0.0.0/25.",
        SerializedName = @"subnet",
        PossibleTypes = new [] { typeof(string) })]
        string[] Subnet { get; set; }
        /// <summary>The Vlan ID of the subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Vlan ID of the subnet.",
        SerializedName = @"vlanId",
        PossibleTypes = new [] { typeof(string) })]
        string[] VlanId { get; set; }

    }
    /// A definition of the network received from a new cluster operation.
    internal partial interface INetworkDefinitionParameterInternal

    {
        /// <summary>The subnet IP mask in the example format 10.0.0.0/25.</summary>
        string[] Subnet { get; set; }
        /// <summary>The Vlan ID of the subnet.</summary>
        string[] VlanId { get; set; }

    }
}