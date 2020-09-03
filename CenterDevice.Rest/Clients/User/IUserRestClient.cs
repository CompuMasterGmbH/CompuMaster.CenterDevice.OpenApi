using CenterDevice.Rest.Clients.OAuth;
using CenterDevice.Rest.Clients.Tenant;

namespace CenterDevice.Rest.Clients.User
{
    public interface IUserRestClient
    {
        ExtendedUserData GetLoggedInUserData(OAuthInfo oAuthInfo);

        BaseUserData GetUserData(string userId, string userIdToRequest);

        FullUserData GetUserDataField(string userId, string userIdToRequest, string field);
    }
}
