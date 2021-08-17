namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Properties of a SLB MUX.</summary>
    public partial class SlbMuxInstanceModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ISlbMuxInstanceModel,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.ISlbMuxInstanceModelInternal
    {

        /// <summary>Backing field for <see cref="BgpPeer" /> property.</summary>
        private string[] _bgpPeer;

        /// <summary>List of BGP peers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string[] BgpPeer { get => this._bgpPeer; set => this._bgpPeer = value; }

        /// <summary>Backing field for <see cref="ConfigurationState" /> property.</summary>
        private string _configurationState;

        /// <summary>Configuration state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string ConfigurationState { get => this._configurationState; set => this._configurationState = value; }

        /// <summary>Backing field for <see cref="VirtualServer" /> property.</summary>
        private string _virtualServer;

        /// <summary>Virtual server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string VirtualServer { get => this._virtualServer; set => this._virtualServer = value; }

        /// <summary>Creates an new <see cref="SlbMuxInstanceModel" /> instance.</summary>
        public SlbMuxInstanceModel()
        {

        }
    }
    /// Properties of a SLB MUX.
    public partial interface ISlbMuxInstanceModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>List of BGP peers.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of BGP peers.",
        SerializedName = @"bgpPeers",
        PossibleTypes = new [] { typeof(string) })]
        string[] BgpPeer { get; set; }
        /// <summary>Configuration state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Configuration state.",
        SerializedName = @"configurationState",
        PossibleTypes = new [] { typeof(string) })]
        string ConfigurationState { get; set; }
        /// <summary>Virtual server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Virtual server.",
        SerializedName = @"virtualServer",
        PossibleTypes = new [] { typeof(string) })]
        string VirtualServer { get; set; }

    }
    /// Properties of a SLB MUX.
    internal partial interface ISlbMuxInstanceModelInternal

    {
        /// <summary>List of BGP peers.</summary>
        string[] BgpPeer { get; set; }
        /// <summary>Configuration state.</summary>
        string ConfigurationState { get; set; }
        /// <summary>Virtual server.</summary>
        string VirtualServer { get; set; }

    }
}