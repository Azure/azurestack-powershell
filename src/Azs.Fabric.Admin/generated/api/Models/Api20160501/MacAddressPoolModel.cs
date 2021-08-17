namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Properties of a MAC address pool.</summary>
    public partial class MacAddressPoolModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IMacAddressPoolModel,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IMacAddressPoolModelInternal
    {

        /// <summary>Backing field for <see cref="EndMacAddress" /> property.</summary>
        private string _endMacAddress;

        /// <summary>Ending MAC address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string EndMacAddress { get => this._endMacAddress; set => this._endMacAddress = value; }

        /// <summary>Backing field for <see cref="Metadata" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IMacAddressPoolModelMetadata _metadata;

        /// <summary>Metadata related to the MAC pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IMacAddressPoolModelMetadata Metadata { get => (this._metadata = this._metadata ?? new Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.MacAddressPoolModelMetadata()); set => this._metadata = value; }

        /// <summary>Backing field for <see cref="NumberOfAllocatedMacAddress" /> property.</summary>
        private long? _numberOfAllocatedMacAddress;

        /// <summary>Number of MAC addresses allocated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public long? NumberOfAllocatedMacAddress { get => this._numberOfAllocatedMacAddress; set => this._numberOfAllocatedMacAddress = value; }

        /// <summary>Backing field for <see cref="NumberOfAvailableMacAddress" /> property.</summary>
        private long? _numberOfAvailableMacAddress;

        /// <summary>Number of MAC addresses available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public long? NumberOfAvailableMacAddress { get => this._numberOfAvailableMacAddress; set => this._numberOfAvailableMacAddress = value; }

        /// <summary>Backing field for <see cref="StartMacAddress" /> property.</summary>
        private string _startMacAddress;

        /// <summary>Starting MAC address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string StartMacAddress { get => this._startMacAddress; set => this._startMacAddress = value; }

        /// <summary>Creates an new <see cref="MacAddressPoolModel" /> instance.</summary>
        public MacAddressPoolModel()
        {

        }
    }
    /// Properties of a MAC address pool.
    public partial interface IMacAddressPoolModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Ending MAC address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Ending MAC address.",
        SerializedName = @"endMacAddress",
        PossibleTypes = new [] { typeof(string) })]
        string EndMacAddress { get; set; }
        /// <summary>Metadata related to the MAC pool.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Metadata related to the MAC pool.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IMacAddressPoolModelMetadata) })]
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IMacAddressPoolModelMetadata Metadata { get; set; }
        /// <summary>Number of MAC addresses allocated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of MAC addresses allocated.",
        SerializedName = @"numberOfAllocatedMacAddresses",
        PossibleTypes = new [] { typeof(long) })]
        long? NumberOfAllocatedMacAddress { get; set; }
        /// <summary>Number of MAC addresses available.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Number of MAC addresses available.",
        SerializedName = @"numberOfAvailableMacAddresses",
        PossibleTypes = new [] { typeof(long) })]
        long? NumberOfAvailableMacAddress { get; set; }
        /// <summary>Starting MAC address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Starting MAC address.",
        SerializedName = @"startMacAddress",
        PossibleTypes = new [] { typeof(string) })]
        string StartMacAddress { get; set; }

    }
    /// Properties of a MAC address pool.
    internal partial interface IMacAddressPoolModelInternal

    {
        /// <summary>Ending MAC address.</summary>
        string EndMacAddress { get; set; }
        /// <summary>Metadata related to the MAC pool.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IMacAddressPoolModelMetadata Metadata { get; set; }
        /// <summary>Number of MAC addresses allocated.</summary>
        long? NumberOfAllocatedMacAddress { get; set; }
        /// <summary>Number of MAC addresses available.</summary>
        long? NumberOfAvailableMacAddress { get; set; }
        /// <summary>Starting MAC address.</summary>
        string StartMacAddress { get; set; }

    }
}