namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Extensions;

    /// <summary>List of key value pairs.</summary>
    public partial class ResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceTags,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.IResourceTagsInternal
    {

        /// <summary>Creates an new <see cref="ResourceTags" /> instance.</summary>
        public ResourceTags()
        {

        }
    }
    /// List of key value pairs.
    public partial interface IResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.IAssociativeArray<string>
    {

    }
    /// List of key value pairs.
    internal partial interface IResourceTagsInternal

    {

    }
}