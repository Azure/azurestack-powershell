namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Extensions;

    /// <summary>List features.</summary>
    public partial class FeatureList :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeatureList,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeatureListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeature[] _value;

        /// <summary>List of features.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeature[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="FeatureList" /> instance.</summary>
        public FeatureList()
        {

        }
    }
    /// List features.
    public partial interface IFeatureList :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>List of features.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of features.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeature) })]
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeature[] Value { get; set; }

    }
    /// List features.
    internal partial interface IFeatureListInternal

    {
        /// <summary>URI to the next page.</summary>
        string NextLink { get; set; }
        /// <summary>List of features.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ComputeAdmin.Models.Api20201101.IFeature[] Value { get; set; }

    }
}