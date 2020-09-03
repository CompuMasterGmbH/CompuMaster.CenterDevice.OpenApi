using RestSharp.Deserializers;
using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.Collections
{
    public class DocumentSharingResponse
    {
        [DeserializeAs(Name = RestApiConstants.FAILED_DOCUMENTS)]
        public List<string> FailedDocuments { get; set; }

        public bool HasFailedDocuments { get { return FailedDocuments != null && FailedDocuments.Count > 0; } }
    }
}
