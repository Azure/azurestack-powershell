namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Extensions;

    /// <summary>List of Locations</summary>
    public partial class LocationsList :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ILocationsList,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ILocationsListInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ILocationsListInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ILocation[] Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ILocationsListInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>URI to the next page of locations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ILocation[] _value;

        /// <summary>Array of locations</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ILocation[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="LocationsList" /> instance.</summary>
        public LocationsList()
        {

        }
    }
    /// List of Locations
    public partial interface ILocationsList :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.IJsonSerializable
    {
        /// <summary>URI to the next page of locations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"URI to the next page of locations.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>Array of locations</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Array of locations",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ILocation) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ILocation[] Value { get;  }

    }
    /// List of Locations
    internal partial interface ILocationsListInternal

    {
        /// <summary>URI to the next page of locations.</summary>
        string NextLink { get; set; }
        /// <summary>Array of locations</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkAdmin.Models.Api20150615.ILocation[] Value { get; set; }

    }
}