using RestSharp.Deserializers;
using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.Documents.Metadata
{
    public class DocumentFullMetadata : DocumentBasicMetadata, IDocumentSharingMetadata, IDocumentFolderMetadata, IDocumentLinkMetadata, IDocumentLockMetadata
    {
        public List<string> Locks { get; set; }

        [DeserializeAs(Name = RestApiConstants.LOCKED_BY)]
        public string LockedBy { get; set; }

        public SharingInfo Collections { get; set; }

        public List<string> Folders { get; set; }

        public string Link { get; set; }
    }
}
