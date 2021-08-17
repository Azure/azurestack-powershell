namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Metadata related to the MAC pool.</summary>
    public partial class MacAddressPoolModelMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IMacAddressPoolModelMetadata,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IMacAddressPoolModelMetadataInternal
    {

        /// <summary>Creates an new <see cref="MacAddressPoolModelMetadata" /> instance.</summary>
        public MacAddressPoolModelMetadata()
        {

        }
    }
    /// Metadata related to the MAC pool.
    public partial interface IMacAddressPoolModelMetadata :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IAssociativeArray<string>
    {

    }
    /// Metadata related to the MAC pool.
    internal partial interface IMacAddressPoolModelMetadataInternal

    {

    }
}