namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20181001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>All properties of a storage subsystem.</summary>
    public partial class StorageSubSystemModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20181001.IStorageSubSystemModel,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20181001.IStorageSubSystemModelInternal
    {

        /// <summary>Backing field for <see cref="HealthStatus" /> property.</summary>
        private string _healthStatus;

        /// <summary>Health status of the subsystem.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string HealthStatus { get => this._healthStatus; set => this._healthStatus = value; }

        /// <summary>Backing field for <see cref="OperationalStatus" /> property.</summary>
        private string _operationalStatus;

        /// <summary>Operational status of the subsystem.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string OperationalStatus { get => this._operationalStatus; set => this._operationalStatus = value; }

        /// <summary>Backing field for <see cref="RebalanceStatus" /> property.</summary>
        private string _rebalanceStatus;

        /// <summary>Rebalance status of the subsystem.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string RebalanceStatus { get => this._rebalanceStatus; set => this._rebalanceStatus = value; }

        /// <summary>Backing field for <see cref="RemainingCapacityGb" /> property.</summary>
        private int? _remainingCapacityGb;

        /// <summary>Remaining capacity in GB of the subsystem.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public int? RemainingCapacityGb { get => this._remainingCapacityGb; set => this._remainingCapacityGb = value; }

        /// <summary>Backing field for <see cref="TotalCapacityGb" /> property.</summary>
        private int? _totalCapacityGb;

        /// <summary>Total capacity in GB of the subsystem.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public int? TotalCapacityGb { get => this._totalCapacityGb; set => this._totalCapacityGb = value; }

        /// <summary>Creates an new <see cref="StorageSubSystemModel" /> instance.</summary>
        public StorageSubSystemModel()
        {

        }
    }
    /// All properties of a storage subsystem.
    public partial interface IStorageSubSystemModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Health status of the subsystem.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Health status of the subsystem.",
        SerializedName = @"healthStatus",
        PossibleTypes = new [] { typeof(string) })]
        string HealthStatus { get; set; }
        /// <summary>Operational status of the subsystem.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Operational status of the subsystem.",
        SerializedName = @"operationalStatus",
        PossibleTypes = new [] { typeof(string) })]
        string OperationalStatus { get; set; }
        /// <summary>Rebalance status of the subsystem.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Rebalance status of the subsystem.",
        SerializedName = @"rebalanceStatus",
        PossibleTypes = new [] { typeof(string) })]
        string RebalanceStatus { get; set; }
        /// <summary>Remaining capacity in GB of the subsystem.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Remaining capacity in GB of the subsystem.",
        SerializedName = @"remainingCapacityGB",
        PossibleTypes = new [] { typeof(int) })]
        int? RemainingCapacityGb { get; set; }
        /// <summary>Total capacity in GB of the subsystem.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Total capacity in GB of the subsystem.",
        SerializedName = @"totalCapacityGB",
        PossibleTypes = new [] { typeof(int) })]
        int? TotalCapacityGb { get; set; }

    }
    /// All properties of a storage subsystem.
    internal partial interface IStorageSubSystemModelInternal

    {
        /// <summary>Health status of the subsystem.</summary>
        string HealthStatus { get; set; }
        /// <summary>Operational status of the subsystem.</summary>
        string OperationalStatus { get; set; }
        /// <summary>Rebalance status of the subsystem.</summary>
        string RebalanceStatus { get; set; }
        /// <summary>Remaining capacity in GB of the subsystem.</summary>
        int? RemainingCapacityGb { get; set; }
        /// <summary>Total capacity in GB of the subsystem.</summary>
        int? TotalCapacityGb { get; set; }

    }
}