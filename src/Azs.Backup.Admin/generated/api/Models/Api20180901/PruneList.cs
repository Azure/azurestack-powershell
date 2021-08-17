namespace Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Extensions;

    /// <summary>List of files to delete.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.DoNotFormat]
    public partial class PruneList :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IPruneList,
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IPruneListInternal
    {

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IPruneModel Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IPruneListInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.PruneModel()); set { {_property = value;} } }

        /// <summary>Garbage file list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Inlined)]
        public string[] PathsToDelete { get => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IPruneModelInternal)Property).PathsToDelete; set => ((Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IPruneModelInternal)Property).PathsToDelete = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IPruneModel _property;

        /// <summary>Holds information for a backup.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IPruneModel Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.PruneModel()); set => this._property = value; }

        /// <summary>Creates an new <see cref="PruneList" /> instance.</summary>
        public PruneList()
        {

        }
    }
    /// List of files to delete.
    public partial interface IPruneList :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Garbage file list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Garbage file list.",
        SerializedName = @"pathsToDelete",
        PossibleTypes = new [] { typeof(string) })]
        string[] PathsToDelete { get; set; }

    }
    /// List of files to delete.
    internal partial interface IPruneListInternal

    {
        /// <summary>Garbage file list.</summary>
        string[] PathsToDelete { get; set; }
        /// <summary>Holds information for a backup.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IPruneModel Property { get; set; }

    }
}