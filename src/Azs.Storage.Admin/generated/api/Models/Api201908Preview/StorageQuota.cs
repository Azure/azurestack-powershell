namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Extensions;

    /// <summary>Storage quota.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.DoNotFormat]
    public partial class StorageQuota :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuota,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuotaInternal,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.Resource();

        /// <summary>Maximum capacity (GB).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public int? CapacityInGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuotaPropertiesInternal)Property).CapacityInGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuotaPropertiesInternal)Property).CapacityInGb = value ?? default(int); }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)__resource).Id; }

        /// <summary>Resource Location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)__resource).Location; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Location</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal.Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)__resource).Location = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuotaProperties Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuotaInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageQuotaProperties()); set { {_property = value;} } }

        /// <summary>Resource Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)__resource).Name; }

        /// <summary>Total number of storage accounts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inlined)]
        public int? NumberOfStorageAccounts { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuotaPropertiesInternal)Property).NumberOfStorageAccount; set => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuotaPropertiesInternal)Property).NumberOfStorageAccount = value ?? default(int); }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuotaProperties _property;

        /// <summary>Storage quota properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuotaProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.StorageQuotaProperties()); set => this._property = value; }

        /// <summary>Resource Type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="StorageQuota" /> instance.</summary>
        public StorageQuota()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Storage quota.
    public partial interface IStorageQuota :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResource
    {
        /// <summary>Maximum capacity (GB).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Maximum capacity (GB).",
        SerializedName = @"capacityInGb",
        PossibleTypes = new [] { typeof(int) })]
        int? CapacityInGb { get; set; }
        /// <summary>Total number of storage accounts.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Total number of storage accounts.",
        SerializedName = @"numberOfStorageAccounts",
        PossibleTypes = new [] { typeof(int) })]
        int? NumberOfStorageAccounts { get; set; }

    }
    /// Storage quota.
    internal partial interface IStorageQuotaInternal :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IResourceInternal
    {
        /// <summary>Maximum capacity (GB).</summary>
        int? CapacityInGb { get; set; }
        /// <summary>Total number of storage accounts.</summary>
        int? NumberOfStorageAccounts { get; set; }
        /// <summary>Storage quota properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IStorageQuotaProperties Property { get; set; }

    }
}