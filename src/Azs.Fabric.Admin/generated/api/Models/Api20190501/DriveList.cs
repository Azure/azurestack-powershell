namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Pageable list of storage drives.</summary>
    public partial class DriveList :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveList,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDrive[] _value;

        /// <summary>List of storage drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDrive[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="DriveList" /> instance.</summary>
        public DriveList()
        {

        }
    }
    /// Pageable list of storage drives.
    public partial interface IDriveList :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>List of storage drives.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of storage drives.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDrive) })]
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDrive[] Value { get; set; }

    }
    /// Pageable list of storage drives.
    internal partial interface IDriveListInternal

    {
        /// <summary>URI to the next page.</summary>
        string NextLink { get; set; }
        /// <summary>List of storage drives.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDrive[] Value { get; set; }

    }
}