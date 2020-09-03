using System;

namespace CenterDevice.Rest.Clients.Documents.Metadata
{
    public interface IDocumentBasicMetadata
    {
        string Id { get; set; }

        string Filename { get; set; }

        long Version { get; set; }

        long Size { get; set; }

        DateTime UploadDate { get; set; }

        DateTime VersionDate { get; set; }

        DateTime? DocumentDate { get; set; }

        DateTime? ArchivedDate { get; set; }

        string Uploader { get; set; }

        string Owner { get; set; }
    }
}
