using CenterDevice.Rest.Clients.OAuth;
using RestSharp;

namespace CenterDevice.Rest.Clients
{
    public interface IRestClientErrorHandler
    {
        void ValidateResponse(IRestResponse result);
        OAuthInfo RefreshToken(OAuthInfo oAuthInfo);
    }
}
