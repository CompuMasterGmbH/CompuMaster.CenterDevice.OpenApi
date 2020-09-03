namespace CenterDevice.Rest.Clients.Tenant
{
    public interface ITenantSettingsRestClient
    {
        TenantSettings GetTenantSettings(string userId, string tenantId);
    }
}
