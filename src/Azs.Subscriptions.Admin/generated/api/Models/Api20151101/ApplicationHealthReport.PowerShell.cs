namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.PowerShell;

    /// <summary>A report of the health status of an identity applications.</summary>
    [System.ComponentModel.TypeConverter(typeof(ApplicationHealthReportTypeConverter))]
    public partial class ApplicationHealthReport
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ApplicationHealthReport"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ApplicationHealthReport(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).AppRoleAssignments = (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentHealthReportList) content.GetValueForProperty("AppRoleAssignments",((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).AppRoleAssignments, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.AppRoleAssignmentHealthReportListTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).OAuth2PermissionGrants = (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReportList) content.GetValueForProperty("OAuth2PermissionGrants",((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).OAuth2PermissionGrants, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.OAuth2PermissionGrantHealthReportListTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).ServicePrincipalTags = (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IServicePrincipalTagHealthReportList) content.GetValueForProperty("ServicePrincipalTags",((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).ServicePrincipalTags, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ServicePrincipalTagHealthReportListTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).AppId = (string) content.GetValueForProperty("AppId",((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).AppId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).ServicePrincipalObjectId = (string) content.GetValueForProperty("ServicePrincipalObjectId",((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).ServicePrincipalObjectId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).AppRoleAssignmentValue = (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentHealthReport[]) content.GetValueForProperty("AppRoleAssignmentValue",((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).AppRoleAssignmentValue, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentHealthReport>(__y, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.AppRoleAssignmentHealthReportTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).AppRoleAssignmentNextLink = (string) content.GetValueForProperty("AppRoleAssignmentNextLink",((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).AppRoleAssignmentNextLink, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).OAuth2PermissionGrantValue = (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReport[]) content.GetValueForProperty("OAuth2PermissionGrantValue",((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).OAuth2PermissionGrantValue, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReport>(__y, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.OAuth2PermissionGrantHealthReportTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).OAuth2PermissionGrantNextLink = (string) content.GetValueForProperty("OAuth2PermissionGrantNextLink",((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).OAuth2PermissionGrantNextLink, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).ServicePrincipalTagValue = (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IServicePrincipalTagHealthReport[]) content.GetValueForProperty("ServicePrincipalTagValue",((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).ServicePrincipalTagValue, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IServicePrincipalTagHealthReport>(__y, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ServicePrincipalTagHealthReportTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).ServicePrincipalTagNextLink = (string) content.GetValueForProperty("ServicePrincipalTagNextLink",((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).ServicePrincipalTagNextLink, global::System.Convert.ToString);
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ApplicationHealthReport"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ApplicationHealthReport(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).AppRoleAssignments = (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentHealthReportList) content.GetValueForProperty("AppRoleAssignments",((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).AppRoleAssignments, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.AppRoleAssignmentHealthReportListTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).OAuth2PermissionGrants = (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReportList) content.GetValueForProperty("OAuth2PermissionGrants",((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).OAuth2PermissionGrants, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.OAuth2PermissionGrantHealthReportListTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).ServicePrincipalTags = (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IServicePrincipalTagHealthReportList) content.GetValueForProperty("ServicePrincipalTags",((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).ServicePrincipalTags, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ServicePrincipalTagHealthReportListTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).AppId = (string) content.GetValueForProperty("AppId",((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).AppId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).ServicePrincipalObjectId = (string) content.GetValueForProperty("ServicePrincipalObjectId",((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).ServicePrincipalObjectId, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus?) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.HealthStatus.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).AppRoleAssignmentValue = (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentHealthReport[]) content.GetValueForProperty("AppRoleAssignmentValue",((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).AppRoleAssignmentValue, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IAppRoleAssignmentHealthReport>(__y, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.AppRoleAssignmentHealthReportTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).AppRoleAssignmentNextLink = (string) content.GetValueForProperty("AppRoleAssignmentNextLink",((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).AppRoleAssignmentNextLink, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).OAuth2PermissionGrantValue = (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReport[]) content.GetValueForProperty("OAuth2PermissionGrantValue",((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).OAuth2PermissionGrantValue, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IOAuth2PermissionGrantHealthReport>(__y, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.OAuth2PermissionGrantHealthReportTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).OAuth2PermissionGrantNextLink = (string) content.GetValueForProperty("OAuth2PermissionGrantNextLink",((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).OAuth2PermissionGrantNextLink, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).ServicePrincipalTagValue = (Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IServicePrincipalTagHealthReport[]) content.GetValueForProperty("ServicePrincipalTagValue",((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).ServicePrincipalTagValue, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IServicePrincipalTagHealthReport>(__y, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ServicePrincipalTagHealthReportTypeConverter.ConvertFrom));
            ((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).ServicePrincipalTagNextLink = (string) content.GetValueForProperty("ServicePrincipalTagNextLink",((Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReportInternal)this).ServicePrincipalTagNextLink, global::System.Convert.ToString);
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ApplicationHealthReport"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReport"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReport DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ApplicationHealthReport(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.ApplicationHealthReport"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReport"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReport DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ApplicationHealthReport(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ApplicationHealthReport" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IApplicationHealthReport FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// A report of the health status of an identity applications.
    [System.ComponentModel.TypeConverter(typeof(ApplicationHealthReportTypeConverter))]
    public partial interface IApplicationHealthReport

    {

    }
}