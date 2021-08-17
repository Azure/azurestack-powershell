namespace Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Extensions;

    /// <summary>Pageable list of service health objects.</summary>
    public partial class ServiceHealthList :
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IServiceHealthList,
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IServiceHealthListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URI of the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IServiceHealth[] _value;

        /// <summary>List of service health objects.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IServiceHealth[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ServiceHealthList" /> instance.</summary>
        public ServiceHealthList()
        {

        }
    }
    /// Pageable list of service health objects.
    public partial interface IServiceHealthList :
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.IJsonSerializable
    {
        /// <summary>URI of the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI of the next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>List of service health objects.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of service health objects.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IServiceHealth) })]
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IServiceHealth[] Value { get; set; }

    }
    /// Pageable list of service health objects.
    internal partial interface IServiceHealthListInternal

    {
        /// <summary>URI of the next page.</summary>
        string NextLink { get; set; }
        /// <summary>List of service health objects.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.InfrastructureInsightsAdmin.Models.Api20160501.IServiceHealth[] Value { get; set; }

    }
}