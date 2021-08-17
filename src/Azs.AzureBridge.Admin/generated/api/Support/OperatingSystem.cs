// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.4.5, generator: @autorest/powershell@3.0.438)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support
{

    /// <summary>Operating system type (Windows or Linux).</summary>
    public partial struct OperatingSystem :
        System.IEquatable<OperatingSystem>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem Linux = @"Linux";

        public static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem None = @"None";

        public static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem Windows = @"Windows";

        /// <summary>the value for an instance of the <see cref="OperatingSystem" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to OperatingSystem</summary>
        /// <param name="value">the value to convert to an instance of <see cref="OperatingSystem" />.</param>
        internal static object CreateFrom(object value)
        {
            return new OperatingSystem(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type OperatingSystem</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type OperatingSystem (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is OperatingSystem && Equals((OperatingSystem)obj);
        }

        /// <summary>Returns hashCode for enum OperatingSystem</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="OperatingSystem" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private OperatingSystem(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for OperatingSystem</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to OperatingSystem</summary>
        /// <param name="value">the value to convert to an instance of <see cref="OperatingSystem" />.</param>

        public static implicit operator OperatingSystem(string value)
        {
            return new OperatingSystem(value);
        }

        /// <summary>Implicit operator to convert OperatingSystem to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="OperatingSystem" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum OperatingSystem</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem e1, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum OperatingSystem</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem e1, Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.OperatingSystem e2)
        {
            return e2.Equals(e1);
        }
    }
}