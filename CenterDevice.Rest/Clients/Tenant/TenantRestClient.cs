using CenterDevice.Rest.Clients.OAuth;
using CenterDevice.Rest.ResponseHandler;
using RestSharp;
using System.Net;

namespace CenterDevice.Rest.Clients.Tenant
{
    public class TenantRestClient : CenterDeviceRestClient
    {
        private static readonly string URI_RESOURCE = "v2/tenant/";

        public TenantRestClient(IOAuthInfoProvider oauthInfo, IRestClientConfiguration configuration, IRestClientErrorHandler errorHandler) : base(oauthInfo, configuration, errorHandler) { }

        public TenantData GetTenant(OAuthInfo oAuthInfo, string tenantId)
        {
            var tenantRequest = CreateRestRequest(URI_RESOURCE + tenantId, Method.GET, ContentType.APPLICATION_JSON);

            var response = Execute<TenantData>(oAuthInfo, tenantRequest);
            return UnwrapResponse(response, new StatusCodeResponseHandler<TenantData>(HttpStatusCode.OK));
        }
    }
}
