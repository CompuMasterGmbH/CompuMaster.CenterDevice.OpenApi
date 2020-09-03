namespace CenterDevice.Model.Tenant
{
    public interface TenantBaseData
    {
        string Id { get; }

        string Name { get; }

        string Status { get; }

        bool Expired { get; }

    }
}
