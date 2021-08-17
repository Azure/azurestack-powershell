namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.Extensions;

    /// <summary>Extended properties.</summary>
    public partial class MetricValueProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMetricValueProperties,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Models.Api20151101.IMetricValuePropertiesInternal
    {

        /// <summary>Creates an new <see cref="MetricValueProperties" /> instance.</summary>
        public MetricValueProperties()
        {

        }
    }
    /// Extended properties.
    public partial interface IMetricValueProperties :
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Runtime.IAssociativeArray<string>
    {

    }
    /// Extended properties.
    internal partial interface IMetricValuePropertiesInternal

    {

    }
}