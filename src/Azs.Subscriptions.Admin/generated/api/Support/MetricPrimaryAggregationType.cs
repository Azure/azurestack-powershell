// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.4.5, generator: @autorest/powershell@3.0.438)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support
{

    /// <summary>The primary aggregation type for resource metric.</summary>
    public partial struct MetricPrimaryAggregationType :
        System.IEquatable<MetricPrimaryAggregationType>
    {
        /// <summary>The average aggregation type.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricPrimaryAggregationType Average = @"Average";

        /// <summary>The last aggregation type.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricPrimaryAggregationType Last = @"Last";

        /// <summary>The maximum aggregation type.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricPrimaryAggregationType Maximum = @"Maximum";

        /// <summary>The minimum aggregation type.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricPrimaryAggregationType Minimum = @"Minimum";

        /// <summary>No aggregation applied to resource.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricPrimaryAggregationType None = @"None";

        /// <summary>The total aggregation type.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricPrimaryAggregationType Total = @"Total";

        /// <summary>
        /// the value for an instance of the <see cref="MetricPrimaryAggregationType" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to MetricPrimaryAggregationType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MetricPrimaryAggregationType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new MetricPrimaryAggregationType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type MetricPrimaryAggregationType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricPrimaryAggregationType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type MetricPrimaryAggregationType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is MetricPrimaryAggregationType && Equals((MetricPrimaryAggregationType)obj);
        }

        /// <summary>Returns hashCode for enum MetricPrimaryAggregationType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>
        /// Creates an instance of the <see cref="MetricPrimaryAggregationType" Enum class./>
        /// </summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private MetricPrimaryAggregationType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for MetricPrimaryAggregationType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to MetricPrimaryAggregationType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="MetricPrimaryAggregationType" />.</param>

        public static implicit operator MetricPrimaryAggregationType(string value)
        {
            return new MetricPrimaryAggregationType(value);
        }

        /// <summary>Implicit operator to convert MetricPrimaryAggregationType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="MetricPrimaryAggregationType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricPrimaryAggregationType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum MetricPrimaryAggregationType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricPrimaryAggregationType e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricPrimaryAggregationType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum MetricPrimaryAggregationType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricPrimaryAggregationType e1, Microsoft.Azure.PowerShell.Cmdlets.SubscriptionsAdmin.Support.MetricPrimaryAggregationType e2)
        {
            return e2.Equals(e1);
        }
    }
}