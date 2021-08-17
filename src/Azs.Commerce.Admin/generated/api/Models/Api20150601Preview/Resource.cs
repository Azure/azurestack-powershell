namespace Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Extensions;

    /// <summary>Base Resource Object</summary>
    public partial class Resource :
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResource,
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>Location where resource is location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Owned)]
        public string Location { get => this._location; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Location</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal.Location { get => this._location; set { {_location = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Tag</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceTags Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal.Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.ResourceTags()); set { {_tag = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceTags _tag;

        /// <summary>List of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.ResourceTags()); }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Type of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="Resource" /> instance.</summary>
        public Resource()
        {

        }
    }
    /// Base Resource Object
    public partial interface IResource :
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.IJsonSerializable
    {
        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"URI of the resource.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>Location where resource is location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Location where resource is location.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get;  }
        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Name of the resource.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>List of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of key-value pairs.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceTags Tag { get;  }
        /// <summary>Type of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Type of resource.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// Base Resource Object
    internal partial interface IResourceInternal

    {
        /// <summary>URI of the resource.</summary>
        string Id { get; set; }
        /// <summary>Location where resource is location.</summary>
        string Location { get; set; }
        /// <summary>Name of the resource.</summary>
        string Name { get; set; }
        /// <summary>List of key-value pairs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CommerceAdmin.Models.Api20150601Preview.IResourceTags Tag { get; set; }
        /// <summary>Type of resource.</summary>
        string Type { get; set; }

    }
}