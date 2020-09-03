using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.Documents.Metadata
{
    public interface IDocumentFolderMetadata
    {
        List<string> Folders { get; set; }
    }
}
