using RestSharp.Deserializers;
using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.Documents.Metadata
{
    public class DocumentSyncMetadata : DocumentBasicMetadata, IDocumentLockMetadata
    {
        public List<string> Locks { get; set; }

        [DeserializeAs(Name = RestApiConstants.LOCKED_BY)]
        public string LockedBy { get; set; }
    }
}
