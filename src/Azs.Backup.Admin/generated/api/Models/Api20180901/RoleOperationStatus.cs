namespace Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Extensions;

    /// <summary>Backup status for a role.</summary>
    public partial class RoleOperationStatus :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRoleOperationStatus,
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IRoleOperationStatusInternal
    {

        /// <summary>Backing field for <see cref="RoleName" /> property.</summary>
        private string _roleName;

        /// <summary>Name of the role.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public string RoleName { get => this._roleName; set => this._roleName = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.OperationStatus? _status;

        /// <summary>Status of the role.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.OperationStatus? Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="RoleOperationStatus" /> instance.</summary>
        public RoleOperationStatus()
        {

        }
    }
    /// Backup status for a role.
    public partial interface IRoleOperationStatus :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Name of the role.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the role.",
        SerializedName = @"roleName",
        PossibleTypes = new [] { typeof(string) })]
        string RoleName { get; set; }
        /// <summary>Status of the role.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Status of the role.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.OperationStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.OperationStatus? Status { get; set; }

    }
    /// Backup status for a role.
    internal partial interface IRoleOperationStatusInternal

    {
        /// <summary>Name of the role.</summary>
        string RoleName { get; set; }
        /// <summary>Status of the role.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Support.OperationStatus? Status { get; set; }

    }
}