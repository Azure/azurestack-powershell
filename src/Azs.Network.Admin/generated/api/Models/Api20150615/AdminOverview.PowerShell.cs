namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615
{
    using Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.PowerShell;

    /// <summary>Admin overview resource object.</summary>
    [System.ComponentModel.TypeConverter(typeof(AdminOverviewTypeConverter))]
    public partial class AdminOverview
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverview"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal AdminOverview(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualNetworkHealth = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealth) content.GetValueForProperty("VirtualNetworkHealth",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualNetworkHealth, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceHealthTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).LoadBalancerMuxHealth = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealth) content.GetValueForProperty("LoadBalancerMuxHealth",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).LoadBalancerMuxHealth, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceHealthTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualGatewayHealth = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealth) content.GetValueForProperty("VirtualGatewayHealth",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualGatewayHealth, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceHealthTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).PublicIPAddressUsage = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage) content.GetValueForProperty("PublicIPAddressUsage",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).PublicIPAddressUsage, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceUsageTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).BackendIPUsage = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage) content.GetValueForProperty("BackendIPUsage",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).BackendIPUsage, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceUsageTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).MacAddressUsage = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage) content.GetValueForProperty("MacAddressUsage",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).MacAddressUsage, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceUsageTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).ProvisioningState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualNetworkHealthTotalResourceCount = (long?) content.GetValueForProperty("VirtualNetworkHealthTotalResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualNetworkHealthTotalResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualNetworkHealthHealthyResourceCount = (long?) content.GetValueForProperty("VirtualNetworkHealthHealthyResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualNetworkHealthHealthyResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualNetworkHealthErrorResourceCount = (long?) content.GetValueForProperty("VirtualNetworkHealthErrorResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualNetworkHealthErrorResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualNetworkHealthWarningResourceCount = (long?) content.GetValueForProperty("VirtualNetworkHealthWarningResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualNetworkHealthWarningResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualNetworkHealthUnknownCount = (long?) content.GetValueForProperty("VirtualNetworkHealthUnknownCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualNetworkHealthUnknownCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).LoadBalancerMuxHealthTotalResourceCount = (long?) content.GetValueForProperty("LoadBalancerMuxHealthTotalResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).LoadBalancerMuxHealthTotalResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).LoadBalancerMuxHealthHealthyResourceCount = (long?) content.GetValueForProperty("LoadBalancerMuxHealthHealthyResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).LoadBalancerMuxHealthHealthyResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).LoadBalancerMuxHealthErrorResourceCount = (long?) content.GetValueForProperty("LoadBalancerMuxHealthErrorResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).LoadBalancerMuxHealthErrorResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).LoadBalancerMuxHealthWarningResourceCount = (long?) content.GetValueForProperty("LoadBalancerMuxHealthWarningResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).LoadBalancerMuxHealthWarningResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).LoadBalancerMuxHealthUnknownCount = (long?) content.GetValueForProperty("LoadBalancerMuxHealthUnknownCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).LoadBalancerMuxHealthUnknownCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualGatewayHealthTotalResourceCount = (long?) content.GetValueForProperty("VirtualGatewayHealthTotalResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualGatewayHealthTotalResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualGatewayHealthHealthyResourceCount = (long?) content.GetValueForProperty("VirtualGatewayHealthHealthyResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualGatewayHealthHealthyResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualGatewayHealthErrorResourceCount = (long?) content.GetValueForProperty("VirtualGatewayHealthErrorResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualGatewayHealthErrorResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualGatewayHealthWarningResourceCount = (long?) content.GetValueForProperty("VirtualGatewayHealthWarningResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualGatewayHealthWarningResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualGatewayHealthUnknownCount = (long?) content.GetValueForProperty("VirtualGatewayHealthUnknownCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualGatewayHealthUnknownCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).PublicIPAddressUsageTotalResourceCount = (long?) content.GetValueForProperty("PublicIPAddressUsageTotalResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).PublicIPAddressUsageTotalResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).PublicIPAddressUsageInUseResourceCount = (long?) content.GetValueForProperty("PublicIPAddressUsageInUseResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).PublicIPAddressUsageInUseResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).BackendIPUsageTotalResourceCount = (long?) content.GetValueForProperty("BackendIPUsageTotalResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).BackendIPUsageTotalResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).BackendIPUsageInUseResourceCount = (long?) content.GetValueForProperty("BackendIPUsageInUseResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).BackendIPUsageInUseResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).MacAddressUsageTotalResourceCount = (long?) content.GetValueForProperty("MacAddressUsageTotalResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).MacAddressUsageTotalResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).MacAddressUsageInUseResourceCount = (long?) content.GetValueForProperty("MacAddressUsageInUseResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).MacAddressUsageInUseResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverview"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal AdminOverview(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewPropertiesTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Id, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Name, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Type, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ResourceTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualNetworkHealth = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealth) content.GetValueForProperty("VirtualNetworkHealth",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualNetworkHealth, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceHealthTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).LoadBalancerMuxHealth = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealth) content.GetValueForProperty("LoadBalancerMuxHealth",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).LoadBalancerMuxHealth, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceHealthTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualGatewayHealth = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealth) content.GetValueForProperty("VirtualGatewayHealth",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualGatewayHealth, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceHealthTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).PublicIPAddressUsage = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage) content.GetValueForProperty("PublicIPAddressUsage",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).PublicIPAddressUsage, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceUsageTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).BackendIPUsage = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage) content.GetValueForProperty("BackendIPUsage",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).BackendIPUsage, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceUsageTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).MacAddressUsage = (Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage) content.GetValueForProperty("MacAddressUsage",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).MacAddressUsage, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceUsageTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).ProvisioningState, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualNetworkHealthTotalResourceCount = (long?) content.GetValueForProperty("VirtualNetworkHealthTotalResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualNetworkHealthTotalResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualNetworkHealthHealthyResourceCount = (long?) content.GetValueForProperty("VirtualNetworkHealthHealthyResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualNetworkHealthHealthyResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualNetworkHealthErrorResourceCount = (long?) content.GetValueForProperty("VirtualNetworkHealthErrorResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualNetworkHealthErrorResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualNetworkHealthWarningResourceCount = (long?) content.GetValueForProperty("VirtualNetworkHealthWarningResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualNetworkHealthWarningResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualNetworkHealthUnknownCount = (long?) content.GetValueForProperty("VirtualNetworkHealthUnknownCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualNetworkHealthUnknownCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).LoadBalancerMuxHealthTotalResourceCount = (long?) content.GetValueForProperty("LoadBalancerMuxHealthTotalResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).LoadBalancerMuxHealthTotalResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).LoadBalancerMuxHealthHealthyResourceCount = (long?) content.GetValueForProperty("LoadBalancerMuxHealthHealthyResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).LoadBalancerMuxHealthHealthyResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).LoadBalancerMuxHealthErrorResourceCount = (long?) content.GetValueForProperty("LoadBalancerMuxHealthErrorResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).LoadBalancerMuxHealthErrorResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).LoadBalancerMuxHealthWarningResourceCount = (long?) content.GetValueForProperty("LoadBalancerMuxHealthWarningResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).LoadBalancerMuxHealthWarningResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).LoadBalancerMuxHealthUnknownCount = (long?) content.GetValueForProperty("LoadBalancerMuxHealthUnknownCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).LoadBalancerMuxHealthUnknownCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualGatewayHealthTotalResourceCount = (long?) content.GetValueForProperty("VirtualGatewayHealthTotalResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualGatewayHealthTotalResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualGatewayHealthHealthyResourceCount = (long?) content.GetValueForProperty("VirtualGatewayHealthHealthyResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualGatewayHealthHealthyResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualGatewayHealthErrorResourceCount = (long?) content.GetValueForProperty("VirtualGatewayHealthErrorResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualGatewayHealthErrorResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualGatewayHealthWarningResourceCount = (long?) content.GetValueForProperty("VirtualGatewayHealthWarningResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualGatewayHealthWarningResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualGatewayHealthUnknownCount = (long?) content.GetValueForProperty("VirtualGatewayHealthUnknownCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).VirtualGatewayHealthUnknownCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).PublicIPAddressUsageTotalResourceCount = (long?) content.GetValueForProperty("PublicIPAddressUsageTotalResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).PublicIPAddressUsageTotalResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).PublicIPAddressUsageInUseResourceCount = (long?) content.GetValueForProperty("PublicIPAddressUsageInUseResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).PublicIPAddressUsageInUseResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).BackendIPUsageTotalResourceCount = (long?) content.GetValueForProperty("BackendIPUsageTotalResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).BackendIPUsageTotalResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).BackendIPUsageInUseResourceCount = (long?) content.GetValueForProperty("BackendIPUsageInUseResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).BackendIPUsageInUseResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).MacAddressUsageTotalResourceCount = (long?) content.GetValueForProperty("MacAddressUsageTotalResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).MacAddressUsageTotalResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).MacAddressUsageInUseResourceCount = (long?) content.GetValueForProperty("MacAddressUsageInUseResourceCount",((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal)this).MacAddressUsageInUseResourceCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverview"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverview" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverview DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new AdminOverview(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverview"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverview" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverview DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new AdminOverview(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="AdminOverview" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverview FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Admin overview resource object.
    [System.ComponentModel.TypeConverter(typeof(AdminOverviewTypeConverter))]
    public partial interface IAdminOverview

    {

    }
}