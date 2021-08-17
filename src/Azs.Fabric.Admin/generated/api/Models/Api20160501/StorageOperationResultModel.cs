namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>Storage operation result properties.</summary>
    public partial class StorageOperationResultModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IStorageOperationResultModel,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20160501.IStorageOperationResultModelInternal
    {

        /// <summary>Backing field for <see cref="Instance" /> property.</summary>
        private string[] _instance;

        /// <summary>List of operation result instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string[] Instance { get => this._instance; set => this._instance = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Success or failure of operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; set => this._provisioningState = value; }

        /// <summary>Creates an new <see cref="StorageOperationResultModel" /> instance.</summary>
        public StorageOperationResultModel()
        {

        }
    }
    /// Storage operation result properties.
    public partial interface IStorageOperationResultModel :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>List of operation result instances.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of operation result instances.",
        SerializedName = @"instances",
        PossibleTypes = new [] { typeof(string) })]
        string[] Instance { get; set; }
        /// <summary>Success or failure of operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Success or failure of operation.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get; set; }

    }
    /// Storage operation result properties.
    internal partial interface IStorageOperationResultModelInternal

    {
        /// <summary>List of operation result instances.</summary>
        string[] Instance { get; set; }
        /// <summary>Success or failure of operation.</summary>
        string ProvisioningState { get; set; }

    }
}