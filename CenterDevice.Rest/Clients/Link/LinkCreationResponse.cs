using RestSharp.Deserializers;

namespace CenterDevice.Rest.Clients.Link
{
    public class LinkCreationResponse
    {
        [DeserializeAs(Name = "web")]
        public string Web { get; set; }

        [DeserializeAs(Name = "download")]
        public string Download { get; set; }

        [DeserializeAs(Name = "id")]
        public string Id { get; set; }
    }
}
