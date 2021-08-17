namespace Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Extensions;

    /// <summary>List of key-value pairs.</summary>
    public partial class ResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.IResourceTags,
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.IResourceTagsInternal
    {

        /// <summary>Creates an new <see cref="ResourceTags" /> instance.</summary>
        public ResourceTags()
        {

        }
    }
    /// List of key-value pairs.
    public partial interface IResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.IAssociativeArray<string>
    {

    }
    /// List of key-value pairs.
    internal partial interface IResourceTagsInternal

    {

    }
}