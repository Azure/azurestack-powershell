namespace Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.Extensions;

    /// <summary>KeyVault Quota.</summary>
    public partial class Quota :
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IQuota,
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IQuotaInternal,
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.Resource();

        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceInternal)__resource).Id; }

        /// <summary>Location where resource is location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceInternal)__resource).Location; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Location</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceInternal.Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceInternal)__resource).Location = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Tag</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceTags Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceInternal.Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceInternal)__resource).Tag = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceInternal)__resource).Type = value; }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.IAny _property;

        /// <summary>Properties for keyvault quotas.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.IAny Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Any()); set => this._property = value; }

        /// <summary>List of key value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceInternal)__resource).Tag; }

        /// <summary>Type of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="Quota" /> instance.</summary>
        public Quota()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// KeyVault Quota.
    public partial interface IQuota :
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResource
    {
        /// <summary>Properties for keyvault quotas.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Properties for keyvault quotas.",
        SerializedName = @"properties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.IAny) })]
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.IAny Property { get; set; }

    }
    /// KeyVault Quota.
    internal partial interface IQuotaInternal :
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.Api20170201Preview.IResourceInternal
    {
        /// <summary>Properties for keyvault quotas.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.KeyvaultAdmin.Models.IAny Property { get; set; }

    }
}