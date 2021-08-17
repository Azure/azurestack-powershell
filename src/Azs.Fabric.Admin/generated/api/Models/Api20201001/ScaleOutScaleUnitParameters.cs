namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Input data that allows for adding a scale unit node.</summary>
    public partial class ScaleOutScaleUnitParameters :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleOutScaleUnitParameters,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleOutScaleUnitParametersInternal
    {

        /// <summary>Backing field for <see cref="BmciPv4Address" /> property.</summary>
        private string _bmciPv4Address;

        /// <summary>BMC address of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string BmciPv4Address { get => this._bmciPv4Address; set => this._bmciPv4Address = value; }

        /// <summary>Backing field for <see cref="ComputerName" /> property.</summary>
        private string _computerName;

        /// <summary>Computer name of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string ComputerName { get => this._computerName; set => this._computerName = value; }

        /// <summary>Creates an new <see cref="ScaleOutScaleUnitParameters" /> instance.</summary>
        public ScaleOutScaleUnitParameters()
        {

        }
    }
    /// Input data that allows for adding a scale unit node.
    public partial interface IScaleOutScaleUnitParameters :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>BMC address of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"BMC address of the physical machine.",
        SerializedName = @"bmcIpv4Address",
        PossibleTypes = new [] { typeof(string) })]
        string BmciPv4Address { get; set; }
        /// <summary>Computer name of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Computer name of the physical machine.",
        SerializedName = @"computerName",
        PossibleTypes = new [] { typeof(string) })]
        string ComputerName { get; set; }

    }
    /// Input data that allows for adding a scale unit node.
    internal partial interface IScaleOutScaleUnitParametersInternal

    {
        /// <summary>BMC address of the physical machine.</summary>
        string BmciPv4Address { get; set; }
        /// <summary>Computer name of the physical machine.</summary>
        string ComputerName { get; set; }

    }
}