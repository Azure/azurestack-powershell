namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Infrastructure role properties.</summary>
    public partial class InfraRoleModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IInfraRoleModel,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IInfraRoleModelInternal
    {

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>Display name for the infrastructure role.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="Instance" /> property.</summary>
        private string[] _instance;

        /// <summary>List of infrastructure role instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string[] Instance { get => this._instance; set => this._instance = value; }

        /// <summary>Backing field for <see cref="Restartable" /> property.</summary>
        private bool? _restartable;

        /// <summary>Value indicating whether the infrastructure role can be restarted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public bool? Restartable { get => this._restartable; set => this._restartable = value; }

        /// <summary>Creates an new <see cref="InfraRoleModel" /> instance.</summary>
        public InfraRoleModel()
        {

        }
    }
    /// Infrastructure role properties.
    public partial interface IInfraRoleModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Display name for the infrastructure role.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Display name for the infrastructure role.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>List of infrastructure role instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of infrastructure role instances.",
        SerializedName = @"instances",
        PossibleTypes = new [] { typeof(string) })]
        string[] Instance { get; set; }
        /// <summary>Value indicating whether the infrastructure role can be restarted.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Value indicating whether the infrastructure role can be restarted.",
        SerializedName = @"restartable",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Restartable { get; set; }

    }
    /// Infrastructure role properties.
    internal partial interface IInfraRoleModelInternal

    {
        /// <summary>Display name for the infrastructure role.</summary>
        string DisplayName { get; set; }
        /// <summary>List of infrastructure role instances.</summary>
        string[] Instance { get; set; }
        /// <summary>Value indicating whether the infrastructure role can be restarted.</summary>
        bool? Restartable { get; set; }

    }
}