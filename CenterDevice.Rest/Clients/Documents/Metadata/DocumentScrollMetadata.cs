using RestSharp.Deserializers;
using System;

namespace CenterDevice.Rest.Clients.Documents.Metadata
{
    public class DocumentScrollMetadata
    {
        public string Id { get; set; }

        [DeserializeAs(Name = RestApiConstants.VERSION_DATE)]
        public DateTime VersionDate { get; set; }
    }
}
