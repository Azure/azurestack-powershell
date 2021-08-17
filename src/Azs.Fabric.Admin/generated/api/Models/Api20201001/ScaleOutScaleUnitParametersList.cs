namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Extensions;

    /// <summary>A list of input data that allows for adding a set of scale unit nodes.</summary>
    public partial class ScaleOutScaleUnitParametersList :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleOutScaleUnitParametersList,
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleOutScaleUnitParametersListInternal
    {

        /// <summary>Backing field for <see cref="AwaitStorageConvergence" /> property.</summary>
        private bool? _awaitStorageConvergence;

        /// <summary>
        /// Flag indicates if the operation should wait for storage to converge before returning.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public bool? AwaitStorageConvergence { get => this._awaitStorageConvergence; set => this._awaitStorageConvergence = value; }

        /// <summary>Backing field for <see cref="NodeList" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleOutScaleUnitParameters[] _nodeList;

        /// <summary>List of nodes in the scale unit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleOutScaleUnitParameters[] NodeList { get => this._nodeList; set => this._nodeList = value; }

        /// <summary>Creates an new <see cref="ScaleOutScaleUnitParametersList" /> instance.</summary>
        public ScaleOutScaleUnitParametersList()
        {

        }
    }
    /// A list of input data that allows for adding a set of scale unit nodes.
    public partial interface IScaleOutScaleUnitParametersList :
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Flag indicates if the operation should wait for storage to converge before returning.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Flag indicates if the operation should wait for storage to converge before returning.",
        SerializedName = @"awaitStorageConvergence",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AwaitStorageConvergence { get; set; }
        /// <summary>List of nodes in the scale unit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of nodes in the scale unit.",
        SerializedName = @"nodeList",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleOutScaleUnitParameters) })]
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleOutScaleUnitParameters[] NodeList { get; set; }

    }
    /// A list of input data that allows for adding a set of scale unit nodes.
    internal partial interface IScaleOutScaleUnitParametersListInternal

    {
        /// <summary>
        /// Flag indicates if the operation should wait for storage to converge before returning.
        /// </summary>
        bool? AwaitStorageConvergence { get; set; }
        /// <summary>List of nodes in the scale unit.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Models.Api20201001.IScaleOutScaleUnitParameters[] NodeList { get; set; }

    }
}