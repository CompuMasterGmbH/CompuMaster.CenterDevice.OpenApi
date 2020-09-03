namespace CenterDevice.Rest.Clients.Tenant
{
    public interface ITenantFeaturesRestClient
    {
        TenantFeatures GetTenantFeatures(string userId, string tenantId);
        void EnableTenantFeature(string userId, string tenantId, string feature);
    }
}