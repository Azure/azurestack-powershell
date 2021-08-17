namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>A pageable list of scale units.</summary>
    public partial class ScaleUnitList :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitList,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnit[] _value;

        /// <summary>List of scale units.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnit[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ScaleUnitList" /> instance.</summary>
        public ScaleUnitList()
        {

        }
    }
    /// A pageable list of scale units.
    public partial interface IScaleUnitList :
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
        /// <summary>List of scale units.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of scale units.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnit) })]
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnit[] Value { get; set; }

    }
    /// A pageable list of scale units.
    internal partial interface IScaleUnitListInternal

    {
        /// <summary>URI to the next page.</summary>
        string NextLink { get; set; }
        /// <summary>List of scale units.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnit[] Value { get; set; }

    }
}