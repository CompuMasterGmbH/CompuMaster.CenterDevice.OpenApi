using RestSharp.Deserializers;

namespace CenterDevice.Rest.Clients.Link
{
    public class UploadLinkCreationResponse
    {
        [DeserializeAs(Name = "web")]
        public string Web { get; set; }

        [DeserializeAs(Name = "id")]
        public string Id { get; set; }
    }
}
