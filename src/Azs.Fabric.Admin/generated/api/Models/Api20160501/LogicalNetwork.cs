namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>
    /// This resource represents a logical partition of physical network that is dedicated for a particular purpose. A logical
    /// network comprises a collection of logical subnets.
    /// </summary>
    public partial class LogicalNetwork :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetwork,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkInternal,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.Resource();

        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Id; }

        /// <summary>The region where the resource is located.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Location = value ?? null; }

        /// <summary>Metadata related to the logical network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkModelMetadata Metadata { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkModelInternal)Property).Metadata; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkModelInternal)Property).Metadata = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkModel Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.LogicalNetworkModel()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Type = value; }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Name; }

        /// <summary>
        /// Flag to indicate that the network virtualization is enabled on the logical network.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public bool? NetworkVirtualizationEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkModelInternal)Property).NetworkVirtualizationEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkModelInternal)Property).NetworkVirtualizationEnabled = value ?? default(bool); }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkModel _property;

        /// <summary>Properties of a logical network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkModel Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.LogicalNetworkModel()); set => this._property = value; }

        /// <summary>List of subnets belonging to the logical network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inlined)]
        public string[] Subnets { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkModelInternal)Property).Subnet; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkModelInternal)Property).Subnet = value ?? null /* arrayOf */; }

        /// <summary>List of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Tag = value ?? null /* model class */; }

        /// <summary>Type of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal)__resource).Type; }

        /// <summary>Creates an new <see cref="LogicalNetwork" /> instance.</summary>
        public LogicalNetwork()
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
    /// This resource represents a logical partition of physical network that is dedicated for a particular purpose. A logical
    /// network comprises a collection of logical subnets.
    public partial interface ILogicalNetwork :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResource
    {
        /// <summary>Metadata related to the logical network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Metadata related to the logical network.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkModelMetadata) })]
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkModelMetadata Metadata { get; set; }
        /// <summary>
        /// Flag to indicate that the network virtualization is enabled on the logical network.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag to indicate that the network virtualization is enabled on the logical network.",
        SerializedName = @"networkVirtualizationEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? NetworkVirtualizationEnabled { get; set; }
        /// <summary>List of subnets belonging to the logical network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of subnets belonging to the logical network.",
        SerializedName = @"subnets",
        PossibleTypes = new [] { typeof(string) })]
        string[] Subnets { get; set; }

    }
    /// This resource represents a logical partition of physical network that is dedicated for a particular purpose. A logical
    /// network comprises a collection of logical subnets.
    internal partial interface ILogicalNetworkInternal :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IResourceInternal
    {
        /// <summary>Metadata related to the logical network.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkModelMetadata Metadata { get; set; }
        /// <summary>
        /// Flag to indicate that the network virtualization is enabled on the logical network.
        /// </summary>
        bool? NetworkVirtualizationEnabled { get; set; }
        /// <summary>Properties of a logical network.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ILogicalNetworkModel Property { get; set; }
        /// <summary>List of subnets belonging to the logical network.</summary>
        string[] Subnets { get; set; }

    }
}