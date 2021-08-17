namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Properties of an IpPool.</summary>
    public partial class IPPoolModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolModel,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IIPPoolModelInternal
    {

        /// <summary>Backing field for <see cref="AddressPrefix" /> property.</summary>
        private string _addressPrefix;

        /// <summary>The address prefix.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string AddressPrefix { get => this._addressPrefix; set => this._addressPrefix = value; }

        /// <summary>Backing field for <see cref="EndIPAddress" /> property.</summary>
        private string _endIPAddress;

        /// <summary>The ending IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string EndIPAddress { get => this._endIPAddress; set => this._endIPAddress = value; }

        /// <summary>Backing field for <see cref="NumberOfAllocatedIPAddress" /> property.</summary>
        private long? _numberOfAllocatedIPAddress;

        /// <summary>The number of currently allocated IP addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public long? NumberOfAllocatedIPAddress { get => this._numberOfAllocatedIPAddress; set => this._numberOfAllocatedIPAddress = value; }

        /// <summary>Backing field for <see cref="NumberOfIPAddress" /> property.</summary>
        private long? _numberOfIPAddress;

        /// <summary>The total number of IP addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public long? NumberOfIPAddress { get => this._numberOfIPAddress; set => this._numberOfIPAddress = value; }

        /// <summary>Backing field for <see cref="NumberOfIPAddressesInTransition" /> property.</summary>
        private long? _numberOfIPAddressesInTransition;

        /// <summary>The current number of IP addresses in transition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public long? NumberOfIPAddressesInTransition { get => this._numberOfIPAddressesInTransition; set => this._numberOfIPAddressesInTransition = value; }

        /// <summary>Backing field for <see cref="StartIPAddress" /> property.</summary>
        private string _startIPAddress;

        /// <summary>The starting IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string StartIPAddress { get => this._startIPAddress; set => this._startIPAddress = value; }

        /// <summary>Creates an new <see cref="IPPoolModel" /> instance.</summary>
        public IPPoolModel()
        {

        }
    }
    /// Properties of an IpPool.
    public partial interface IIPPoolModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The address prefix.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The address prefix.",
        SerializedName = @"addressPrefix",
        PossibleTypes = new [] { typeof(string) })]
        string AddressPrefix { get; set; }
        /// <summary>The ending IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ending IP address.",
        SerializedName = @"endIpAddress",
        PossibleTypes = new [] { typeof(string) })]
        string EndIPAddress { get; set; }
        /// <summary>The number of currently allocated IP addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The number of currently allocated IP addresses.",
        SerializedName = @"numberOfAllocatedIpAddresses",
        PossibleTypes = new [] { typeof(long) })]
        long? NumberOfAllocatedIPAddress { get; set; }
        /// <summary>The total number of IP addresses.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The total number of IP addresses.",
        SerializedName = @"numberOfIpAddresses",
        PossibleTypes = new [] { typeof(long) })]
        long? NumberOfIPAddress { get; set; }
        /// <summary>The current number of IP addresses in transition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The current number of IP addresses in transition.",
        SerializedName = @"numberOfIpAddressesInTransition",
        PossibleTypes = new [] { typeof(long) })]
        long? NumberOfIPAddressesInTransition { get; set; }
        /// <summary>The starting IP address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The starting IP address.",
        SerializedName = @"startIpAddress",
        PossibleTypes = new [] { typeof(string) })]
        string StartIPAddress { get; set; }

    }
    /// Properties of an IpPool.
    internal partial interface IIPPoolModelInternal

    {
        /// <summary>The address prefix.</summary>
        string AddressPrefix { get; set; }
        /// <summary>The ending IP address.</summary>
        string EndIPAddress { get; set; }
        /// <summary>The number of currently allocated IP addresses.</summary>
        long? NumberOfAllocatedIPAddress { get; set; }
        /// <summary>The total number of IP addresses.</summary>
        long? NumberOfIPAddress { get; set; }
        /// <summary>The current number of IP addresses in transition.</summary>
        long? NumberOfIPAddressesInTransition { get; set; }
        /// <summary>The starting IP address.</summary>
        string StartIPAddress { get; set; }

    }
}