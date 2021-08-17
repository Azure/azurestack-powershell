// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.4.5, generator: @autorest/powershell@3.0.438)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support
{

    /// <summary>Status of the physical machine.</summary>
    public partial struct ScaleUnitNodeStatus :
        System.IEquatable<ScaleUnitNodeStatus>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitNodeStatus Maintenance = @"Maintenance";

        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitNodeStatus Running = @"Running";

        public static Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitNodeStatus Stopped = @"Stopped";

        /// <summary>the value for an instance of the <see cref="ScaleUnitNodeStatus" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to ScaleUnitNodeStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ScaleUnitNodeStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ScaleUnitNodeStatus(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ScaleUnitNodeStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitNodeStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ScaleUnitNodeStatus (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ScaleUnitNodeStatus && Equals((ScaleUnitNodeStatus)obj);
        }

        /// <summary>Returns hashCode for enum ScaleUnitNodeStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="ScaleUnitNodeStatus" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ScaleUnitNodeStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for ScaleUnitNodeStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ScaleUnitNodeStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ScaleUnitNodeStatus" />.</param>

        public static implicit operator ScaleUnitNodeStatus(string value)
        {
            return new ScaleUnitNodeStatus(value);
        }

        /// <summary>Implicit operator to convert ScaleUnitNodeStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ScaleUnitNodeStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitNodeStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ScaleUnitNodeStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitNodeStatus e1, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitNodeStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ScaleUnitNodeStatus</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitNodeStatus e1, Microsoft.Azure.PowerShell.Cmdlets.FabricAdmin.Support.ScaleUnitNodeStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}