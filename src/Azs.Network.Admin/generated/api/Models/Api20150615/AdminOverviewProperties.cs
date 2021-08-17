namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Extensions;

    /// <summary>Admin overview properties.</summary>
    public partial class AdminOverviewProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewProperties,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal
    {

        /// <summary>Backing field for <see cref="BackendIPUsage" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage _backendIPUsage;

        /// <summary>Total Backend IP usage as reported by the NC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage BackendIPUsage { get => (this._backendIPUsage = this._backendIPUsage ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceUsage()); set => this._backendIPUsage = value; }

        /// <summary>Number of resources in use.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? BackendIPUsageInUseResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)BackendIPUsage).InUseResourceCount; }

        /// <summary>Total number of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? BackendIPUsageTotalResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)BackendIPUsage).TotalResourceCount; }

        /// <summary>Backing field for <see cref="LoadBalancerMuxHealth" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealth _loadBalancerMuxHealth;

        /// <summary>Health for all LB MUXes as reported by the NC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealth LoadBalancerMuxHealth { get => (this._loadBalancerMuxHealth = this._loadBalancerMuxHealth ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceHealth()); set => this._loadBalancerMuxHealth = value; }

        /// <summary>Number of resources in the error state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? LoadBalancerMuxHealthErrorResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)LoadBalancerMuxHealth).ErrorResourceCount; }

        /// <summary>Number of resources in the success state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? LoadBalancerMuxHealthHealthyResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)LoadBalancerMuxHealth).HealthyResourceCount; }

        /// <summary>Total number of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? LoadBalancerMuxHealthTotalResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)LoadBalancerMuxHealth).TotalResourceCount; }

        /// <summary>Number of resources in an unknown state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? LoadBalancerMuxHealthUnknownCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)LoadBalancerMuxHealth).HealthUnknownCount; }

        /// <summary>Number of resources in the warning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? LoadBalancerMuxHealthWarningResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)LoadBalancerMuxHealth).WarningResourceCount; }

        /// <summary>Backing field for <see cref="MacAddressUsage" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage _macAddressUsage;

        /// <summary>Total MAC address usage as reported by the NC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage MacAddressUsage { get => (this._macAddressUsage = this._macAddressUsage ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceUsage()); set => this._macAddressUsage = value; }

        /// <summary>Number of resources in use.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? MacAddressUsageInUseResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)MacAddressUsage).InUseResourceCount; }

        /// <summary>Total number of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? MacAddressUsageTotalResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)MacAddressUsage).TotalResourceCount; }

        /// <summary>Internal Acessors for BackendIPUsage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.BackendIPUsage { get => (this._backendIPUsage = this._backendIPUsage ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceUsage()); set { {_backendIPUsage = value;} } }

        /// <summary>Internal Acessors for BackendIPUsageInUseResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.BackendIPUsageInUseResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)BackendIPUsage).InUseResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)BackendIPUsage).InUseResourceCount = value; }

        /// <summary>Internal Acessors for BackendIPUsageTotalResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.BackendIPUsageTotalResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)BackendIPUsage).TotalResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)BackendIPUsage).TotalResourceCount = value; }

        /// <summary>Internal Acessors for LoadBalancerMuxHealth</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealth Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.LoadBalancerMuxHealth { get => (this._loadBalancerMuxHealth = this._loadBalancerMuxHealth ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceHealth()); set { {_loadBalancerMuxHealth = value;} } }

        /// <summary>Internal Acessors for LoadBalancerMuxHealthErrorResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.LoadBalancerMuxHealthErrorResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)LoadBalancerMuxHealth).ErrorResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)LoadBalancerMuxHealth).ErrorResourceCount = value; }

        /// <summary>Internal Acessors for LoadBalancerMuxHealthHealthyResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.LoadBalancerMuxHealthHealthyResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)LoadBalancerMuxHealth).HealthyResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)LoadBalancerMuxHealth).HealthyResourceCount = value; }

        /// <summary>Internal Acessors for LoadBalancerMuxHealthTotalResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.LoadBalancerMuxHealthTotalResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)LoadBalancerMuxHealth).TotalResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)LoadBalancerMuxHealth).TotalResourceCount = value; }

        /// <summary>Internal Acessors for LoadBalancerMuxHealthUnknownCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.LoadBalancerMuxHealthUnknownCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)LoadBalancerMuxHealth).HealthUnknownCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)LoadBalancerMuxHealth).HealthUnknownCount = value; }

        /// <summary>Internal Acessors for LoadBalancerMuxHealthWarningResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.LoadBalancerMuxHealthWarningResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)LoadBalancerMuxHealth).WarningResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)LoadBalancerMuxHealth).WarningResourceCount = value; }

        /// <summary>Internal Acessors for MacAddressUsage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.MacAddressUsage { get => (this._macAddressUsage = this._macAddressUsage ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceUsage()); set { {_macAddressUsage = value;} } }

        /// <summary>Internal Acessors for MacAddressUsageInUseResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.MacAddressUsageInUseResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)MacAddressUsage).InUseResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)MacAddressUsage).InUseResourceCount = value; }

        /// <summary>Internal Acessors for MacAddressUsageTotalResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.MacAddressUsageTotalResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)MacAddressUsage).TotalResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)MacAddressUsage).TotalResourceCount = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for PublicIPAddressUsage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.PublicIPAddressUsage { get => (this._publicIPAddressUsage = this._publicIPAddressUsage ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceUsage()); set { {_publicIPAddressUsage = value;} } }

        /// <summary>Internal Acessors for PublicIPAddressUsageInUseResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.PublicIPAddressUsageInUseResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)PublicIPAddressUsage).InUseResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)PublicIPAddressUsage).InUseResourceCount = value; }

        /// <summary>Internal Acessors for PublicIPAddressUsageTotalResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.PublicIPAddressUsageTotalResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)PublicIPAddressUsage).TotalResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)PublicIPAddressUsage).TotalResourceCount = value; }

        /// <summary>Internal Acessors for VirtualGatewayHealth</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealth Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.VirtualGatewayHealth { get => (this._virtualGatewayHealth = this._virtualGatewayHealth ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceHealth()); set { {_virtualGatewayHealth = value;} } }

        /// <summary>Internal Acessors for VirtualGatewayHealthErrorResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.VirtualGatewayHealthErrorResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualGatewayHealth).ErrorResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualGatewayHealth).ErrorResourceCount = value; }

        /// <summary>Internal Acessors for VirtualGatewayHealthHealthyResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.VirtualGatewayHealthHealthyResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualGatewayHealth).HealthyResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualGatewayHealth).HealthyResourceCount = value; }

        /// <summary>Internal Acessors for VirtualGatewayHealthTotalResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.VirtualGatewayHealthTotalResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualGatewayHealth).TotalResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualGatewayHealth).TotalResourceCount = value; }

        /// <summary>Internal Acessors for VirtualGatewayHealthUnknownCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.VirtualGatewayHealthUnknownCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualGatewayHealth).HealthUnknownCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualGatewayHealth).HealthUnknownCount = value; }

        /// <summary>Internal Acessors for VirtualGatewayHealthWarningResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.VirtualGatewayHealthWarningResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualGatewayHealth).WarningResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualGatewayHealth).WarningResourceCount = value; }

        /// <summary>Internal Acessors for VirtualNetworkHealth</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealth Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.VirtualNetworkHealth { get => (this._virtualNetworkHealth = this._virtualNetworkHealth ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceHealth()); set { {_virtualNetworkHealth = value;} } }

        /// <summary>Internal Acessors for VirtualNetworkHealthErrorResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.VirtualNetworkHealthErrorResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualNetworkHealth).ErrorResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualNetworkHealth).ErrorResourceCount = value; }

        /// <summary>Internal Acessors for VirtualNetworkHealthHealthyResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.VirtualNetworkHealthHealthyResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualNetworkHealth).HealthyResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualNetworkHealth).HealthyResourceCount = value; }

        /// <summary>Internal Acessors for VirtualNetworkHealthTotalResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.VirtualNetworkHealthTotalResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualNetworkHealth).TotalResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualNetworkHealth).TotalResourceCount = value; }

        /// <summary>Internal Acessors for VirtualNetworkHealthUnknownCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.VirtualNetworkHealthUnknownCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualNetworkHealth).HealthUnknownCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualNetworkHealth).HealthUnknownCount = value; }

        /// <summary>Internal Acessors for VirtualNetworkHealthWarningResourceCount</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewPropertiesInternal.VirtualNetworkHealthWarningResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualNetworkHealth).WarningResourceCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualNetworkHealth).WarningResourceCount = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>The provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="PublicIPAddressUsage" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage _publicIPAddressUsage;

        /// <summary>Total Public IP usage as reported by the NC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsage PublicIPAddressUsage { get => (this._publicIPAddressUsage = this._publicIPAddressUsage ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceUsage()); set => this._publicIPAddressUsage = value; }

        /// <summary>Number of resources in use.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? PublicIPAddressUsageInUseResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)PublicIPAddressUsage).InUseResourceCount; }

        /// <summary>Total number of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? PublicIPAddressUsageTotalResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceUsageInternal)PublicIPAddressUsage).TotalResourceCount; }

        /// <summary>Backing field for <see cref="VirtualGatewayHealth" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealth _virtualGatewayHealth;

        /// <summary>Health for all gateways as reported by the NC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealth VirtualGatewayHealth { get => (this._virtualGatewayHealth = this._virtualGatewayHealth ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceHealth()); set => this._virtualGatewayHealth = value; }

        /// <summary>Number of resources in the error state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? VirtualGatewayHealthErrorResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualGatewayHealth).ErrorResourceCount; }

        /// <summary>Number of resources in the success state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? VirtualGatewayHealthHealthyResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualGatewayHealth).HealthyResourceCount; }

        /// <summary>Total number of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? VirtualGatewayHealthTotalResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualGatewayHealth).TotalResourceCount; }

        /// <summary>Number of resources in an unknown state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? VirtualGatewayHealthUnknownCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualGatewayHealth).HealthUnknownCount; }

        /// <summary>Number of resources in the warning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? VirtualGatewayHealthWarningResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualGatewayHealth).WarningResourceCount; }

        /// <summary>Backing field for <see cref="VirtualNetworkHealth" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealth _virtualNetworkHealth;

        /// <summary>Health for all virtual networks as reported by the NC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealth VirtualNetworkHealth { get => (this._virtualNetworkHealth = this._virtualNetworkHealth ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.AdminOverviewResourceHealth()); set => this._virtualNetworkHealth = value; }

        /// <summary>Number of resources in the error state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? VirtualNetworkHealthErrorResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualNetworkHealth).ErrorResourceCount; }

        /// <summary>Number of resources in the success state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? VirtualNetworkHealthHealthyResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualNetworkHealth).HealthyResourceCount; }

        /// <summary>Total number of resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? VirtualNetworkHealthTotalResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualNetworkHealth).TotalResourceCount; }

        /// <summary>Number of resources in an unknown state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? VirtualNetworkHealthUnknownCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualNetworkHealth).HealthUnknownCount; }

        /// <summary>Number of resources in the warning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Inlined)]
        public long? VirtualNetworkHealthWarningResourceCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.IAdminOverviewResourceHealthInternal)VirtualNetworkHealth).WarningResourceCount; }

        /// <summary>Creates an new <see cref="AdminOverviewProperties" /> instance.</summary>
        public AdminOverviewProperties()
        {

        }
    }
    /// Admin overview properties.
    public partial interface IAdminOverviewProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.IJsonSerializable
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
    /// Admin overview properties.
    internal partial interface IAdminOverviewPropertiesInternal

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