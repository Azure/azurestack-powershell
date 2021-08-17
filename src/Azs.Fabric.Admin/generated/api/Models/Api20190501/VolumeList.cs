namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Pageable list of storage volumes.</summary>
    public partial class VolumeList :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeList,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolumeListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolume[] _value;

        /// <summary>List of storage volumes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolume[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="VolumeList" /> instance.</summary>
        public VolumeList()
        {

        }
    }
    /// Pageable list of storage volumes.
    public partial interface IVolumeList :
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
        /// <summary>List of storage volumes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of storage volumes.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolume) })]
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolume[] Value { get; set; }

    }
    /// Pageable list of storage volumes.
    internal partial interface IVolumeListInternal

    {
        /// <summary>URI to the next page.</summary>
        string NextLink { get; set; }
        /// <summary>List of storage volumes.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IVolume[] Value { get; set; }

    }
}