namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Representation of a drive resource.</summary>
    public partial class Drive :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDrive,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveInternal,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.Resource();

        /// <summary>
        /// Detailed recommended action for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string Action { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).Action; }

        /// <summary>Total capacity in GB of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public int? CapacityGB { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).CapacityGb; }

        /// <summary>
        /// Detailed description for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).Description; }

        /// <summary>The firmware version of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string FirmwareVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).FirmwareVersion; }

        /// <summary>Health status of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string HealthStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).HealthStatus; }

        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Id; }

        /// <summary>Indicate whether the drive's identification LEDs are active or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public bool? IsIndicationEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).IsIndicationEnabled; }

        /// <summary>The region where the resource is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>The name of the drive's manufacturer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string Manufacturer { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).Manufacturer; }

        /// <summary>Media type of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string MediaType { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).MediaType; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Action</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveInternal.Action { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).Action; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).Action = value; }

        /// <summary>Internal Acessors for CapacityGB</summary>
        int? Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveInternal.CapacityGB { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).CapacityGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).CapacityGb = value; }

        /// <summary>Internal Acessors for Description</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveInternal.Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).Description = value; }

        /// <summary>Internal Acessors for FirmwareVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveInternal.FirmwareVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).FirmwareVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).FirmwareVersion = value; }

        /// <summary>Internal Acessors for HealthStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveInternal.HealthStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).HealthStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).HealthStatus = value; }

        /// <summary>Internal Acessors for IsIndicationEnabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveInternal.IsIndicationEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).IsIndicationEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).IsIndicationEnabled = value; }

        /// <summary>Internal Acessors for Manufacturer</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveInternal.Manufacturer { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).Manufacturer; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).Manufacturer = value; }

        /// <summary>Internal Acessors for MediaType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveInternal.MediaType { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).MediaType; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).MediaType = value; }

        /// <summary>Internal Acessors for Model</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveInternal.Model { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).Model; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).Model = value; }

        /// <summary>Internal Acessors for OperationalStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveInternal.OperationalStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).OperationalStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).OperationalStatus = value; }

        /// <summary>Internal Acessors for PhysicalLocation</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveInternal.PhysicalLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).PhysicalLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).PhysicalLocation = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModel Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.DriveModel()); set { {_property = value;} } }

        /// <summary>Internal Acessors for SerialNumber</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveInternal.SerialNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).SerialNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).SerialNumber = value; }

        /// <summary>Internal Acessors for StorageNode</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveInternal.StorageNode { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).StorageNode; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).StorageNode = value; }

        /// <summary>Internal Acessors for StoragePool</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveInternal.StoragePool { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).StoragePool; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).StoragePool = value; }

        /// <summary>Internal Acessors for Usage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveInternal.Usage { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).Usage; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).Usage = value; }

        /// <summary>Model of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string Model { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).Model; }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Name; }

        /// <summary>Operational status of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string OperationalStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).OperationalStatus; }

        /// <summary>Indicate where the hardware is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string PhysicalLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).PhysicalLocation; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModel _property;

        /// <summary>Properties of a drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModel Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.DriveModel()); set => this._property = value; }

        /// <summary>Serial number of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string SerialNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).SerialNumber; }

        /// <summary>Node that the drive is physically connected.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string StorageNode { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).StorageNode; }

        /// <summary>The storage pool where the drive is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string StoragePool { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).StoragePool; }

        /// <summary>List of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Tag = value ?? null /* model class */; }

        /// <summary>Type of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Type; }

        /// <summary>Intended usage of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string Usage { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModelInternal)Property).Usage; }

        /// <summary>Creates an new <see cref="Drive" /> instance.</summary>
        public Drive()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Representation of a drive resource.
    public partial interface IDrive :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResource
    {
        /// <summary>
        /// Detailed recommended action for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Detailed recommended action for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.",
        SerializedName = @"action",
        PossibleTypes = new [] { typeof(string) })]
        string Action { get;  }
        /// <summary>Total capacity in GB of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Total capacity in GB of the drive.",
        SerializedName = @"capacityGB",
        PossibleTypes = new [] { typeof(int) })]
        int? CapacityGB { get;  }
        /// <summary>
        /// Detailed description for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Detailed description for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get;  }
        /// <summary>The firmware version of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The firmware version of the drive.",
        SerializedName = @"firmwareVersion",
        PossibleTypes = new [] { typeof(string) })]
        string FirmwareVersion { get;  }
        /// <summary>Health status of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Health status of the drive.",
        SerializedName = @"healthStatus",
        PossibleTypes = new [] { typeof(string) })]
        string HealthStatus { get;  }
        /// <summary>Indicate whether the drive's identification LEDs are active or not.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Indicate whether the drive's identification LEDs are active or not.",
        SerializedName = @"isIndicationEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsIndicationEnabled { get;  }
        /// <summary>The name of the drive's manufacturer.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of the drive's manufacturer.",
        SerializedName = @"manufacturer",
        PossibleTypes = new [] { typeof(string) })]
        string Manufacturer { get;  }
        /// <summary>Media type of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Media type of the drive.",
        SerializedName = @"mediaType",
        PossibleTypes = new [] { typeof(string) })]
        string MediaType { get;  }
        /// <summary>Model of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Model of the drive.",
        SerializedName = @"model",
        PossibleTypes = new [] { typeof(string) })]
        string Model { get;  }
        /// <summary>Operational status of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Operational status of the drive.",
        SerializedName = @"operationalStatus",
        PossibleTypes = new [] { typeof(string) })]
        string OperationalStatus { get;  }
        /// <summary>Indicate where the hardware is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Indicate where the hardware is located.",
        SerializedName = @"physicalLocation",
        PossibleTypes = new [] { typeof(string) })]
        string PhysicalLocation { get;  }
        /// <summary>Serial number of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Serial number of the drive.",
        SerializedName = @"serialNumber",
        PossibleTypes = new [] { typeof(string) })]
        string SerialNumber { get;  }
        /// <summary>Node that the drive is physically connected.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Node that the drive is physically connected.",
        SerializedName = @"storageNode",
        PossibleTypes = new [] { typeof(string) })]
        string StorageNode { get;  }
        /// <summary>The storage pool where the drive is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The storage pool where the drive is located.",
        SerializedName = @"storagePool",
        PossibleTypes = new [] { typeof(string) })]
        string StoragePool { get;  }
        /// <summary>Intended usage of the drive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Intended usage of the drive.",
        SerializedName = @"usage",
        PossibleTypes = new [] { typeof(string) })]
        string Usage { get;  }

    }
    /// Representation of a drive resource.
    internal partial interface IDriveInternal :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal
    {
        /// <summary>
        /// Detailed recommended action for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.
        /// </summary>
        string Action { get; set; }
        /// <summary>Total capacity in GB of the drive.</summary>
        int? CapacityGB { get; set; }
        /// <summary>
        /// Detailed description for HealthStatus/OperationalStatus. Empty if HealthStatus/OperationalStatus is Healthy/Ok.
        /// </summary>
        string Description { get; set; }
        /// <summary>The firmware version of the drive.</summary>
        string FirmwareVersion { get; set; }
        /// <summary>Health status of the drive.</summary>
        string HealthStatus { get; set; }
        /// <summary>Indicate whether the drive's identification LEDs are active or not.</summary>
        bool? IsIndicationEnabled { get; set; }
        /// <summary>The name of the drive's manufacturer.</summary>
        string Manufacturer { get; set; }
        /// <summary>Media type of the drive.</summary>
        string MediaType { get; set; }
        /// <summary>Model of the drive.</summary>
        string Model { get; set; }
        /// <summary>Operational status of the drive.</summary>
        string OperationalStatus { get; set; }
        /// <summary>Indicate where the hardware is located.</summary>
        string PhysicalLocation { get; set; }
        /// <summary>Properties of a drive.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20190501.IDriveModel Property { get; set; }
        /// <summary>Serial number of the drive.</summary>
        string SerialNumber { get; set; }
        /// <summary>Node that the drive is physically connected.</summary>
        string StorageNode { get; set; }
        /// <summary>The storage pool where the drive is located.</summary>
        string StoragePool { get; set; }
        /// <summary>Intended usage of the drive.</summary>
        string Usage { get; set; }

    }
}