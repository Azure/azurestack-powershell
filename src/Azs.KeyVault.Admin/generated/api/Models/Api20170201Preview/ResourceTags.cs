namespace Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.Extensions;

    /// <summary>List of key value pairs.</summary>
    public partial class ResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceTags,
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceTagsInternal
    {

        /// <summary>Creates an new <see cref="ResourceTags" /> instance.</summary>
        public ResourceTags()
        {

        }
    }
    /// List of key value pairs.
    public partial interface IResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.IAssociativeArray<string>
    {

    }
    /// List of key value pairs.
    internal partial interface IResourceTagsInternal

    {

    }
}