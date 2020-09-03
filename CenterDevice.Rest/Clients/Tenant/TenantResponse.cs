using RestSharp.Deserializers;
using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.Tenant
{
    public class TenantResponse
    {
        public List<TenantData> Tenants { get; set; }

        [DeserializeAs(Name = "default-tenant-id")]
        public string DefaultTenantId { get; set; }
    }
}
