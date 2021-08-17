namespace Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Extensions;

    /// <summary>List of key-value pairs.</summary>
    public partial class ResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceTags,
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceTagsInternal
    {

        /// <summary>Creates an new <see cref="ResourceTags" /> instance.</summary>
        public ResourceTags()
        {

        }
    }
    /// List of key-value pairs.
    public partial interface IResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.IAssociativeArray<string>
    {

    }
    /// List of key-value pairs.
    internal partial interface IResourceTagsInternal

    {

    }
}