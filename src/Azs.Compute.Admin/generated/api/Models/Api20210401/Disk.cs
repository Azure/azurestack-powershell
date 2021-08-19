namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Managed Disk.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.DoNotFormat]
    public partial class Disk :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDisk,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.Resource();

        /// <summary>The actual size of disk in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public long? ActualSizeGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).ActualSizeGb; }

        /// <summary>The disk creation option.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskCreationOption? CreationOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).CreationOption; }

        /// <summary>The disk creation source uri.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public string CreationSourceUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).CreationSourceUri; }

        /// <summary>The disk id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public string DiskId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).DiskId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).DiskId = value ?? null; }

        /// <summary>the disk sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.AccountType? DiskSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).DiskSku; }

        /// <summary>The type of the disk resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskResourceType? DiskType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).DiskType; }

        /// <summary>The exclusive allocated size for the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public long? ExclusiveAllocatedSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).ExclusiveAllocatedSize; }

        /// <summary>ID of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Id; }

        /// <summary>Location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Compute resource Uri which owns this disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public string ManagedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).ManagedBy; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for ActualSizeGb</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal.ActualSizeGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).ActualSizeGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).ActualSizeGb = value; }

        /// <summary>Internal Acessors for CreationOption</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskCreationOption? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal.CreationOption { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).CreationOption; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).CreationOption = value; }

        /// <summary>Internal Acessors for CreationSourceUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal.CreationSourceUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).CreationSourceUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).CreationSourceUri = value; }

        /// <summary>Internal Acessors for DiskSku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.AccountType? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal.DiskSku { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).DiskSku; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).DiskSku = value; }

        /// <summary>Internal Acessors for DiskType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskResourceType? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal.DiskType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).DiskType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).DiskType = value; }

        /// <summary>Internal Acessors for ExclusiveAllocatedSize</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal.ExclusiveAllocatedSize { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).ExclusiveAllocatedSize; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).ExclusiveAllocatedSize = value; }

        /// <summary>Internal Acessors for ManagedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal.ManagedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).ManagedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).ManagedBy = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskProperties Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.DiskProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisionSizeGb</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal.ProvisionSizeGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).ProvisionSizeGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).ProvisionSizeGb = value; }

        /// <summary>Internal Acessors for UserResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskInternal.UserResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).UserResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).UserResourceId = value; }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskProperties _property;

        /// <summary>Disk properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.DiskProperties()); set => this._property = value; }

        /// <summary>The provision size of disk in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public long? ProvisionSizeGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).ProvisionSizeGb; }

        /// <summary>The disk share path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public string SharePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).SharePath; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).SharePath = value ?? null; }

        /// <summary>The disk status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskState? Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).Status = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskState)""); }

        /// <summary>Type of Resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal)__resource).Type; }

        /// <summary>The disk resource Uri from user view.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Inlined)]
        public string UserResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal)Property).UserResourceId; }

        /// <summary>Creates an new <see cref="Disk" /> instance.</summary>
        public Disk()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Managed Disk.
    public partial interface IDisk :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResource
    {
        /// <summary>The actual size of disk in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The actual size of disk in GB.",
        SerializedName = @"actualSizeGB",
        PossibleTypes = new [] { typeof(long) })]
        long? ActualSizeGb { get;  }
        /// <summary>The disk creation option.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The disk creation option.",
        SerializedName = @"creationOption",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskCreationOption) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskCreationOption? CreationOption { get;  }
        /// <summary>The disk creation source uri.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The disk creation source uri.",
        SerializedName = @"creationSourceUri",
        PossibleTypes = new [] { typeof(string) })]
        string CreationSourceUri { get;  }
        /// <summary>The disk id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The disk id.",
        SerializedName = @"diskId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskId { get; set; }
        /// <summary>the disk sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"the disk sku.",
        SerializedName = @"diskSku",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.AccountType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.AccountType? DiskSku { get;  }
        /// <summary>The type of the disk resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The type of the disk resource.",
        SerializedName = @"diskType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskResourceType) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskResourceType? DiskType { get;  }
        /// <summary>The exclusive allocated size for the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The exclusive allocated size for the disk.",
        SerializedName = @"exclusiveAllocatedSize",
        PossibleTypes = new [] { typeof(long) })]
        long? ExclusiveAllocatedSize { get;  }
        /// <summary>Compute resource Uri which owns this disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Compute resource Uri which owns this disk.",
        SerializedName = @"managedBy",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedBy { get;  }
        /// <summary>The provision size of disk in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provision size of disk in GB.",
        SerializedName = @"provisionSizeGB",
        PossibleTypes = new [] { typeof(long) })]
        long? ProvisionSizeGb { get;  }
        /// <summary>The disk share path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The disk share path.",
        SerializedName = @"sharePath",
        PossibleTypes = new [] { typeof(string) })]
        string SharePath { get; set; }
        /// <summary>The disk status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The disk status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskState) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskState? Status { get; set; }
        /// <summary>The disk resource Uri from user view.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The disk resource Uri from user view.",
        SerializedName = @"userResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string UserResourceId { get;  }

    }
    /// Managed Disk.
    internal partial interface IDiskInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20151201Preview.IResourceInternal
    {
        /// <summary>The actual size of disk in GB.</summary>
        long? ActualSizeGb { get; set; }
        /// <summary>The disk creation option.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskCreationOption? CreationOption { get; set; }
        /// <summary>The disk creation source uri.</summary>
        string CreationSourceUri { get; set; }
        /// <summary>The disk id.</summary>
        string DiskId { get; set; }
        /// <summary>the disk sku.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.AccountType? DiskSku { get; set; }
        /// <summary>The type of the disk resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskResourceType? DiskType { get; set; }
        /// <summary>The exclusive allocated size for the disk.</summary>
        long? ExclusiveAllocatedSize { get; set; }
        /// <summary>Compute resource Uri which owns this disk.</summary>
        string ManagedBy { get; set; }
        /// <summary>Disk properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskProperties Property { get; set; }
        /// <summary>The provision size of disk in GB.</summary>
        long? ProvisionSizeGb { get; set; }
        /// <summary>The disk share path.</summary>
        string SharePath { get; set; }
        /// <summary>The disk status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskState? Status { get; set; }
        /// <summary>The disk resource Uri from user view.</summary>
        string UserResourceId { get; set; }

    }
}