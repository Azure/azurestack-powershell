namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330
{
    using Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.PowerShell;

    /// <summary>Properties for a virtual machine</summary>
    [System.ComponentModel.TypeConverter(typeof(VirtualMachineViewTypeConverter))]
    public partial class VirtualMachineView
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.VirtualMachineView"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineView" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineView DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VirtualMachineView(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.VirtualMachineView"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineView" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineView DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VirtualMachineView(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VirtualMachineView" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineView FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.VirtualMachineView"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VirtualMachineView(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).VMName = (string) content.GetValueForProperty("VMName",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).VMName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).VMId = (string) content.GetValueForProperty("VMId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).VMId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).SubscriptionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).ResourceGroupName = (string) content.GetValueForProperty("ResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).ResourceGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).VMSize = (string) content.GetValueForProperty("VMSize",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).VMSize, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).VMScaleSetName = (string) content.GetValueForProperty("VMScaleSetName",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).VMScaleSetName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).LastProvisioningErrorMessage = (string) content.GetValueForProperty("LastProvisioningErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).LastProvisioningErrorMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).TimeOfLastConfigurationChange = (string) content.GetValueForProperty("TimeOfLastConfigurationChange",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).TimeOfLastConfigurationChange, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).PowerState = (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.VMPowerState?) content.GetValueForProperty("PowerState",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).PowerState, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.VMPowerState.CreateFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.VirtualMachineView"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VirtualMachineView(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).VMName = (string) content.GetValueForProperty("VMName",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).VMName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).VMId = (string) content.GetValueForProperty("VMId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).VMId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).SubscriptionId = (string) content.GetValueForProperty("SubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).SubscriptionId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).ResourceGroupName = (string) content.GetValueForProperty("ResourceGroupName",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).ResourceGroupName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).VMSize = (string) content.GetValueForProperty("VMSize",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).VMSize, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).VMScaleSetName = (string) content.GetValueForProperty("VMScaleSetName",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).VMScaleSetName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).LastProvisioningErrorMessage = (string) content.GetValueForProperty("LastProvisioningErrorMessage",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).LastProvisioningErrorMessage, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).TimeOfLastConfigurationChange = (string) content.GetValueForProperty("TimeOfLastConfigurationChange",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).TimeOfLastConfigurationChange, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).PowerState = (Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.VMPowerState?) content.GetValueForProperty("PowerState",((Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IVirtualMachineViewInternal)this).PowerState, Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Support.VMPowerState.CreateFrom);
            AfterDeserializePSObject(content);
        }
    }
    /// Properties for a virtual machine
    [System.ComponentModel.TypeConverter(typeof(VirtualMachineViewTypeConverter))]
    public partial interface IVirtualMachineView

    {

    }
}