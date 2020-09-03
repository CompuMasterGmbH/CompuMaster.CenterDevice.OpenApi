using CenterDevice.Rest.Clients.OAuth;
using CenterDevice.Rest.ResponseHandler;
using RestSharp;
using System.Net;

namespace CenterDevice.Rest.Clients.Groups
{
    public class GroupRestClient : CenterDeviceRestClient, IGroupRestClient
    {
        private const string URI_RESOURCE = "v2/group/";

        public GroupRestClient(IOAuthInfoProvider oauthInfoProvider, IRestClientConfiguration configuration, IRestClientErrorHandler errorHandler) : base(oauthInfoProvider, configuration, errorHandler) { }

        public Group GetGroup(string userId, string groupId)
        {
            var request = CreateRestRequest(URI_RESOURCE + groupId, Method.GET, ContentType.APPLICATION_JSON);

            var result = Execute<Group>(GetOAuthInfo(userId), request);
            return UnwrapResponse(result, new StatusCodeResponseHandler<Group>(HttpStatusCode.OK));
        }
    }
}
