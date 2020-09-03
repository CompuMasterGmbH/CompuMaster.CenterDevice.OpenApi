using CenterDevice.Rest.Clients.OAuth;
using CenterDevice.Rest.ResponseHandler;
using RestSharp;
using System.Net;

namespace CenterDevice.Rest.Clients.Tenant
{
    public class TenantsRestClient : CenterDeviceRestClient, ITenantsRestClient
    {
        private static readonly string URI_RESOURCE = "v2/tenants";

        public TenantsRestClient(IOAuthInfoProvider oauthInfo, IRestClientConfiguration configuration, IRestClientErrorHandler errorHandler) : base(oauthInfo, configuration, errorHandler) { }

        public TenantResponse GetTenants(OAuthInfo oAuthInfo)
        {
            var tenantsRequest = CreateRestRequest(URI_RESOURCE, Method.GET, ContentType.APPLICATION_JSON);

            var response = Execute<TenantResponse>(oAuthInfo, tenantsRequest);
            return UnwrapResponse(response, new StatusCodeResponseHandler<TenantResponse>(HttpStatusCode.OK));
        }
    }
}
