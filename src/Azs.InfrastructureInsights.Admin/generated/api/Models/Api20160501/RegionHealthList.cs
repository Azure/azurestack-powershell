namespace Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Extensions;

    /// <summary>Pageable list of region health items.</summary>
    public partial class RegionHealthList :
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IRegionHealthList,
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IRegionHealthListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IRegionHealth[] _value;

        /// <summary>Array of region health items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IRegionHealth[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="RegionHealthList" /> instance.</summary>
        public RegionHealthList()
        {

        }
    }
    /// Pageable list of region health items.
    public partial interface IRegionHealthList :
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>URI to next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>Array of region health items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Array of region health items",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IRegionHealth) })]
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IRegionHealth[] Value { get; set; }

    }
    /// Pageable list of region health items.
    internal partial interface IRegionHealthListInternal

    {
        /// <summary>URI to next page.</summary>
        string NextLink { get; set; }
        /// <summary>Array of region health items</summary>
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IRegionHealth[] Value { get; set; }

    }
}