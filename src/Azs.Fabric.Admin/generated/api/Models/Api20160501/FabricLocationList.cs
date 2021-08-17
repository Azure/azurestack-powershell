namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Pageable list of fabric locations.</summary>
    public partial class FabricLocationList :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationList,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocation[] _value;

        /// <summary>List of fabric locations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocation[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="FabricLocationList" /> instance.</summary>
        public FabricLocationList()
        {

        }
    }
    /// Pageable list of fabric locations.
    public partial interface IFabricLocationList :
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
        /// <summary>List of fabric locations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of fabric locations.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocation) })]
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocation[] Value { get; set; }

    }
    /// Pageable list of fabric locations.
    internal partial interface IFabricLocationListInternal

    {
        /// <summary>URI to the next page.</summary>
        string NextLink { get; set; }
        /// <summary>List of fabric locations.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocation[] Value { get; set; }

    }
}