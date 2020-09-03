using RestSharp.Deserializers;
using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.Link
{
    public class UploadLinks
    {
        [DeserializeAs(Name = RestApiConstants.UPLOAD_LINKS)]
        public List<UploadLink> UploadLinksList { get; set; }
    }
}
