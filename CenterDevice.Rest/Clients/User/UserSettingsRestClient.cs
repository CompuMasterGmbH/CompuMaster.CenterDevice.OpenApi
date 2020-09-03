using CenterDevice.Rest.Clients.OAuth;
using CenterDevice.Rest.ResponseHandler;
using RestSharp;
using System.Net;

namespace CenterDevice.Rest.Clients.User
{
    public class UserSettingsRestClient : CenterDeviceRestClient, IUserSettingsRestClient
    {
        private const string URI_RESOURCE = "v2/user/{0}/settings";

        public UserSettingsRestClient(IOAuthInfoProvider oauthInfo, IRestClientConfiguration configuration, IRestClientErrorHandler errorHandler) : base(oauthInfo, configuration, errorHandler)
        {
        }

        public UserSettings GetUserSettings(string userId)
        {
            var tenantRequest = CreateRestRequest(string.Format(URI_RESOURCE, userId), Method.GET, ContentType.APPLICATION_JSON);

            var response = Execute<UserSettings>(GetOAuthInfo(userId), tenantRequest);
            return UnwrapResponse(response, new StatusCodeResponseHandler<UserSettings>(HttpStatusCode.OK));
        }
    }
}
