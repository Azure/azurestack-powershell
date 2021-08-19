namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>Properties for a scale unit</summary>
    public partial class ScaleUnitProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IScaleUnitProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.IScaleUnitPropertiesInternal
    {

        /// <summary>Backing field for <see cref="LastUpdatedTime" /> property.</summary>
        private string _lastUpdatedTime;

        /// <summary>The scale unit last update time (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string LastUpdatedTime { get => this._lastUpdatedTime; set => this._lastUpdatedTime = value; }

        /// <summary>Backing field for <see cref="Node" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.INodeView[] _node;

        /// <summary>The nodes of the scale unit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.INodeView[] Node { get => this._node; set => this._node = value; }

        /// <summary>Backing field for <see cref="ScaleUnitName" /> property.</summary>
        private string _scaleUnitName;

        /// <summary>The name of the scale unit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string ScaleUnitName { get => this._scaleUnitName; set => this._scaleUnitName = value; }

        /// <summary>Creates an new <see cref="ScaleUnitProperties" /> instance.</summary>
        public ScaleUnitProperties()
        {

        }
    }
    /// Properties for a scale unit
    public partial interface IScaleUnitProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The scale unit last update time (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The scale unit last update time (UTC).",
        SerializedName = @"lastUpdatedTime",
        PossibleTypes = new [] { typeof(string) })]
        string LastUpdatedTime { get; set; }
        /// <summary>The nodes of the scale unit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The nodes of the scale unit.",
        SerializedName = @"nodes",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.INodeView) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.INodeView[] Node { get; set; }
        /// <summary>The name of the scale unit.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the scale unit.",
        SerializedName = @"scaleUnitName",
        PossibleTypes = new [] { typeof(string) })]
        string ScaleUnitName { get; set; }

    }
    /// Properties for a scale unit
    internal partial interface IScaleUnitPropertiesInternal

    {
        /// <summary>The scale unit last update time (UTC).</summary>
        string LastUpdatedTime { get; set; }
        /// <summary>The nodes of the scale unit.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20210330.INodeView[] Node { get; set; }
        /// <summary>The name of the scale unit.</summary>
        string ScaleUnitName { get; set; }

    }
}