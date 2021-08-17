namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001
{
    using Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.PowerShell;

    /// <summary>A list of input data that allows for creating the new scale unit.</summary>
    [System.ComponentModel.TypeConverter(typeof(CreateFromJsonScaleUnitParametersListTypeConverter))]
    public partial class CreateFromJsonScaleUnitParametersList
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.CreateFromJsonScaleUnitParametersList"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CreateFromJsonScaleUnitParametersList(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).InfrastructureNetwork = (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.INetworkDefinitionParameter) content.GetValueForProperty("InfrastructureNetwork",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).InfrastructureNetwork, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.NetworkDefinitionParameterTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).StorageNetwork = (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.INetworkDefinitionParameter) content.GetValueForProperty("StorageNetwork",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).StorageNetwork, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.NetworkDefinitionParameterTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).ClusterName = (string) content.GetValueForProperty("ClusterName",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).ClusterName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).PhysicalNode = (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IDeploymentJsonPhysicalNodeParameters[]) content.GetValueForProperty("PhysicalNode",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).PhysicalNode, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IDeploymentJsonPhysicalNodeParameters>(__y, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.DeploymentJsonPhysicalNodeParametersTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).TorSwitchBgpAsn = (string) content.GetValueForProperty("TorSwitchBgpAsn",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).TorSwitchBgpAsn, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).SoftwareBgpAsn = (string) content.GetValueForProperty("SoftwareBgpAsn",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).SoftwareBgpAsn, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).TorSwitchBgpPeerIP = (string[]) content.GetValueForProperty("TorSwitchBgpPeerIP",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).TorSwitchBgpPeerIP, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).NetQosPriority = (int?) content.GetValueForProperty("NetQosPriority",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).NetQosPriority, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).InfrastructureNetworkSubnet = (string[]) content.GetValueForProperty("InfrastructureNetworkSubnet",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).InfrastructureNetworkSubnet, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).InfrastructureNetworkVlanId = (string[]) content.GetValueForProperty("InfrastructureNetworkVlanId",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).InfrastructureNetworkVlanId, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).StorageNetworkSubnet = (string[]) content.GetValueForProperty("StorageNetworkSubnet",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).StorageNetworkSubnet, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).StorageNetworkVlanId = (string[]) content.GetValueForProperty("StorageNetworkVlanId",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).StorageNetworkVlanId, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.CreateFromJsonScaleUnitParametersList"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CreateFromJsonScaleUnitParametersList(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).InfrastructureNetwork = (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.INetworkDefinitionParameter) content.GetValueForProperty("InfrastructureNetwork",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).InfrastructureNetwork, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.NetworkDefinitionParameterTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).StorageNetwork = (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.INetworkDefinitionParameter) content.GetValueForProperty("StorageNetwork",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).StorageNetwork, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.NetworkDefinitionParameterTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).ClusterName = (string) content.GetValueForProperty("ClusterName",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).ClusterName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).PhysicalNode = (Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IDeploymentJsonPhysicalNodeParameters[]) content.GetValueForProperty("PhysicalNode",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).PhysicalNode, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IDeploymentJsonPhysicalNodeParameters>(__y, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.DeploymentJsonPhysicalNodeParametersTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).TorSwitchBgpAsn = (string) content.GetValueForProperty("TorSwitchBgpAsn",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).TorSwitchBgpAsn, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).SoftwareBgpAsn = (string) content.GetValueForProperty("SoftwareBgpAsn",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).SoftwareBgpAsn, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).TorSwitchBgpPeerIP = (string[]) content.GetValueForProperty("TorSwitchBgpPeerIP",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).TorSwitchBgpPeerIP, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).NetQosPriority = (int?) content.GetValueForProperty("NetQosPriority",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).NetQosPriority, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).InfrastructureNetworkSubnet = (string[]) content.GetValueForProperty("InfrastructureNetworkSubnet",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).InfrastructureNetworkSubnet, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).InfrastructureNetworkVlanId = (string[]) content.GetValueForProperty("InfrastructureNetworkVlanId",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).InfrastructureNetworkVlanId, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).StorageNetworkSubnet = (string[]) content.GetValueForProperty("StorageNetworkSubnet",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).StorageNetworkSubnet, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            ((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).StorageNetworkVlanId = (string[]) content.GetValueForProperty("StorageNetworkVlanId",((Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersListInternal)this).StorageNetworkVlanId, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.CreateFromJsonScaleUnitParametersList"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersList"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersList DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CreateFromJsonScaleUnitParametersList(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.CreateFromJsonScaleUnitParametersList"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersList"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersList DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CreateFromJsonScaleUnitParametersList(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CreateFromJsonScaleUnitParametersList" />, deserializing the content from a json
        /// string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.ICreateFromJsonScaleUnitParametersList FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// A list of input data that allows for creating the new scale unit.
    [System.ComponentModel.TypeConverter(typeof(CreateFromJsonScaleUnitParametersListTypeConverter))]
    public partial interface ICreateFromJsonScaleUnitParametersList

    {

    }
}