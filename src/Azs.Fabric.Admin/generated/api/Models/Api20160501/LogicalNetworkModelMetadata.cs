namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Metadata related to the logical network.</summary>
    public partial class LogicalNetworkModelMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkModelMetadata,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkModelMetadataInternal
    {

        /// <summary>Creates an new <see cref="LogicalNetworkModelMetadata" /> instance.</summary>
        public LogicalNetworkModelMetadata()
        {

        }
    }
    /// Metadata related to the logical network.
    public partial interface ILogicalNetworkModelMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IAssociativeArray<string>
    {

    }
    /// Metadata related to the logical network.
    internal partial interface ILogicalNetworkModelMetadataInternal

    {

    }
}