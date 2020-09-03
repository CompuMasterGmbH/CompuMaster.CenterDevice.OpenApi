using CenterDevice.Rest.Exceptions;
using CenterDevice.Rest.Utils;
using log4net;
using RestSharp;
using System.Collections.Generic;
using System.Net;
using System.Runtime.Serialization;

namespace CenterDevice.Rest.ResponseHandler
{
    public class BaseResponseHandler
    {
        private static ILog logger = LogManager.GetLogger(typeof(BaseResponseHandler));

        public virtual void ValidateResponse(IRestResponse result)
        {
            if (result.ErrorException != null)
            {
                if (result.ErrorException is SerializationException)
                {
                    logger.ErrorFormat("Serialization exception caught. Status code {0}, Content type {1}, Content {2}", result.StatusCode, result.ContentType, result.Content);

                    throw new InvalidResponseDataException(result.ErrorMessage, result.ErrorException);
                }

                throw new RestClientException(result.ErrorMessage, result.ErrorException);
            }
        }

        protected static RestClientException CreateDefaultException(HttpStatusCode expected, IRestResponse result)
        {
            return CreateDefaultException(new List<HttpStatusCode> { expected }, result);
        }

        protected static RestClientException CreateDefaultException(List<HttpStatusCode> expected, IRestResponse result)
        {
            var statusCode = result?.StatusCode;
            var content = result?.Content;
            var errorException = result.ErrorException;
            return RestClientExceptionUtils.CreateDefaultException(expected, statusCode, content, errorException);
        }


    }
}
