using CenterDevice.Rest.Clients.OAuth;
using CenterDevice.Rest.Clients.Tenant;
using CenterDevice.Rest.ResponseHandler;
using RestSharp;
using System.Net;

namespace CenterDevice.Rest.Clients.User
{
    public class UserRestClient : CenterDeviceRestClient, IUserRestClient
    {
        private static readonly string URI_RESOURCE = "v2/user";

        public UserRestClient(IOAuthInfoProvider oauthInfoProvider, IRestClientConfiguration configuration, IRestClientErrorHandler errorHandler) : base(oauthInfoProvider, configuration, errorHandler) { }

        public ExtendedUserData GetLoggedInUserData(OAuthInfo oAuthInfo)
        {
            var currentUserRequest = CreateRestRequest(URI_RESOURCE + "/current", Method.GET, ContentType.APPLICATION_JSON);

            var response = Execute<ExtendedUserData>(oAuthInfo, currentUserRequest);
            return UnwrapResponse(response, new StatusCodeResponseHandler<ExtendedUserData>(HttpStatusCode.OK));
        }

        public BaseUserData GetUserData(string userId, string userIdToRequest)
        {
            var currentUserRequest = CreateRestRequest(URI_RESOURCE + "/" + userIdToRequest, Method.GET, ContentType.APPLICATION_JSON);

            var response = Execute<BaseUserData>(GetOAuthInfo(userId), currentUserRequest);
            return UnwrapResponse(response, new StatusCodeResponseHandler<BaseUserData>(HttpStatusCode.OK));
        }

        public FullUserData GetUserDataField(string userId, string userIdToRequest, string field)
        {
            var request = CreateRestRequest(URI_RESOURCE + "/" + userIdToRequest, Method.GET, ContentType.APPLICATION_JSON);
            request.AddQueryParameter(RestApiConstants.FIELDS, field);

            var response = Execute<FullUserData>(GetOAuthInfo(userId), request);
            return UnwrapResponse(response, new StatusCodeResponseHandler<FullUserData>(HttpStatusCode.OK));
        }
    }
}
