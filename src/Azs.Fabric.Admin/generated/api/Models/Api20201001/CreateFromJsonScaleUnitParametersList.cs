namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>A list of input data that allows for creating the new scale unit.</summary>
    public partial class CreateFromJsonScaleUnitParametersList :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersList,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal
    {

        /// <summary>Backing field for <see cref="ClusterName" /> property.</summary>
        private string _clusterName;

        /// <summary>Cluster name for the new scale unit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string ClusterName { get => this._clusterName; set => this._clusterName = value; }

        /// <summary>Backing field for <see cref="InfrastructureNetwork" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.INetworkDefinitionParameter _infrastructureNetwork;

        /// <summary>
        /// The information associated with the infrastructure network that will be subdivided into subnets.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.INetworkDefinitionParameter InfrastructureNetwork { get => (this._infrastructureNetwork = this._infrastructureNetwork ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.NetworkDefinitionParameter()); set => this._infrastructureNetwork = value; }

        /// <summary>The subnet IP mask in the example format 10.0.0.0/25.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string[] InfrastructureNetworkSubnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.INetworkDefinitionParameterInternal)InfrastructureNetwork).Subnet; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.INetworkDefinitionParameterInternal)InfrastructureNetwork).Subnet = value ?? null /* arrayOf */; }

        /// <summary>The Vlan ID of the subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string[] InfrastructureNetworkVlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.INetworkDefinitionParameterInternal)InfrastructureNetwork).VlanId; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.INetworkDefinitionParameterInternal)InfrastructureNetwork).VlanId = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for InfrastructureNetwork</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.INetworkDefinitionParameter Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal.InfrastructureNetwork { get => (this._infrastructureNetwork = this._infrastructureNetwork ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.NetworkDefinitionParameter()); set { {_infrastructureNetwork = value;} } }

        /// <summary>Internal Acessors for StorageNetwork</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.INetworkDefinitionParameter Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal.StorageNetwork { get => (this._storageNetwork = this._storageNetwork ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.NetworkDefinitionParameter()); set { {_storageNetwork = value;} } }

        /// <summary>Backing field for <see cref="NetQosPriority" /> property.</summary>
        private int? _netQosPriority;

        /// <summary>The network QOS priority setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public int? NetQosPriority { get => this._netQosPriority; set => this._netQosPriority = value; }

        /// <summary>Backing field for <see cref="PhysicalNode" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IDeploymentJsonPhysicalNodeParameters[] _physicalNode;

        /// <summary>List of nodes in the scale unit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IDeploymentJsonPhysicalNodeParameters[] PhysicalNode { get => this._physicalNode; set => this._physicalNode = value; }

        /// <summary>Backing field for <see cref="SoftwareBgpAsn" /> property.</summary>
        private string _softwareBgpAsn;

        /// <summary>The software ASN for the cluster's rack.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string SoftwareBgpAsn { get => this._softwareBgpAsn; set => this._softwareBgpAsn = value; }

        /// <summary>Backing field for <see cref="StorageNetwork" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.INetworkDefinitionParameter _storageNetwork;

        /// <summary>
        /// The information associated with the storage network that will be subdivided into subnets.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.INetworkDefinitionParameter StorageNetwork { get => (this._storageNetwork = this._storageNetwork ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.NetworkDefinitionParameter()); set => this._storageNetwork = value; }

        /// <summary>The subnet IP mask in the example format 10.0.0.0/25.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string[] StorageNetworkSubnet { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.INetworkDefinitionParameterInternal)StorageNetwork).Subnet; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.INetworkDefinitionParameterInternal)StorageNetwork).Subnet = value ?? null /* arrayOf */; }

        /// <summary>The Vlan ID of the subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string[] StorageNetworkVlanId { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.INetworkDefinitionParameterInternal)StorageNetwork).VlanId; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.INetworkDefinitionParameterInternal)StorageNetwork).VlanId = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="TorSwitchBgpAsn" /> property.</summary>
        private string _torSwitchBgpAsn;

        /// <summary>The ASN for the cluster's rack TOR.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string TorSwitchBgpAsn { get => this._torSwitchBgpAsn; set => this._torSwitchBgpAsn = value; }

        /// <summary>Backing field for <see cref="TorSwitchBgpPeerIP" /> property.</summary>
        private string[] _torSwitchBgpPeerIP;

        /// <summary>The list of IP addresses used for TOR communication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string[] TorSwitchBgpPeerIP { get => this._torSwitchBgpPeerIP; set => this._torSwitchBgpPeerIP = value; }

        /// <summary>Creates an new <see cref="CreateFromJsonScaleUnitParametersList" /> instance.</summary>
        public CreateFromJsonScaleUnitParametersList()
        {

        }
    }
    /// A list of input data that allows for creating the new scale unit.
    public partial interface ICreateFromJsonScaleUnitParametersList :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Cluster name for the new scale unit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Cluster name for the new scale unit.",
        SerializedName = @"clusterName",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterName { get; set; }
        /// <summary>The subnet IP mask in the example format 10.0.0.0/25.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The subnet IP mask in the example format 10.0.0.0/25.",
        SerializedName = @"subnet",
        PossibleTypes = new [] { typeof(string) })]
        string[] InfrastructureNetworkSubnet { get; set; }
        /// <summary>The Vlan ID of the subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Vlan ID of the subnet.",
        SerializedName = @"vlanId",
        PossibleTypes = new [] { typeof(string) })]
        string[] InfrastructureNetworkVlanId { get; set; }
        /// <summary>The network QOS priority setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The network QOS priority setting.",
        SerializedName = @"netQosPriority",
        PossibleTypes = new [] { typeof(int) })]
        int? NetQosPriority { get; set; }
        /// <summary>List of nodes in the scale unit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of nodes in the scale unit.",
        SerializedName = @"physicalNodes",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IDeploymentJsonPhysicalNodeParameters) })]
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IDeploymentJsonPhysicalNodeParameters[] PhysicalNode { get; set; }
        /// <summary>The software ASN for the cluster's rack.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The software ASN for the cluster's rack.",
        SerializedName = @"softwareBgpAsn",
        PossibleTypes = new [] { typeof(string) })]
        string SoftwareBgpAsn { get; set; }
        /// <summary>The subnet IP mask in the example format 10.0.0.0/25.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The subnet IP mask in the example format 10.0.0.0/25.",
        SerializedName = @"subnet",
        PossibleTypes = new [] { typeof(string) })]
        string[] StorageNetworkSubnet { get; set; }
        /// <summary>The Vlan ID of the subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Vlan ID of the subnet.",
        SerializedName = @"vlanId",
        PossibleTypes = new [] { typeof(string) })]
        string[] StorageNetworkVlanId { get; set; }
        /// <summary>The ASN for the cluster's rack TOR.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ASN for the cluster's rack TOR.",
        SerializedName = @"torSwitchBgpAsn",
        PossibleTypes = new [] { typeof(string) })]
        string TorSwitchBgpAsn { get; set; }
        /// <summary>The list of IP addresses used for TOR communication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of IP addresses used for TOR communication.",
        SerializedName = @"torSwitchBgpPeerIp",
        PossibleTypes = new [] { typeof(string) })]
        string[] TorSwitchBgpPeerIP { get; set; }

    }
    /// A list of input data that allows for creating the new scale unit.
    internal partial interface ICreateFromJsonScaleUnitParametersListInternal

    {
        /// <summary>Cluster name for the new scale unit.</summary>
        string ClusterName { get; set; }
        /// <summary>
        /// The information associated with the infrastructure network that will be subdivided into subnets.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.INetworkDefinitionParameter InfrastructureNetwork { get; set; }
        /// <summary>The subnet IP mask in the example format 10.0.0.0/25.</summary>
        string[] InfrastructureNetworkSubnet { get; set; }
        /// <summary>The Vlan ID of the subnet.</summary>
        string[] InfrastructureNetworkVlanId { get; set; }
        /// <summary>The network QOS priority setting.</summary>
        int? NetQosPriority { get; set; }
        /// <summary>List of nodes in the scale unit.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IDeploymentJsonPhysicalNodeParameters[] PhysicalNode { get; set; }
        /// <summary>The software ASN for the cluster's rack.</summary>
        string SoftwareBgpAsn { get; set; }
        /// <summary>
        /// The information associated with the storage network that will be subdivided into subnets.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.INetworkDefinitionParameter StorageNetwork { get; set; }
        /// <summary>The subnet IP mask in the example format 10.0.0.0/25.</summary>
        string[] StorageNetworkSubnet { get; set; }
        /// <summary>The Vlan ID of the subnet.</summary>
        string[] StorageNetworkVlanId { get; set; }
        /// <summary>The ASN for the cluster's rack TOR.</summary>
        string TorSwitchBgpAsn { get; set; }
        /// <summary>The list of IP addresses used for TOR communication.</summary>
        string[] TorSwitchBgpPeerIP { get; set; }

    }
}