namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Extensions;

    /// <summary>Pageable list of load balancers.</summary>
    public partial class LoadBalancerList :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ILoadBalancerList,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ILoadBalancerListInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ILoadBalancer[] _value;

        /// <summary>List of load balancers for this page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ILoadBalancer[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="LoadBalancerList" /> instance.</summary>
        public LoadBalancerList()
        {

        }
    }
    /// Pageable list of load balancers.
    public partial interface ILoadBalancerList :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.IJsonSerializable
    {
        /// <summary>URI to the next page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"URI to the next page.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>List of load balancers for this page.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of load balancers for this page.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ILoadBalancer) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ILoadBalancer[] Value { get; set; }

    }
    /// Pageable list of load balancers.
    internal partial interface ILoadBalancerListInternal

    {
        /// <summary>URI to the next page.</summary>
        string NextLink { get; set; }
        /// <summary>List of load balancers for this page.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ILoadBalancer[] Value { get; set; }

    }
}