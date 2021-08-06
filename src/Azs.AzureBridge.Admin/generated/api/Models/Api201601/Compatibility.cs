namespace Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Extensions;

    /// <summary>Product compatibility</summary>
    public partial class Compatibility :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibility,
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Models.Api201601.ICompatibilityInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Full error message if any compatibility issues are found</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="IsCompatible" /> property.</summary>
        private bool? _isCompatible;

        /// <summary>Tells if product is compatible with current device</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public bool? IsCompatible { get => this._isCompatible; set => this._isCompatible = value; }

        /// <summary>Backing field for <see cref="Issue" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue[] _issue;

        /// <summary>List of all issues found</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue[] Issue { get => this._issue; set => this._issue = value; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>Short error message if any compatibility issues are found</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Creates an new <see cref="Compatibility" /> instance.</summary>
        public Compatibility()
        {

        }
    }
    /// Product compatibility
    public partial interface ICompatibility :
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.IJsonSerializable
    {
        /// <summary>Full error message if any compatibility issues are found</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Full error message if any compatibility issues are found",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Tells if product is compatible with current device</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tells if product is compatible with current device",
        SerializedName = @"isCompatible",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsCompatible { get; set; }
        /// <summary>List of all issues found</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of all issues found",
        SerializedName = @"issues",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue) })]
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue[] Issue { get; set; }
        /// <summary>Short error message if any compatibility issues are found</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Short error message if any compatibility issues are found",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }

    }
    /// Product compatibility
    internal partial interface ICompatibilityInternal

    {
        /// <summary>Full error message if any compatibility issues are found</summary>
        string Description { get; set; }
        /// <summary>Tells if product is compatible with current device</summary>
        bool? IsCompatible { get; set; }
        /// <summary>List of all issues found</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BridgeAdmin.Support.CompatibilityIssue[] Issue { get; set; }
        /// <summary>Short error message if any compatibility issues are found</summary>
        string Message { get; set; }

    }
}