﻿using RestSharp;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace CenterDevice.Rest.ResponseHandler
{
    public class StatusCodeResponseHandler : BaseResponseHandler
    {
        protected readonly List<HttpStatusCode> expectedStatus;

        public StatusCodeResponseHandler(HttpStatusCode statusCode) : this(new List<HttpStatusCode> { statusCode }) { }

        public StatusCodeResponseHandler(params HttpStatusCode[] statusCodes) : this(statusCodes.ToList()) { }

        public StatusCodeResponseHandler(List<HttpStatusCode> statusCodes)
        {
            expectedStatus = statusCodes;
        }

        override public void ValidateResponse(IRestResponse result)
        {
            if (!expectedStatus.Contains(result.StatusCode))
            {
                throw CreateDefaultException(expectedStatus, result);
            }

            base.ValidateResponse(result);
        }
    }

    public class StatusCodeResponseHandler<T> : StatusCodeResponseHandler, DataResponseHandler<T>
    {
        public StatusCodeResponseHandler(HttpStatusCode statusCode) : base(statusCode) { }

        public StatusCodeResponseHandler(List<HttpStatusCode> statusCode) : base(statusCode) { }

        public StatusCodeResponseHandler(params HttpStatusCode[] statusCode) : base(statusCode) { }

        public T UnwrapResponse(IRestResponse<T> result)
        {
            return result.Data;
        }
    }
}