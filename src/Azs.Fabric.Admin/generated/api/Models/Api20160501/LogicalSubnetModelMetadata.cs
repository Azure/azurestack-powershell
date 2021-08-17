namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Metadata related to the logical network.</summary>
    public partial class LogicalSubnetModelMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalSubnetModelMetadata,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalSubnetModelMetadataInternal
    {

        /// <summary>Creates an new <see cref="LogicalSubnetModelMetadata" /> instance.</summary>
        public LogicalSubnetModelMetadata()
        {

        }
    }
    /// Metadata related to the logical network.
    public partial interface ILogicalSubnetModelMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IAssociativeArray<string>
    {

    }
    /// Metadata related to the logical network.
    internal partial interface ILogicalSubnetModelMetadataInternal

    {

    }
}