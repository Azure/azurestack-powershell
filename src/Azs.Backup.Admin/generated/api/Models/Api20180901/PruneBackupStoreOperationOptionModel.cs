namespace Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Extensions;

    /// <summary>Prune backup store operation model.</summary>
    public partial class PruneBackupStoreOperationOptionModel :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IPruneBackupStoreOperationOptionModel,
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IPruneBackupStoreOperationOptionModelInternal
    {

        /// <summary>Backing field for <see cref="OperationType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.PruneBackupStoreOperationType? _operationType;

        /// <summary>Operation type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.PruneBackupStoreOperationType? OperationType { get => this._operationType; set => this._operationType = value; }

        /// <summary>Creates an new <see cref="PruneBackupStoreOperationOptionModel" /> instance.</summary>
        public PruneBackupStoreOperationOptionModel()
        {

        }
    }
    /// Prune backup store operation model.
    public partial interface IPruneBackupStoreOperationOptionModel :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Operation type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Operation type.",
        SerializedName = @"operationType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.PruneBackupStoreOperationType) })]
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.PruneBackupStoreOperationType? OperationType { get; set; }

    }
    /// Prune backup store operation model.
    internal partial interface IPruneBackupStoreOperationOptionModelInternal

    {
        /// <summary>Operation type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.PruneBackupStoreOperationType? OperationType { get; set; }

    }
}