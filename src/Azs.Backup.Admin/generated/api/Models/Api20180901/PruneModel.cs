namespace Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Runtime.Extensions;

    /// <summary>Properties for a prune list.</summary>
    public partial class PruneModel :
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IPruneModel,
        Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Models.Api20180901.IPruneModelInternal
    {

        /// <summary>Backing field for <see cref="PathsToDelete" /> property.</summary>
        private string[] _pathsToDelete;

        /// <summary>Garbage file list.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BackupAdmin.PropertyOrigin.Owned)]
        public string[] PathsToDelete { get => this._pathsToDelete; set => this._pathsToDelete = value; }

        /// <summary>Creates an new <see cref="PruneModel" /> instance.</summary>
        public PruneModel()
        {

        }
    }
    /// Properties for a prune list.
    public partial interface IPruneModel :
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
    /// Properties for a prune list.
    internal partial interface IPruneModelInternal

    {
        /// <summary>Garbage file list.</summary>
        string[] PathsToDelete { get; set; }

    }
}