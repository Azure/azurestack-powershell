namespace Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Extensions;

    /// <summary>Base Resource Object</summary>
    public partial class Resource :
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.IResource,
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.IResourceInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>Location of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.IResourceInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.IResourceInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Tags</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.IResourceTags Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.IResourceInternal.Tags { get => (this._tags = this._tags ?? new Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ResourceTags()); set { {_tags = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.IResourceInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Tags" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.IResourceTags _tags;

        /// <summary>List of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.IResourceTags Tags { get => (this._tags = this._tags ?? new Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.ResourceTags()); }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Type of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Origin(Microsoft.Azure.PowerShell.Cmdlets.Subscription.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="Resource" /> instance.</summary>
        public Resource()
        {

        }
    }
    /// Base Resource Object
    public partial interface IResource :
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.IJsonSerializable
    {
        /// <summary>URI of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"URI of the resource.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>Location of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Location of the resource",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>Name of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Name of the resource.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>List of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of key-value pairs.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.IResourceTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.IResourceTags Tags { get;  }
        /// <summary>Type of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Subscription.Runtime.Info(
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
        /// <summary>Location of the resource</summary>
        string Location { get; set; }
        /// <summary>Name of the resource.</summary>
        string Name { get; set; }
        /// <summary>List of key-value pairs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Subscription.Models.Api20151101.IResourceTags Tags { get; set; }
        /// <summary>Type of resource.</summary>
        string Type { get; set; }

    }
}