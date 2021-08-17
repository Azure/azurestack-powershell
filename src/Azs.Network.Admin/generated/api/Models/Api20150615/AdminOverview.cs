namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Extensions;

    /// <summary>Admin overview resource object.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.DoNotFormat]
    public partial class AdminOverview :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverview,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResource __resource = new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.Resource();

        /// <summary>Number of resources in use.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? BackendIPUsageInUseResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).BackendIPUsageInUseResourceCount; }

        /// <summary>Total number of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? BackendIPUsageTotalResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).BackendIPUsageTotalResourceCount; }

        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Id; }

        /// <summary>Number of resources in the error state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? LoadBalancerMuxHealthErrorResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).LoadBalancerMuxHealthErrorResourceCount; }

        /// <summary>Number of resources in the success state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? LoadBalancerMuxHealthHealthyResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).LoadBalancerMuxHealthHealthyResourceCount; }

        /// <summary>Total number of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? LoadBalancerMuxHealthTotalResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).LoadBalancerMuxHealthTotalResourceCount; }

        /// <summary>Number of resources in an unknown state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? LoadBalancerMuxHealthUnknownCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).LoadBalancerMuxHealthUnknownCount; }

        /// <summary>Number of resources in the warning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? LoadBalancerMuxHealthWarningResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).LoadBalancerMuxHealthWarningResourceCount; }

        /// <summary>Region location of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Location; }

        /// <summary>Number of resources in use.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? MacAddressUsageInUseResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).MacAddressUsageInUseResourceCount; }

        /// <summary>Total number of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? MacAddressUsageTotalResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).MacAddressUsageTotalResourceCount; }

        /// <summary>Internal Acessors for BackendIPUsage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.BackendIPUsage { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).BackendIPUsage; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).BackendIPUsage = value; }

        /// <summary>Internal Acessors for BackendIPUsageInUseResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.BackendIPUsageInUseResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).BackendIPUsageInUseResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).BackendIPUsageInUseResourceCount = value; }

        /// <summary>Internal Acessors for BackendIPUsageTotalResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.BackendIPUsageTotalResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).BackendIPUsageTotalResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).BackendIPUsageTotalResourceCount = value; }

        /// <summary>Internal Acessors for LoadBalancerMuxHealth</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealth Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.LoadBalancerMuxHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).LoadBalancerMuxHealth; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).LoadBalancerMuxHealth = value; }

        /// <summary>Internal Acessors for LoadBalancerMuxHealthErrorResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.LoadBalancerMuxHealthErrorResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).LoadBalancerMuxHealthErrorResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).LoadBalancerMuxHealthErrorResourceCount = value; }

        /// <summary>Internal Acessors for LoadBalancerMuxHealthHealthyResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.LoadBalancerMuxHealthHealthyResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).LoadBalancerMuxHealthHealthyResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).LoadBalancerMuxHealthHealthyResourceCount = value; }

        /// <summary>Internal Acessors for LoadBalancerMuxHealthTotalResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.LoadBalancerMuxHealthTotalResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).LoadBalancerMuxHealthTotalResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).LoadBalancerMuxHealthTotalResourceCount = value; }

        /// <summary>Internal Acessors for LoadBalancerMuxHealthUnknownCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.LoadBalancerMuxHealthUnknownCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).LoadBalancerMuxHealthUnknownCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).LoadBalancerMuxHealthUnknownCount = value; }

        /// <summary>Internal Acessors for LoadBalancerMuxHealthWarningResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.LoadBalancerMuxHealthWarningResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).LoadBalancerMuxHealthWarningResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).LoadBalancerMuxHealthWarningResourceCount = value; }

        /// <summary>Internal Acessors for MacAddressUsage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.MacAddressUsage { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).MacAddressUsage; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).MacAddressUsage = value; }

        /// <summary>Internal Acessors for MacAddressUsageInUseResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.MacAddressUsageInUseResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).MacAddressUsageInUseResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).MacAddressUsageInUseResourceCount = value; }

        /// <summary>Internal Acessors for MacAddressUsageTotalResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.MacAddressUsageTotalResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).MacAddressUsageTotalResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).MacAddressUsageTotalResourceCount = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewProperties Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for PublicIPAddressUsage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.PublicIPAddressUsage { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).PublicIPAddressUsage; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).PublicIPAddressUsage = value; }

        /// <summary>Internal Acessors for PublicIPAddressUsageInUseResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.PublicIPAddressUsageInUseResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).PublicIPAddressUsageInUseResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).PublicIPAddressUsageInUseResourceCount = value; }

        /// <summary>Internal Acessors for PublicIPAddressUsageTotalResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.PublicIPAddressUsageTotalResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).PublicIPAddressUsageTotalResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).PublicIPAddressUsageTotalResourceCount = value; }

        /// <summary>Internal Acessors for VirtualGatewayHealth</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealth Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.VirtualGatewayHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualGatewayHealth; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualGatewayHealth = value; }

        /// <summary>Internal Acessors for VirtualGatewayHealthErrorResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.VirtualGatewayHealthErrorResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualGatewayHealthErrorResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualGatewayHealthErrorResourceCount = value; }

        /// <summary>Internal Acessors for VirtualGatewayHealthHealthyResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.VirtualGatewayHealthHealthyResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualGatewayHealthHealthyResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualGatewayHealthHealthyResourceCount = value; }

        /// <summary>Internal Acessors for VirtualGatewayHealthTotalResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.VirtualGatewayHealthTotalResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualGatewayHealthTotalResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualGatewayHealthTotalResourceCount = value; }

        /// <summary>Internal Acessors for VirtualGatewayHealthUnknownCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.VirtualGatewayHealthUnknownCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualGatewayHealthUnknownCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualGatewayHealthUnknownCount = value; }

        /// <summary>Internal Acessors for VirtualGatewayHealthWarningResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.VirtualGatewayHealthWarningResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualGatewayHealthWarningResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualGatewayHealthWarningResourceCount = value; }

        /// <summary>Internal Acessors for VirtualNetworkHealth</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealth Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.VirtualNetworkHealth { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualNetworkHealth; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualNetworkHealth = value; }

        /// <summary>Internal Acessors for VirtualNetworkHealthErrorResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.VirtualNetworkHealthErrorResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualNetworkHealthErrorResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualNetworkHealthErrorResourceCount = value; }

        /// <summary>Internal Acessors for VirtualNetworkHealthHealthyResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.VirtualNetworkHealthHealthyResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualNetworkHealthHealthyResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualNetworkHealthHealthyResourceCount = value; }

        /// <summary>Internal Acessors for VirtualNetworkHealthTotalResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.VirtualNetworkHealthTotalResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualNetworkHealthTotalResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualNetworkHealthTotalResourceCount = value; }

        /// <summary>Internal Acessors for VirtualNetworkHealthUnknownCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.VirtualNetworkHealthUnknownCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualNetworkHealthUnknownCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualNetworkHealthUnknownCount = value; }

        /// <summary>Internal Acessors for VirtualNetworkHealthWarningResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewInternal.VirtualNetworkHealthWarningResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualNetworkHealthWarningResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualNetworkHealthWarningResourceCount = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Id = value; }

        /// <summary>Internal Acessors for Location</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal.Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Location = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Type = value; }

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewProperties _property;

        /// <summary>Admin overview properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewProperties()); set => this._property = value; }

        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Number of resources in use.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? PublicIPAddressUsageInUseResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).PublicIPAddressUsageInUseResourceCount; }

        /// <summary>Total number of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? PublicIPAddressUsageTotalResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).PublicIPAddressUsageTotalResourceCount; }

        /// <summary>List of key value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Tag = value ?? null /* model class */; }

        /// <summary>Type of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal)__resource).Type; }

        /// <summary>Number of resources in the error state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? VirtualGatewayHealthErrorResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualGatewayHealthErrorResourceCount; }

        /// <summary>Number of resources in the success state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? VirtualGatewayHealthHealthyResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualGatewayHealthHealthyResourceCount; }

        /// <summary>Total number of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? VirtualGatewayHealthTotalResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualGatewayHealthTotalResourceCount; }

        /// <summary>Number of resources in an unknown state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? VirtualGatewayHealthUnknownCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualGatewayHealthUnknownCount; }

        /// <summary>Number of resources in the warning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? VirtualGatewayHealthWarningResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualGatewayHealthWarningResourceCount; }

        /// <summary>Number of resources in the error state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? VirtualNetworkHealthErrorResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualNetworkHealthErrorResourceCount; }

        /// <summary>Number of resources in the success state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? VirtualNetworkHealthHealthyResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualNetworkHealthHealthyResourceCount; }

        /// <summary>Total number of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? VirtualNetworkHealthTotalResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualNetworkHealthTotalResourceCount; }

        /// <summary>Number of resources in an unknown state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? VirtualNetworkHealthUnknownCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualNetworkHealthUnknownCount; }

        /// <summary>Number of resources in the warning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? VirtualNetworkHealthWarningResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal)Property).VirtualNetworkHealthWarningResourceCount; }

        /// <summary>Creates an new <see cref="AdminOverview" /> instance.</summary>
        public AdminOverview()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A < see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__resource), __resource);
            await eventListener.AssertObjectIsValid(nameof(__resource), __resource);
        }
    }
    /// Admin overview resource object.
    public partial interface IAdminOverview :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResource
    {
        /// <summary>Number of resources in use.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of resources in use.",
        SerializedName = @"inUseResourceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? BackendIPUsageInUseResourceCount { get;  }
        /// <summary>Total number of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Total number of resources.",
        SerializedName = @"totalResourceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? BackendIPUsageTotalResourceCount { get;  }
        /// <summary>Number of resources in the error state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of resources in the error state.",
        SerializedName = @"errorResourceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? LoadBalancerMuxHealthErrorResourceCount { get;  }
        /// <summary>Number of resources in the success state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of resources in the success state.",
        SerializedName = @"healthyResourceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? LoadBalancerMuxHealthHealthyResourceCount { get;  }
        /// <summary>Total number of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Total number of resources.",
        SerializedName = @"totalResourceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? LoadBalancerMuxHealthTotalResourceCount { get;  }
        /// <summary>Number of resources in an unknown state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of resources in an unknown state.",
        SerializedName = @"healthUnknownCount",
        PossibleTypes = new [] { typeof(long) })]
        long? LoadBalancerMuxHealthUnknownCount { get;  }
        /// <summary>Number of resources in the warning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of resources in the warning state.",
        SerializedName = @"warningResourceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? LoadBalancerMuxHealthWarningResourceCount { get;  }
        /// <summary>Number of resources in use.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of resources in use.",
        SerializedName = @"inUseResourceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? MacAddressUsageInUseResourceCount { get;  }
        /// <summary>Total number of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Total number of resources.",
        SerializedName = @"totalResourceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? MacAddressUsageTotalResourceCount { get;  }
        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The provisioning state.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }
        /// <summary>Number of resources in use.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of resources in use.",
        SerializedName = @"inUseResourceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? PublicIPAddressUsageInUseResourceCount { get;  }
        /// <summary>Total number of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Total number of resources.",
        SerializedName = @"totalResourceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? PublicIPAddressUsageTotalResourceCount { get;  }
        /// <summary>Number of resources in the error state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of resources in the error state.",
        SerializedName = @"errorResourceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? VirtualGatewayHealthErrorResourceCount { get;  }
        /// <summary>Number of resources in the success state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of resources in the success state.",
        SerializedName = @"healthyResourceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? VirtualGatewayHealthHealthyResourceCount { get;  }
        /// <summary>Total number of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Total number of resources.",
        SerializedName = @"totalResourceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? VirtualGatewayHealthTotalResourceCount { get;  }
        /// <summary>Number of resources in an unknown state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of resources in an unknown state.",
        SerializedName = @"healthUnknownCount",
        PossibleTypes = new [] { typeof(long) })]
        long? VirtualGatewayHealthUnknownCount { get;  }
        /// <summary>Number of resources in the warning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of resources in the warning state.",
        SerializedName = @"warningResourceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? VirtualGatewayHealthWarningResourceCount { get;  }
        /// <summary>Number of resources in the error state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of resources in the error state.",
        SerializedName = @"errorResourceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? VirtualNetworkHealthErrorResourceCount { get;  }
        /// <summary>Number of resources in the success state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of resources in the success state.",
        SerializedName = @"healthyResourceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? VirtualNetworkHealthHealthyResourceCount { get;  }
        /// <summary>Total number of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Total number of resources.",
        SerializedName = @"totalResourceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? VirtualNetworkHealthTotalResourceCount { get;  }
        /// <summary>Number of resources in an unknown state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of resources in an unknown state.",
        SerializedName = @"healthUnknownCount",
        PossibleTypes = new [] { typeof(long) })]
        long? VirtualNetworkHealthUnknownCount { get;  }
        /// <summary>Number of resources in the warning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Number of resources in the warning state.",
        SerializedName = @"warningResourceCount",
        PossibleTypes = new [] { typeof(long) })]
        long? VirtualNetworkHealthWarningResourceCount { get;  }

    }
    /// Admin overview resource object.
    internal partial interface IAdminOverviewInternal :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IResourceInternal
    {
        /// <summary>Total Backend IP usage as reported by the NC.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage BackendIPUsage { get; set; }
        /// <summary>Number of resources in use.</summary>
        long? BackendIPUsageInUseResourceCount { get; set; }
        /// <summary>Total number of resources.</summary>
        long? BackendIPUsageTotalResourceCount { get; set; }
        /// <summary>Health for all LB MUXes as reported by the NC.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealth LoadBalancerMuxHealth { get; set; }
        /// <summary>Number of resources in the error state.</summary>
        long? LoadBalancerMuxHealthErrorResourceCount { get; set; }
        /// <summary>Number of resources in the success state.</summary>
        long? LoadBalancerMuxHealthHealthyResourceCount { get; set; }
        /// <summary>Total number of resources.</summary>
        long? LoadBalancerMuxHealthTotalResourceCount { get; set; }
        /// <summary>Number of resources in an unknown state.</summary>
        long? LoadBalancerMuxHealthUnknownCount { get; set; }
        /// <summary>Number of resources in the warning state.</summary>
        long? LoadBalancerMuxHealthWarningResourceCount { get; set; }
        /// <summary>Total MAC address usage as reported by the NC.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage MacAddressUsage { get; set; }
        /// <summary>Number of resources in use.</summary>
        long? MacAddressUsageInUseResourceCount { get; set; }
        /// <summary>Total number of resources.</summary>
        long? MacAddressUsageTotalResourceCount { get; set; }
        /// <summary>Admin overview properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewProperties Property { get; set; }
        /// <summary>The provisioning state.</summary>
        string ProvisioningState { get; set; }
        /// <summary>Total Public IP usage as reported by the NC.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage PublicIPAddressUsage { get; set; }
        /// <summary>Number of resources in use.</summary>
        long? PublicIPAddressUsageInUseResourceCount { get; set; }
        /// <summary>Total number of resources.</summary>
        long? PublicIPAddressUsageTotalResourceCount { get; set; }
        /// <summary>Health for all gateways as reported by the NC.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealth VirtualGatewayHealth { get; set; }
        /// <summary>Number of resources in the error state.</summary>
        long? VirtualGatewayHealthErrorResourceCount { get; set; }
        /// <summary>Number of resources in the success state.</summary>
        long? VirtualGatewayHealthHealthyResourceCount { get; set; }
        /// <summary>Total number of resources.</summary>
        long? VirtualGatewayHealthTotalResourceCount { get; set; }
        /// <summary>Number of resources in an unknown state.</summary>
        long? VirtualGatewayHealthUnknownCount { get; set; }
        /// <summary>Number of resources in the warning state.</summary>
        long? VirtualGatewayHealthWarningResourceCount { get; set; }
        /// <summary>Health for all virtual networks as reported by the NC.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealth VirtualNetworkHealth { get; set; }
        /// <summary>Number of resources in the error state.</summary>
        long? VirtualNetworkHealthErrorResourceCount { get; set; }
        /// <summary>Number of resources in the success state.</summary>
        long? VirtualNetworkHealthHealthyResourceCount { get; set; }
        /// <summary>Total number of resources.</summary>
        long? VirtualNetworkHealthTotalResourceCount { get; set; }
        /// <summary>Number of resources in an unknown state.</summary>
        long? VirtualNetworkHealthUnknownCount { get; set; }
        /// <summary>Number of resources in the warning state.</summary>
        long? VirtualNetworkHealthWarningResourceCount { get; set; }

    }
}