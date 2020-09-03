﻿using CenterDevice.Rest.Clients.OAuth;
using CenterDevice.Rest.ResponseHandler;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Net;

namespace CenterDevice.Rest.Clients.Tenant
{
    public class TenantFeaturesRestClient : CenterDeviceRestClient, ITenantFeaturesRestClient
    {
        private string URI_RESOURCE
        {
            get
            {
                return this.ApiVersionPrefix + "tenant/{0}/features";
            }
        }

        public TenantFeaturesRestClient(IOAuthInfoProvider oauthInfo, IRestClientConfiguration configuration, IRestClientErrorHandler errorHandler, string apiVersionPrefix) : base(oauthInfo, configuration, errorHandler, apiVersionPrefix)
        {
        }

        public TenantFeatures GetTenantFeatures(string userId, string tenantId)
        {
            var tenantRequest = CreateRestRequest(string.Format(URI_RESOURCE, tenantId), Method.GET, ContentType.APPLICATION_JSON);

            var response = Execute<TenantFeatures>(GetOAuthInfo(userId), tenantRequest);
            return UnwrapResponse(response, new StatusCodeResponseHandler<TenantFeatures>(HttpStatusCode.OK));
        }

        public void EnableTenantFeature(string userId, string tenantId, string feature)
        {
            var request = CreateRestRequest(string.Format(URI_RESOURCE, tenantId), Method.POST, ContentType.APPLICATION_JSON);

            var parameters = new JObject
            {
                [RestApiConstants.ACTION] = RestApiConstants.ENABLE,
                [RestApiConstants.PARAMS] = new JObject
                {
                    [RestApiConstants.FEATURE] = feature
                }
            };
            request.AddParameter(ContentType.APPLICATION_JSON, parameters.ToString(), ParameterType.RequestBody);

            IRestResponse result = Execute(GetOAuthInfo(userId), request);
            ValidateResponse(result, new StatusCodeResponseHandler(HttpStatusCode.NoContent));
        }
    }
}