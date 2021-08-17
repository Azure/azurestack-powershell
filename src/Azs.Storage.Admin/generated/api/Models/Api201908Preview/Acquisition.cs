namespace Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Extensions;

    /// <summary>The acquisition of the page BLOB.</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.DoNotFormat]
    public partial class Acquisition :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAcquisition,
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAcquisitionInternal
    {

        /// <summary>Backing field for <see cref="Blob" /> property.</summary>
        private string _blob;

        /// <summary>The name of the page BLOB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string Blob { get => this._blob; }

        /// <summary>Backing field for <see cref="Container" /> property.</summary>
        private string _container;

        /// <summary>The container associated with the page BLOB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string Container { get => this._container; }

        /// <summary>Backing field for <see cref="FilePath" /> property.</summary>
        private string _filePath;

        /// <summary>The file path of the page BLOB file on storage cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string FilePath { get => this._filePath; }

        /// <summary>Backing field for <see cref="FilePathUnc" /> property.</summary>
        private string _filePathUnc;

        /// <summary>The file path unc of the page BLOB file on storage cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string FilePathUnc { get => this._filePathUnc; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The ID of page BLOB acquisition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Backing field for <see cref="Maximumblobsize" /> property.</summary>
        private long? _maximumblobsize;

        /// <summary>The maximum size of the page BLOB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public long? Maximumblobsize { get => this._maximumblobsize; }

        /// <summary>Internal Acessors for Blob</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAcquisitionInternal.Blob { get => this._blob; set { {_blob = value;} } }

        /// <summary>Internal Acessors for Container</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAcquisitionInternal.Container { get => this._container; set { {_container = value;} } }

        /// <summary>Internal Acessors for FilePath</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAcquisitionInternal.FilePath { get => this._filePath; set { {_filePath = value;} } }

        /// <summary>Internal Acessors for FilePathUnc</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAcquisitionInternal.FilePathUnc { get => this._filePathUnc; set { {_filePathUnc = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAcquisitionInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Maximumblobsize</summary>
        long? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAcquisitionInternal.Maximumblobsize { get => this._maximumblobsize; set { {_maximumblobsize = value;} } }

        /// <summary>Internal Acessors for Status</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.AcquisitionStatus? Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAcquisitionInternal.Status { get => this._status; set { {_status = value;} } }

        /// <summary>Internal Acessors for Storageaccount</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAcquisitionInternal.Storageaccount { get => this._storageaccount; set { {_storageaccount = value;} } }

        /// <summary>Internal Acessors for Susbcriptionid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Models.Api201908Preview.IAcquisitionInternal.Susbcriptionid { get => this._susbcriptionid; set { {_susbcriptionid = value;} } }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.AcquisitionStatus? _status;

        /// <summary>The status of the page BLOB acquisition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.AcquisitionStatus? Status { get => this._status; }

        /// <summary>Backing field for <see cref="Storageaccount" /> property.</summary>
        private string _storageaccount;

        /// <summary>The storage account that holds the page BLOB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string Storageaccount { get => this._storageaccount; }

        /// <summary>Backing field for <see cref="Susbcriptionid" /> property.</summary>
        private string _susbcriptionid;

        /// <summary>ID of the subscription associated with the page BLOB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Origin(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.PropertyOrigin.Owned)]
        public string Susbcriptionid { get => this._susbcriptionid; }

        /// <summary>Creates an new <see cref="Acquisition" /> instance.</summary>
        public Acquisition()
        {

        }
    }
    /// The acquisition of the page BLOB.
    public partial interface IAcquisition :
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.IJsonSerializable
    {
        /// <summary>The name of the page BLOB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The name of the page BLOB.",
        SerializedName = @"blob",
        PossibleTypes = new [] { typeof(string) })]
        string Blob { get;  }
        /// <summary>The container associated with the page BLOB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The container associated with the page BLOB.",
        SerializedName = @"container",
        PossibleTypes = new [] { typeof(string) })]
        string Container { get;  }
        /// <summary>The file path of the page BLOB file on storage cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The file path of the page BLOB file on storage cluster.",
        SerializedName = @"filePath",
        PossibleTypes = new [] { typeof(string) })]
        string FilePath { get;  }
        /// <summary>The file path unc of the page BLOB file on storage cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The file path unc of the page BLOB file on storage cluster.",
        SerializedName = @"filePathUnc",
        PossibleTypes = new [] { typeof(string) })]
        string FilePathUnc { get;  }
        /// <summary>The ID of page BLOB acquisition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The ID of page BLOB acquisition.",
        SerializedName = @"acquisitionid",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>The maximum size of the page BLOB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The maximum size of the page BLOB.",
        SerializedName = @"maximumblobsize",
        PossibleTypes = new [] { typeof(long) })]
        long? Maximumblobsize { get;  }
        /// <summary>The status of the page BLOB acquisition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The status of the page BLOB acquisition.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.AcquisitionStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.AcquisitionStatus? Status { get;  }
        /// <summary>The storage account that holds the page BLOB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The storage account that holds the page BLOB.",
        SerializedName = @"storageaccount",
        PossibleTypes = new [] { typeof(string) })]
        string Storageaccount { get;  }
        /// <summary>ID of the subscription associated with the page BLOB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"ID of the subscription associated with the page BLOB.",
        SerializedName = @"susbcriptionid",
        PossibleTypes = new [] { typeof(string) })]
        string Susbcriptionid { get;  }

    }
    /// The acquisition of the page BLOB.
    internal partial interface IAcquisitionInternal

    {
        /// <summary>The name of the page BLOB.</summary>
        string Blob { get; set; }
        /// <summary>The container associated with the page BLOB.</summary>
        string Container { get; set; }
        /// <summary>The file path of the page BLOB file on storage cluster.</summary>
        string FilePath { get; set; }
        /// <summary>The file path unc of the page BLOB file on storage cluster.</summary>
        string FilePathUnc { get; set; }
        /// <summary>The ID of page BLOB acquisition.</summary>
        string Id { get; set; }
        /// <summary>The maximum size of the page BLOB.</summary>
        long? Maximumblobsize { get; set; }
        /// <summary>The status of the page BLOB acquisition.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.StorageAdmin.Support.AcquisitionStatus? Status { get; set; }
        /// <summary>The storage account that holds the page BLOB.</summary>
        string Storageaccount { get; set; }
        /// <summary>ID of the subscription associated with the page BLOB.</summary>
        string Susbcriptionid { get; set; }

    }
}