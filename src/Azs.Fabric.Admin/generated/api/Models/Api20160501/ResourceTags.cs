namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>List of key-value pairs.</summary>
    public partial class ResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceTags,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceTagsInternal
    {

        /// <summary>Creates an new <see cref="ResourceTags" /> instance.</summary>
        public ResourceTags()
        {

        }
    }
    /// List of key-value pairs.
    public partial interface IResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IAssociativeArray<string>
    {

    }
    /// List of key-value pairs.
    internal partial interface IResourceTagsInternal

    {

    }
}