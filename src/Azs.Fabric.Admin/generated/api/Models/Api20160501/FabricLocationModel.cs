namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>All properties of a fabric location resource.</summary>
    public partial class FabricLocationModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModel,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IFabricLocationModelInternal
    {

        /// <summary>Backing field for <see cref="ExclusiveAdminOperationName" /> property.</summary>
        private string _exclusiveAdminOperationName;

        /// <summary>Name of the running exclusive admin operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string ExclusiveAdminOperationName { get => this._exclusiveAdminOperationName; set => this._exclusiveAdminOperationName = value; }

        /// <summary>Backing field for <see cref="ExclusiveAdminOperationRunning" /> property.</summary>
        private bool? _exclusiveAdminOperationRunning;

        /// <summary>Value for whether an exclusive admin operation is running.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public bool? ExclusiveAdminOperationRunning { get => this._exclusiveAdminOperationRunning; set => this._exclusiveAdminOperationRunning = value; }

        /// <summary>Backing field for <see cref="ExternalDnsipAddress01" /> property.</summary>
        private string _externalDnsipAddress01;

        /// <summary>First external IP address of the DNS server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string ExternalDnsipAddress01 { get => this._externalDnsipAddress01; set => this._externalDnsipAddress01 = value; }

        /// <summary>Backing field for <see cref="ExternalDnsipAddress02" /> property.</summary>
        private string _externalDnsipAddress02;

        /// <summary>Second external IP Address of the DNS server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string ExternalDnsipAddress02 { get => this._externalDnsipAddress02; set => this._externalDnsipAddress02 = value; }

        /// <summary>Backing field for <see cref="PepIPAddress" /> property.</summary>
        private string[] _pepIPAddress;

        /// <summary>The IP addresses of the privileged endpoints.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string[] PepIPAddress { get => this._pepIPAddress; set => this._pepIPAddress = value; }

        /// <summary>Backing field for <see cref="ShutDownActionPlanEndTime" /> property.</summary>
        private global::System.DateTime? _shutDownActionPlanEndTime;

        /// <summary>Last known stamp stop time for the shut down action plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? ShutDownActionPlanEndTime { get => this._shutDownActionPlanEndTime; set => this._shutDownActionPlanEndTime = value; }

        /// <summary>Backing field for <see cref="ShutDownActionPlanStartTime" /> property.</summary>
        private global::System.DateTime? _shutDownActionPlanStartTime;

        /// <summary>Last known stamp start time for the shut down action plan</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? ShutDownActionPlanStartTime { get => this._shutDownActionPlanStartTime; set => this._shutDownActionPlanStartTime = value; }

        /// <summary>Backing field for <see cref="StampInformationId" /> property.</summary>
        private string _stampInformationId;

        /// <summary>The deployment id of the stamp.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string StampInformationId { get => this._stampInformationId; set => this._stampInformationId = value; }

        /// <summary>Backing field for <see cref="StartUpActionPlanEndTime" /> property.</summary>
        private global::System.DateTime? _startUpActionPlanEndTime;

        /// <summary>Last known stamp stop time for the start up action plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? StartUpActionPlanEndTime { get => this._startUpActionPlanEndTime; set => this._startUpActionPlanEndTime = value; }

        /// <summary>Backing field for <see cref="StartUpActionPlanStartTime" /> property.</summary>
        private global::System.DateTime? _startUpActionPlanStartTime;

        /// <summary>Last known stamp start time for the start up action plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public global::System.DateTime? StartUpActionPlanStartTime { get => this._startUpActionPlanStartTime; set => this._startUpActionPlanStartTime = value; }

        /// <summary>Backing field for <see cref="TimeServer" /> property.</summary>
        private string _timeServer;

        /// <summary>The IP address of the time server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string TimeServer { get => this._timeServer; set => this._timeServer = value; }

        /// <summary>Creates an new <see cref="FabricLocationModel" /> instance.</summary>
        public FabricLocationModel()
        {

        }
    }
    /// All properties of a fabric location resource.
    public partial interface IFabricLocationModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Name of the running exclusive admin operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Name of the running exclusive admin operation.",
        SerializedName = @"exclusiveAdminOperationName",
        PossibleTypes = new [] { typeof(string) })]
        string ExclusiveAdminOperationName { get; set; }
        /// <summary>Value for whether an exclusive admin operation is running.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Value for whether an exclusive admin operation is running.",
        SerializedName = @"exclusiveAdminOperationRunning",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ExclusiveAdminOperationRunning { get; set; }
        /// <summary>First external IP address of the DNS server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"First external IP address of the DNS server.",
        SerializedName = @"externalDNSIPAddress01",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalDnsipAddress01 { get; set; }
        /// <summary>Second external IP Address of the DNS server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Second external IP Address of the DNS server.",
        SerializedName = @"externalDNSIPAddress02",
        PossibleTypes = new [] { typeof(string) })]
        string ExternalDnsipAddress02 { get; set; }
        /// <summary>The IP addresses of the privileged endpoints.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The IP addresses of the privileged endpoints.",
        SerializedName = @"pepIpAddresses",
        PossibleTypes = new [] { typeof(string) })]
        string[] PepIPAddress { get; set; }
        /// <summary>Last known stamp stop time for the shut down action plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Last known stamp stop time for the shut down action plan.",
        SerializedName = @"shutDownActionPlanEndTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ShutDownActionPlanEndTime { get; set; }
        /// <summary>Last known stamp start time for the shut down action plan</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Last known stamp start time for the shut down action plan",
        SerializedName = @"shutDownActionPlanStartTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ShutDownActionPlanStartTime { get; set; }
        /// <summary>The deployment id of the stamp.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The deployment id of the stamp.",
        SerializedName = @"stampInformationId",
        PossibleTypes = new [] { typeof(string) })]
        string StampInformationId { get; set; }
        /// <summary>Last known stamp stop time for the start up action plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Last known stamp stop time for the start up action plan.",
        SerializedName = @"startUpActionPlanEndTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartUpActionPlanEndTime { get; set; }
        /// <summary>Last known stamp start time for the start up action plan.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Last known stamp start time for the start up action plan.",
        SerializedName = @"startUpActionPlanStartTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? StartUpActionPlanStartTime { get; set; }
        /// <summary>The IP address of the time server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The IP address of the time server.",
        SerializedName = @"timeServer",
        PossibleTypes = new [] { typeof(string) })]
        string TimeServer { get; set; }

    }
    /// All properties of a fabric location resource.
    internal partial interface IFabricLocationModelInternal

    {
        /// <summary>Name of the running exclusive admin operation.</summary>
        string ExclusiveAdminOperationName { get; set; }
        /// <summary>Value for whether an exclusive admin operation is running.</summary>
        bool? ExclusiveAdminOperationRunning { get; set; }
        /// <summary>First external IP address of the DNS server.</summary>
        string ExternalDnsipAddress01 { get; set; }
        /// <summary>Second external IP Address of the DNS server.</summary>
        string ExternalDnsipAddress02 { get; set; }
        /// <summary>The IP addresses of the privileged endpoints.</summary>
        string[] PepIPAddress { get; set; }
        /// <summary>Last known stamp stop time for the shut down action plan.</summary>
        global::System.DateTime? ShutDownActionPlanEndTime { get; set; }
        /// <summary>Last known stamp start time for the shut down action plan</summary>
        global::System.DateTime? ShutDownActionPlanStartTime { get; set; }
        /// <summary>The deployment id of the stamp.</summary>
        string StampInformationId { get; set; }
        /// <summary>Last known stamp stop time for the start up action plan.</summary>
        global::System.DateTime? StartUpActionPlanEndTime { get; set; }
        /// <summary>Last known stamp start time for the start up action plan.</summary>
        global::System.DateTime? StartUpActionPlanStartTime { get; set; }
        /// <summary>The IP address of the time server.</summary>
        string TimeServer { get; set; }

    }
}