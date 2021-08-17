namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Properties of a logical subnet.</summary>
    public partial class LogicalSubnetModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalSubnetModel,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalSubnetModelInternal
    {

        /// <summary>Backing field for <see cref="IPPool" /> property.</summary>
        private string[] _iPPool;

        /// <summary>All IP pools which belong to this subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string[] IPPool { get => this._iPPool; set => this._iPPool = value; }

        /// <summary>Backing field for <see cref="IsPublic" /> property.</summary>
        private bool? _isPublic;

        /// <summary>
        /// The visibility status of the IP pool. If is true the associated pools are public IP address pools.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public bool? IsPublic { get => this._isPublic; set => this._isPublic = value; }

        /// <summary>Backing field for <see cref="Metadata" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalSubnetModelMetadata _metadata;

        /// <summary>Metadata related to the logical network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalSubnetModelMetadata Metadata { get => (this._metadata = this._metadata ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.LogicalSubnetModelMetadata()); set => this._metadata = value; }

        /// <summary>Creates an new <see cref="LogicalSubnetModel" /> instance.</summary>
        public LogicalSubnetModel()
        {

        }
    }
    /// Properties of a logical subnet.
    public partial interface ILogicalSubnetModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>All IP pools which belong to this subnet.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"All IP pools which belong to this subnet.",
        SerializedName = @"ipPools",
        PossibleTypes = new [] { typeof(string) })]
        string[] IPPool { get; set; }
        /// <summary>
        /// The visibility status of the IP pool. If is true the associated pools are public IP address pools.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The visibility status of the IP pool.  If is true the associated pools are public IP address pools.",
        SerializedName = @"isPublic",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsPublic { get; set; }
        /// <summary>Metadata related to the logical network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Metadata related to the logical network.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalSubnetModelMetadata) })]
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalSubnetModelMetadata Metadata { get; set; }

    }
    /// Properties of a logical subnet.
    internal partial interface ILogicalSubnetModelInternal

    {
        /// <summary>All IP pools which belong to this subnet.</summary>
        string[] IPPool { get; set; }
        /// <summary>
        /// The visibility status of the IP pool. If is true the associated pools are public IP address pools.
        /// </summary>
        bool? IsPublic { get; set; }
        /// <summary>Metadata related to the logical network.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalSubnetModelMetadata Metadata { get; set; }

    }
}