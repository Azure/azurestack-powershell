namespace Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401
{
    using Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.PowerShell;

    /// <summary>Holds UI definition file Uri and deployment template file URIs.</summary>
    [System.ComponentModel.TypeConverter(typeof(DefinitionTemplatesTypeConverter))]
    public partial class DefinitionTemplates
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.DefinitionTemplates"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DefinitionTemplates(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)this).UiDefinitionFileUri = (string) content.GetValueForProperty("UiDefinitionFileUri",((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)this).UiDefinitionFileUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)this).DefaultDeploymentTemplateId = (string) content.GetValueForProperty("DefaultDeploymentTemplateId",((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)this).DefaultDeploymentTemplateId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)this).DeploymentTemplateFileUri = (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentTemplateFileUris) content.GetValueForProperty("DeploymentTemplateFileUri",((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)this).DeploymentTemplateFileUri, Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.DefinitionTemplatesDeploymentTemplateFileUrisTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)this).DeploymentFragmentFileUri = (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentFragmentFileUris) content.GetValueForProperty("DeploymentFragmentFileUri",((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)this).DeploymentFragmentFileUri, Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.DefinitionTemplatesDeploymentFragmentFileUrisTypeConverter.ConvertFrom);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.DefinitionTemplates"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DefinitionTemplates(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)this).UiDefinitionFileUri = (string) content.GetValueForProperty("UiDefinitionFileUri",((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)this).UiDefinitionFileUri, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)this).DefaultDeploymentTemplateId = (string) content.GetValueForProperty("DefaultDeploymentTemplateId",((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)this).DefaultDeploymentTemplateId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)this).DeploymentTemplateFileUri = (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentTemplateFileUris) content.GetValueForProperty("DeploymentTemplateFileUri",((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)this).DeploymentTemplateFileUri, Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.DefinitionTemplatesDeploymentTemplateFileUrisTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)this).DeploymentFragmentFileUri = (Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesDeploymentFragmentFileUris) content.GetValueForProperty("DeploymentFragmentFileUri",((Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplatesInternal)this).DeploymentFragmentFileUri, Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.DefinitionTemplatesDeploymentFragmentFileUrisTypeConverter.ConvertFrom);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.DefinitionTemplates"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplates" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplates DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DefinitionTemplates(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.DefinitionTemplates"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplates" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplates DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DefinitionTemplates(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DefinitionTemplates" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Models.Api20150401.IDefinitionTemplates FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.GalleryAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Holds UI definition file Uri and deployment template file URIs.
    [System.ComponentModel.TypeConverter(typeof(DefinitionTemplatesTypeConverter))]
    public partial interface IDefinitionTemplates

    {

    }
}