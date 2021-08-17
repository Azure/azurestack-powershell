namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Properties of a drive.</summary>
    public partial class DriveModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModel,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal
    {

        /// <summary>Backing field for <see cref="Action" /> property.</summary>
        private string _action;

        /// <summary>
        /// Detailed recommended action for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string Action { get => this._action; }

        /// <summary>Backing field for <see cref="CapacityGb" /> property.</summary>
        private int? _capacityGb;

        /// <summary>Total capacity in GB of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public int? CapacityGb { get => this._capacityGb; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>
        /// Detailed description for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string Description { get => this._description; }

        /// <summary>Backing field for <see cref="FirmwareVersion" /> property.</summary>
        private string _firmwareVersion;

        /// <summary>The firmware version of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string FirmwareVersion { get => this._firmwareVersion; }

        /// <summary>Backing field for <see cref="HealthStatus" /> property.</summary>
        private string _healthStatus;

        /// <summary>Health status of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string HealthStatus { get => this._healthStatus; }

        /// <summary>Backing field for <see cref="IsIndicationEnabled" /> property.</summary>
        private bool? _isIndicationEnabled;

        /// <summary>Indicate whether the drive's identification LEDs are active or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public bool? IsIndicationEnabled { get => this._isIndicationEnabled; }

        /// <summary>Backing field for <see cref="Manufacturer" /> property.</summary>
        private string _manufacturer;

        /// <summary>The name of the drive's manufacturer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string Manufacturer { get => this._manufacturer; }

        /// <summary>Backing field for <see cref="MediaType" /> property.</summary>
        private string _mediaType;

        /// <summary>Media type of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string MediaType { get => this._mediaType; }

        /// <summary>Internal Acessors for Action</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal.Action { get => this._action; set { {_action = value;} } }

        /// <summary>Internal Acessors for CapacityGb</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal.CapacityGb { get => this._capacityGb; set { {_capacityGb = value;} } }

        /// <summary>Internal Acessors for Description</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal.Description { get => this._description; set { {_description = value;} } }

        /// <summary>Internal Acessors for FirmwareVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal.FirmwareVersion { get => this._firmwareVersion; set { {_firmwareVersion = value;} } }

        /// <summary>Internal Acessors for HealthStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal.HealthStatus { get => this._healthStatus; set { {_healthStatus = value;} } }

        /// <summary>Internal Acessors for IsIndicationEnabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal.IsIndicationEnabled { get => this._isIndicationEnabled; set { {_isIndicationEnabled = value;} } }

        /// <summary>Internal Acessors for Manufacturer</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal.Manufacturer { get => this._manufacturer; set { {_manufacturer = value;} } }

        /// <summary>Internal Acessors for MediaType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal.MediaType { get => this._mediaType; set { {_mediaType = value;} } }

        /// <summary>Internal Acessors for Model</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal.Model { get => this._model; set { {_model = value;} } }

        /// <summary>Internal Acessors for OperationalStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal.OperationalStatus { get => this._operationalStatus; set { {_operationalStatus = value;} } }

        /// <summary>Internal Acessors for PhysicalLocation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal.PhysicalLocation { get => this._physicalLocation; set { {_physicalLocation = value;} } }

        /// <summary>Internal Acessors for SerialNumber</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal.SerialNumber { get => this._serialNumber; set { {_serialNumber = value;} } }

        /// <summary>Internal Acessors for StorageNode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal.StorageNode { get => this._storageNode; set { {_storageNode = value;} } }

        /// <summary>Internal Acessors for StoragePool</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal.StoragePool { get => this._storagePool; set { {_storagePool = value;} } }

        /// <summary>Internal Acessors for Usage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal.Usage { get => this._usage; set { {_usage = value;} } }

        /// <summary>Backing field for <see cref="Model" /> property.</summary>
        private string _model;

        /// <summary>Model of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string Model { get => this._model; }

        /// <summary>Backing field for <see cref="OperationalStatus" /> property.</summary>
        private string _operationalStatus;

        /// <summary>Operational status of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string OperationalStatus { get => this._operationalStatus; }

        /// <summary>Backing field for <see cref="PhysicalLocation" /> property.</summary>
        private string _physicalLocation;

        /// <summary>Indicate where the hardware is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string PhysicalLocation { get => this._physicalLocation; }

        /// <summary>Backing field for <see cref="SerialNumber" /> property.</summary>
        private string _serialNumber;

        /// <summary>Serial number of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string SerialNumber { get => this._serialNumber; }

        /// <summary>Backing field for <see cref="StorageNode" /> property.</summary>
        private string _storageNode;

        /// <summary>Node that the drive is physically connected.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string StorageNode { get => this._storageNode; }

        /// <summary>Backing field for <see cref="StoragePool" /> property.</summary>
        private string _storagePool;

        /// <summary>The storage pool where the drive is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string StoragePool { get => this._storagePool; }

        /// <summary>Backing field for <see cref="Usage" /> property.</summary>
        private string _usage;

        /// <summary>Intended usage of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string Usage { get => this._usage; }

        /// <summary>Creates an new <see cref="DriveModel" /> instance.</summary>
        public DriveModel()
        {

        }
    }
    /// Properties of a drive.
    public partial interface IDriveModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Detailed recommended action for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Detailed recommended action for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.",
        SerializedName = @"action",
        PossibleTypes = new [] { typeof(string) })]
        string Action { get;  }
        /// <summary>Total capacity in GB of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Total capacity in GB of the drive.",
        SerializedName = @"capacityGB",
        PossibleTypes = new [] { typeof(int) })]
        int? CapacityGb { get;  }
        /// <summary>
        /// Detailed description for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Detailed description for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get;  }
        /// <summary>The firmware version of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The firmware version of the drive.",
        SerializedName = @"firmwareVersion",
        PossibleTypes = new [] { typeof(string) })]
        string FirmwareVersion { get;  }
        /// <summary>Health status of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Health status of the drive.",
        SerializedName = @"healthStatus",
        PossibleTypes = new [] { typeof(string) })]
        string HealthStatus { get;  }
        /// <summary>Indicate whether the drive's identification LEDs are active or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Indicate whether the drive's identification LEDs are active or not.",
        SerializedName = @"isIndicationEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsIndicationEnabled { get;  }
        /// <summary>The name of the drive's manufacturer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of the drive's manufacturer.",
        SerializedName = @"manufacturer",
        PossibleTypes = new [] { typeof(string) })]
        string Manufacturer { get;  }
        /// <summary>Media type of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Media type of the drive.",
        SerializedName = @"mediaType",
        PossibleTypes = new [] { typeof(string) })]
        string MediaType { get;  }
        /// <summary>Model of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Model of the drive.",
        SerializedName = @"model",
        PossibleTypes = new [] { typeof(string) })]
        string Model { get;  }
        /// <summary>Operational status of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Operational status of the drive.",
        SerializedName = @"operationalStatus",
        PossibleTypes = new [] { typeof(string) })]
        string OperationalStatus { get;  }
        /// <summary>Indicate where the hardware is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Indicate where the hardware is located.",
        SerializedName = @"physicalLocation",
        PossibleTypes = new [] { typeof(string) })]
        string PhysicalLocation { get;  }
        /// <summary>Serial number of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Serial number of the drive.",
        SerializedName = @"serialNumber",
        PossibleTypes = new [] { typeof(string) })]
        string SerialNumber { get;  }
        /// <summary>Node that the drive is physically connected.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Node that the drive is physically connected.",
        SerializedName = @"storageNode",
        PossibleTypes = new [] { typeof(string) })]
        string StorageNode { get;  }
        /// <summary>The storage pool where the drive is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The storage pool where the drive is located.",
        SerializedName = @"storagePool",
        PossibleTypes = new [] { typeof(string) })]
        string StoragePool { get;  }
        /// <summary>Intended usage of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Intended usage of the drive.",
        SerializedName = @"usage",
        PossibleTypes = new [] { typeof(string) })]
        string Usage { get;  }

    }
    /// Properties of a drive.
    internal partial interface IDriveModelInternal

    {
        /// <summary>
        /// Detailed recommended action for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.
        /// </summary>
        string Action { get; set; }
        /// <summary>Total capacity in GB of the drive.</summary>
        int? CapacityGb { get; set; }
        /// <summary>
        /// Detailed description for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.
        /// </summary>
        string Description { get; set; }
        /// <summary>The firmware version of the drive.</summary>
        string FirmwareVersion { get; set; }
        /// <summary>Health status of the drive.</summary>
        string HealthStatus { get; set; }
        /// <summary>Indicate whether the drive's identification LEDs are active or not.</summary>
        bool? IsIndicationEnabled { get; set; }
        /// <summary>The name of the drive's manufacturer.</summary>
        string Manufacturer { get; set; }
        /// <summary>Media type of the drive.</summary>
        string MediaType { get; set; }
        /// <summary>Model of the drive.</summary>
        string Model { get; set; }
        /// <summary>Operational status of the drive.</summary>
        string OperationalStatus { get; set; }
        /// <summary>Indicate where the hardware is located.</summary>
        string PhysicalLocation { get; set; }
        /// <summary>Serial number of the drive.</summary>
        string SerialNumber { get; set; }
        /// <summary>Node that the drive is physically connected.</summary>
        string StorageNode { get; set; }
        /// <summary>The storage pool where the drive is located.</summary>
        string StoragePool { get; set; }
        /// <summary>Intended usage of the drive.</summary>
        string Usage { get; set; }

    }
}