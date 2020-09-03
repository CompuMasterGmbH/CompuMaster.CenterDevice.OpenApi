using CenterDevice.Rest.Clients.OAuth;
using CenterDevice.Rest.Exceptions;
using CenterDevice.Rest.ResponseHandler;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace CenterDevice.Rest.Clients
{
    /// <summary>
    /// CenterDeviceClient for low level API access to CenterDevice services
    /// </summary>
    public class CenterDeviceClient : CenterDeviceClientBase
    {
        public CenterDeviceClient(IOAuthInfoProvider oAuthInfoProvider, IRestClientConfiguration configuration, IRestClientErrorHandler errorHandler) : base(oAuthInfoProvider, configuration, errorHandler, "v2/")
        {
        }

        public Rest.Clients.HealthCheck.HealthCheckRestClient HealthCheck => new Rest.Clients.HealthCheck.HealthCheckRestClient(configuration, errorHandler);

        protected override string UploadLinkBaseUrl => "https://upload.centerdevice.de/";
    }
}
