namespace CenterDevice.Rest.Clients.OAuth
{
    public interface IOAuthInfoProvider
    {
        OAuthInfo GetOAuthInfo(string userId);
    }
}
