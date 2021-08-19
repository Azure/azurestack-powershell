namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Managed disk properties.</summary>
    public partial class DiskProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal
    {

        /// <summary>Backing field for <see cref="ActualSizeGb" /> property.</summary>
        private long? _actualSizeGb;

        /// <summary>The actual size of disk in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public long? ActualSizeGb { get => this._actualSizeGb; }

        /// <summary>Backing field for <see cref="CreationOption" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskCreationOption? _creationOption;

        /// <summary>The disk creation option.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskCreationOption? CreationOption { get => this._creationOption; }

        /// <summary>Backing field for <see cref="CreationSourceUri" /> property.</summary>
        private string _creationSourceUri;

        /// <summary>The disk creation source uri.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string CreationSourceUri { get => this._creationSourceUri; }

        /// <summary>Backing field for <see cref="DiskId" /> property.</summary>
        private string _diskId;

        /// <summary>The disk id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string DiskId { get => this._diskId; set => this._diskId = value; }

        /// <summary>Backing field for <see cref="DiskSku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.AccountType? _diskSku;

        /// <summary>the disk sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.AccountType? DiskSku { get => this._diskSku; }

        /// <summary>Backing field for <see cref="DiskType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskResourceType? _diskType;

        /// <summary>The type of the disk resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskResourceType? DiskType { get => this._diskType; }

        /// <summary>Backing field for <see cref="ExclusiveAllocatedSize" /> property.</summary>
        private long? _exclusiveAllocatedSize;

        /// <summary>The exclusive allocated size for the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public long? ExclusiveAllocatedSize { get => this._exclusiveAllocatedSize; }

        /// <summary>Backing field for <see cref="ManagedBy" /> property.</summary>
        private string _managedBy;

        /// <summary>Compute resource Uri which owns this disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string ManagedBy { get => this._managedBy; }

        /// <summary>Internal Acessors for ActualSizeGb</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal.ActualSizeGb { get => this._actualSizeGb; set { {_actualSizeGb = value;} } }

        /// <summary>Internal Acessors for CreationOption</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskCreationOption? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal.CreationOption { get => this._creationOption; set { {_creationOption = value;} } }

        /// <summary>Internal Acessors for CreationSourceUri</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal.CreationSourceUri { get => this._creationSourceUri; set { {_creationSourceUri = value;} } }

        /// <summary>Internal Acessors for DiskSku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.AccountType? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal.DiskSku { get => this._diskSku; set { {_diskSku = value;} } }

        /// <summary>Internal Acessors for DiskType</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskResourceType? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal.DiskType { get => this._diskType; set { {_diskType = value;} } }

        /// <summary>Internal Acessors for ExclusiveAllocatedSize</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal.ExclusiveAllocatedSize { get => this._exclusiveAllocatedSize; set { {_exclusiveAllocatedSize = value;} } }

        /// <summary>Internal Acessors for ManagedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal.ManagedBy { get => this._managedBy; set { {_managedBy = value;} } }

        /// <summary>Internal Acessors for ProvisionSizeGb</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal.ProvisionSizeGb { get => this._provisionSizeGb; set { {_provisionSizeGb = value;} } }

        /// <summary>Internal Acessors for UserResourceId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210401.IDiskPropertiesInternal.UserResourceId { get => this._userResourceId; set { {_userResourceId = value;} } }

        /// <summary>Backing field for <see cref="ProvisionSizeGb" /> property.</summary>
        private long? _provisionSizeGb;

        /// <summary>The provision size of disk in GB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public long? ProvisionSizeGb { get => this._provisionSizeGb; }

        /// <summary>Backing field for <see cref="SharePath" /> property.</summary>
        private string _sharePath;

        /// <summary>The disk share path.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string SharePath { get => this._sharePath; set => this._sharePath = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskState? _status;

        /// <summary>The disk status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.DiskState? Status { get => this._status; set => this._status = value; }

        /// <summary>Backing field for <see cref="UserResourceId" /> property.</summary>
        private string _userResourceId;

        /// <summary>The disk resource Uri from user view.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string UserResourceId { get => this._userResourceId; }

        /// <summary>Creates an new <see cref="DiskProperties" /> instance.</summary>
        public DiskProperties()
        {

        }
    }
    /// Managed disk properties.
    public partial interface IDiskProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable
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
    /// Managed disk properties.
    internal partial interface IDiskPropertiesInternal

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