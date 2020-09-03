using RestSharp.Deserializers;
using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.Common
{
    public class SharingResponse
    {
        [DeserializeAs(Name = RestApiConstants.FAILED_GROUPS)]
        public List<string> FailedGroups { get; set; }

        [DeserializeAs(Name = RestApiConstants.FAILED_USERS)]
        public List<string> FailedUsers { get; set; }
    }
}
