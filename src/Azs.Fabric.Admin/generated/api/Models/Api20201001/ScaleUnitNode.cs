namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>The physical server in a cluster.</summary>
    public partial class ScaleUnitNode :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNode,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeInternal,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.Resource();

        /// <summary>BIOS version of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string BiosVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).BiosVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).BiosVersion = value ?? null; }

        /// <summary>BMC address of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string BmcAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).BmcAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).BmcAddress = value ?? null; }

        /// <summary>Value indicating whether the node can be powered off.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public bool? CanPowerOff { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).CanPowerOff; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).CanPowerOff = value ?? default(bool); }

        /// <summary>The number of CPU cores for the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public long? CapacityOfCores { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).CapacityCore; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).CapacityCore = value ?? default(long); }

        /// <summary>The memory for the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public float? CapacityOfMemoryInGB { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).CapacityMemoryGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).CapacityMemoryGb = value ?? default(float); }

        /// <summary>GPU resource list of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModel[] Gpu { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).Gpu; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).Gpu = value ?? null /* arrayOf */; }

        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Id; }

        /// <summary>The region where the resource is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Type = value; }

        /// <summary>Internal Acessors for Capacity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitCapacity Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeInternal.Capacity { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).Capacity; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).Capacity = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModel Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ScaleUnitNodeModel()); set { {_property = value;} } }

        /// <summary>Model of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string Model { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).Model; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).Model = value ?? null; }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Name; }

        /// <summary>PowerState of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.PowerState? PowerState { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).PowerState; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).PowerState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.PowerState)""); }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModel _property;

        /// <summary>Holds all properties related to a scale unit node.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModel Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ScaleUnitNodeModel()); set => this._property = value; }

        /// <summary>Cluster name of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string ScaleUnitName { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).ScaleUnitName; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).ScaleUnitName = value ?? null; }

        /// <summary>Status of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitNodeStatus? ScaleUnitNodeStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).ScaleUnitNodeStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).ScaleUnitNodeStatus = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitNodeStatus)""); }

        /// <summary>URI of the corresponding cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string ScaleUnitUri { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).ScaleUnitUri; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).ScaleUnitUri = value ?? null; }

        /// <summary>Serial number of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string SerialNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).SerialNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).SerialNumber = value ?? null; }

        /// <summary>List of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Tag = value ?? null /* model class */; }

        /// <summary>Type of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Type; }

        /// <summary>Vendor of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string Vendor { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).Vendor; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModelInternal)Property).Vendor = value ?? null; }

        /// <summary>Creates an new <see cref="ScaleUnitNode" /> instance.</summary>
        public ScaleUnitNode()
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
    /// The physical server in a cluster.
    public partial interface IScaleUnitNode :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResource
    {
        /// <summary>BIOS version of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"BIOS version of the physical machine.",
        SerializedName = @"biosVersion",
        PossibleTypes = new [] { typeof(string) })]
        string BiosVersion { get; set; }
        /// <summary>BMC address of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"BMC address of the physical machine.",
        SerializedName = @"bmcAddress",
        PossibleTypes = new [] { typeof(string) })]
        string BmcAddress { get; set; }
        /// <summary>Value indicating whether the node can be powered off.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Value indicating whether the node can be powered off.",
        SerializedName = @"canPowerOff",
        PossibleTypes = new [] { typeof(bool) })]
        bool? CanPowerOff { get; set; }
        /// <summary>The number of CPU cores for the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of CPU cores for the physical machine.",
        SerializedName = @"cores",
        PossibleTypes = new [] { typeof(long) })]
        long? CapacityOfCores { get; set; }
        /// <summary>The memory for the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The memory for the physical machine.",
        SerializedName = @"memoryGB",
        PossibleTypes = new [] { typeof(float) })]
        float? CapacityOfMemoryInGB { get; set; }
        /// <summary>GPU resource list of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"GPU resource list of the physical machine.",
        SerializedName = @"gpus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModel) })]
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModel[] Gpu { get; set; }
        /// <summary>Model of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Model of the physical machine.",
        SerializedName = @"model",
        PossibleTypes = new [] { typeof(string) })]
        string Model { get; set; }
        /// <summary>PowerState of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"PowerState of the physical machine.",
        SerializedName = @"powerState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.PowerState) })]
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.PowerState? PowerState { get; set; }
        /// <summary>Cluster name of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Cluster name of the physical machine.",
        SerializedName = @"scaleUnitName",
        PossibleTypes = new [] { typeof(string) })]
        string ScaleUnitName { get; set; }
        /// <summary>Status of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Status of the physical machine.",
        SerializedName = @"scaleUnitNodeStatus",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitNodeStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitNodeStatus? ScaleUnitNodeStatus { get; set; }
        /// <summary>URI of the corresponding cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI of the corresponding cluster.",
        SerializedName = @"scaleUnitUri",
        PossibleTypes = new [] { typeof(string) })]
        string ScaleUnitUri { get; set; }
        /// <summary>Serial number of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Serial number of the physical machine.",
        SerializedName = @"serialNumber",
        PossibleTypes = new [] { typeof(string) })]
        string SerialNumber { get; set; }
        /// <summary>Vendor of the physical machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Vendor of the physical machine.",
        SerializedName = @"vendor",
        PossibleTypes = new [] { typeof(string) })]
        string Vendor { get; set; }

    }
    /// The physical server in a cluster.
    internal partial interface IScaleUnitNodeInternal :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal
    {
        /// <summary>BIOS version of the physical machine.</summary>
        string BiosVersion { get; set; }
        /// <summary>BMC address of the physical machine.</summary>
        string BmcAddress { get; set; }
        /// <summary>Value indicating whether the node can be powered off.</summary>
        bool? CanPowerOff { get; set; }
        /// <summary>Capacity of the physical machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitCapacity Capacity { get; set; }
        /// <summary>The number of CPU cores for the physical machine.</summary>
        long? CapacityOfCores { get; set; }
        /// <summary>The memory for the physical machine.</summary>
        float? CapacityOfMemoryInGB { get; set; }
        /// <summary>GPU resource list of the physical machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IGpuModel[] Gpu { get; set; }
        /// <summary>Model of the physical machine.</summary>
        string Model { get; set; }
        /// <summary>PowerState of the physical machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.PowerState? PowerState { get; set; }
        /// <summary>Holds all properties related to a scale unit node.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleUnitNodeModel Property { get; set; }
        /// <summary>Cluster name of the physical machine.</summary>
        string ScaleUnitName { get; set; }
        /// <summary>Status of the physical machine.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitNodeStatus? ScaleUnitNodeStatus { get; set; }
        /// <summary>URI of the corresponding cluster.</summary>
        string ScaleUnitUri { get; set; }
        /// <summary>Serial number of the physical machine.</summary>
        string SerialNumber { get; set; }
        /// <summary>Vendor of the physical machine.</summary>
        string Vendor { get; set; }

    }
}