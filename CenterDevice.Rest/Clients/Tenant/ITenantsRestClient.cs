using CenterDevice.Rest.Clients.OAuth;

namespace CenterDevice.Rest.Clients.Tenant
{
    public interface ITenantsRestClient
    {
        TenantResponse GetTenants(OAuthInfo oAuthInfo);
    }
}
