using RestSharp.Deserializers;

namespace CenterDevice.Rest.Clients.Link
{
    public class Link
    {
        [DeserializeAs(Name = RestApiConstants.WEB)]
        public string Web { get; set; }

        [DeserializeAs(Name = RestApiConstants.DOWNLOAD)]
        public string Download { get; set; }

        [DeserializeAs(Name = RestApiConstants.ID)]
        public string Id { get; set; }

        [DeserializeAs(Name = RestApiConstants.REST)]
        public string Rest { get; set; }

        [DeserializeAs(Name = RestApiConstants.ACCESS_CONTROL)]
        public LinkAccessControl AccessControl { get; set; }
    }
}
