namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Properties of a volume.</summary>
    public partial class VolumeModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModel,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal
    {

        /// <summary>Backing field for <see cref="Action" /> property.</summary>
        private string _action;

        /// <summary>
        /// Detailed recommended action for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string Action { get => this._action; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>
        /// Detailed description for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string Description { get => this._description; }

        /// <summary>Backing field for <see cref="HealthStatus" /> property.</summary>
        private string _healthStatus;

        /// <summary>Health status of the volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string HealthStatus { get => this._healthStatus; }

        /// <summary>Internal Acessors for Action</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal.Action { get => this._action; set { {_action = value;} } }

        /// <summary>Internal Acessors for Description</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal.Description { get => this._description; set { {_description = value;} } }

        /// <summary>Internal Acessors for HealthStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal.HealthStatus { get => this._healthStatus; set { {_healthStatus = value;} } }

        /// <summary>Internal Acessors for OperationalStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal.OperationalStatus { get => this._operationalStatus; set { {_operationalStatus = value;} } }

        /// <summary>Internal Acessors for RemainingCapacityGb</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal.RemainingCapacityGb { get => this._remainingCapacityGb; set { {_remainingCapacityGb = value;} } }

        /// <summary>Internal Acessors for RepairStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal.RepairStatus { get => this._repairStatus; set { {_repairStatus = value;} } }

        /// <summary>Internal Acessors for TotalCapacityGb</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal.TotalCapacityGb { get => this._totalCapacityGb; set { {_totalCapacityGb = value;} } }

        /// <summary>Internal Acessors for VolumeLabel</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeModelInternal.VolumeLabel { get => this._volumeLabel; set { {_volumeLabel = value;} } }

        /// <summary>Backing field for <see cref="OperationalStatus" /> property.</summary>
        private string _operationalStatus;

        /// <summary>Operational status of the volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string OperationalStatus { get => this._operationalStatus; }

        /// <summary>Backing field for <see cref="RemainingCapacityGb" /> property.</summary>
        private int? _remainingCapacityGb;

        /// <summary>Remaining capacity in GB of the volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public int? RemainingCapacityGb { get => this._remainingCapacityGb; }

        /// <summary>Backing field for <see cref="RepairStatus" /> property.</summary>
        private string _repairStatus;

        /// <summary>
        /// Repair status of the volume. Empty if no repair job running, something like 'Running, 90%' when repairing.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string RepairStatus { get => this._repairStatus; }

        /// <summary>Backing field for <see cref="TotalCapacityGb" /> property.</summary>
        private int? _totalCapacityGb;

        /// <summary>Total capacity in GB of the volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public int? TotalCapacityGb { get => this._totalCapacityGb; }

        /// <summary>Backing field for <see cref="VolumeLabel" /> property.</summary>
        private string _volumeLabel;

        /// <summary>Volume label.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string VolumeLabel { get => this._volumeLabel; }

        /// <summary>Creates an new <see cref="VolumeModel" /> instance.</summary>
        public VolumeModel()
        {

        }
    }
    /// Properties of a volume.
    public partial interface IVolumeModel :
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
        /// <summary>Health status of the volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Health status of the volume.",
        SerializedName = @"healthStatus",
        PossibleTypes = new [] { typeof(string) })]
        string HealthStatus { get;  }
        /// <summary>Operational status of the volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Operational status of the volume.",
        SerializedName = @"operationalStatus",
        PossibleTypes = new [] { typeof(string) })]
        string OperationalStatus { get;  }
        /// <summary>Remaining capacity in GB of the volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Remaining capacity in GB of the volume.",
        SerializedName = @"remainingCapacityGB",
        PossibleTypes = new [] { typeof(int) })]
        int? RemainingCapacityGb { get;  }
        /// <summary>
        /// Repair status of the volume. Empty if no repair job running, something like 'Running, 90%' when repairing.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Repair status of the volume. Empty if no repair job running, something like 'Running, 90%' when repairing.",
        SerializedName = @"repairStatus",
        PossibleTypes = new [] { typeof(string) })]
        string RepairStatus { get;  }
        /// <summary>Total capacity in GB of the volume.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Total capacity in GB of the volume.",
        SerializedName = @"totalCapacityGB",
        PossibleTypes = new [] { typeof(int) })]
        int? TotalCapacityGb { get;  }
        /// <summary>Volume label.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Volume label.",
        SerializedName = @"volumeLabel",
        PossibleTypes = new [] { typeof(string) })]
        string VolumeLabel { get;  }

    }
    /// Properties of a volume.
    internal partial interface IVolumeModelInternal

    {
        /// <summary>
        /// Detailed recommended action for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.
        /// </summary>
        string Action { get; set; }
        /// <summary>
        /// Detailed description for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.
        /// </summary>
        string Description { get; set; }
        /// <summary>Health status of the volume.</summary>
        string HealthStatus { get; set; }
        /// <summary>Operational status of the volume.</summary>
        string OperationalStatus { get; set; }
        /// <summary>Remaining capacity in GB of the volume.</summary>
        int? RemainingCapacityGb { get; set; }
        /// <summary>
        /// Repair status of the volume. Empty if no repair job running, something like 'Running, 90%' when repairing.
        /// </summary>
        string RepairStatus { get; set; }
        /// <summary>Total capacity in GB of the volume.</summary>
        int? TotalCapacityGb { get; set; }
        /// <summary>Volume label.</summary>
        string VolumeLabel { get; set; }

    }
}