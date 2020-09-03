using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.Documents.Metadata
{
    public class DocumentFolderMetadata : IDocumentFolderMetadata
    {
        public List<string> Folders { get; set; }
    }
}
