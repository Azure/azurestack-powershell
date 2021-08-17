namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Description of a bare metal node used for ScaleOut operation on a cluster.</summary>
    public partial class BareMetalNodeDescription :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IBareMetalNodeDescription,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IBareMetalNodeDescriptionInternal
    {

        /// <summary>Backing field for <see cref="BiosVersion" /> property.</summary>
        private string _biosVersion;

        /// <summary>Bios version of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string BiosVersion { get => this._biosVersion; set => this._biosVersion = value; }

        /// <summary>Backing field for <see cref="BmciPv4Address" /> property.</summary>
        private string _bmciPv4Address;

        /// <summary>BMC address of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string BmciPv4Address { get => this._bmciPv4Address; set => this._bmciPv4Address = value; }

        /// <summary>Backing field for <see cref="ClusterName" /> property.</summary>
        private string _clusterName;

        /// <summary>Name of the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string ClusterName { get => this._clusterName; set => this._clusterName = value; }

        /// <summary>Backing field for <see cref="ComputerName" /> property.</summary>
        private string _computerName;

        /// <summary>Name of the computer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string ComputerName { get => this._computerName; set => this._computerName = value; }

        /// <summary>Backing field for <see cref="MacAddress" /> property.</summary>
        private string _macAddress;

        /// <summary>Name of the MAC address of the bare metal node.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string MacAddress { get => this._macAddress; set => this._macAddress = value; }

        /// <summary>Backing field for <see cref="Model" /> property.</summary>
        private string _model;

        /// <summary>Model of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string Model { get => this._model; set => this._model = value; }

        /// <summary>Backing field for <see cref="SerialNumber" /> property.</summary>
        private string _serialNumber;

        /// <summary>Serial number of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string SerialNumber { get => this._serialNumber; set => this._serialNumber = value; }

        /// <summary>Backing field for <see cref="Vendor" /> property.</summary>
        private string _vendor;

        /// <summary>Vendor of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string Vendor { get => this._vendor; set => this._vendor = value; }

        /// <summary>Creates an new <see cref="BareMetalNodeDescription" /> instance.</summary>
        public BareMetalNodeDescription()
        {

        }
    }
    /// Description of a bare metal node used for ScaleOut operation on a cluster.
    public partial interface IBareMetalNodeDescription :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Bios version of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Bios version of the physical machine.",
        SerializedName = @"biosVersion",
        PossibleTypes = new [] { typeof(string) })]
        string BiosVersion { get; set; }
        /// <summary>BMC address of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"BMC address of the physical machine.",
        SerializedName = @"bmcIpv4Address",
        PossibleTypes = new [] { typeof(string) })]
        string BmciPv4Address { get; set; }
        /// <summary>Name of the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the cluster.",
        SerializedName = @"clusterName",
        PossibleTypes = new [] { typeof(string) })]
        string ClusterName { get; set; }
        /// <summary>Name of the computer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the computer.",
        SerializedName = @"computerName",
        PossibleTypes = new [] { typeof(string) })]
        string ComputerName { get; set; }
        /// <summary>Name of the MAC address of the bare metal node.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the MAC address of the bare metal node.",
        SerializedName = @"macAddress",
        PossibleTypes = new [] { typeof(string) })]
        string MacAddress { get; set; }
        /// <summary>Model of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Model of the physical machine.",
        SerializedName = @"model",
        PossibleTypes = new [] { typeof(string) })]
        string Model { get; set; }
        /// <summary>Serial number of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Serial number of the physical machine.",
        SerializedName = @"serialNumber",
        PossibleTypes = new [] { typeof(string) })]
        string SerialNumber { get; set; }
        /// <summary>Vendor of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Vendor of the physical machine.",
        SerializedName = @"vendor",
        PossibleTypes = new [] { typeof(string) })]
        string Vendor { get; set; }

    }
    /// Description of a bare metal node used for ScaleOut operation on a cluster.
    internal partial interface IBareMetalNodeDescriptionInternal

    {
        /// <summary>Bios version of the physical machine.</summary>
        string BiosVersion { get; set; }
        /// <summary>BMC address of the physical machine.</summary>
        string BmciPv4Address { get; set; }
        /// <summary>Name of the cluster.</summary>
        string ClusterName { get; set; }
        /// <summary>Name of the computer.</summary>
        string ComputerName { get; set; }
        /// <summary>Name of the MAC address of the bare metal node.</summary>
        string MacAddress { get; set; }
        /// <summary>Model of the physical machine.</summary>
        string Model { get; set; }
        /// <summary>Serial number of the physical machine.</summary>
        string SerialNumber { get; set; }
        /// <summary>Vendor of the physical machine.</summary>
        string Vendor { get; set; }

    }
}