using CenterDevice.Rest.Clients;
using System;

namespace CenterDevice.Rest.Exceptions
{
    [Serializable]
    public class RestClientException : Exception
    {
        public DefaultErrorResponse ErrorResponse { get; }

        public RestClientException() : base()
        {

        }

        public RestClientException(string message) : base(message)
        {

        }

        public RestClientException(string message, Exception innerException) : base(message, innerException)
        {

        }

        public RestClientException(string message, Exception innerException, DefaultErrorResponse defaultErrorResponse) : base(message, innerException)
        {
            ErrorResponse = defaultErrorResponse;
        }
    }
}
