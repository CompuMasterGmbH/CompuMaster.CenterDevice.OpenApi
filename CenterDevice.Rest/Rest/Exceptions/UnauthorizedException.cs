using CenterDevice.Rest.Clients;
using System;

namespace CenterDevice.Rest.Exceptions
{
    [Serializable]
    public class UnauthorizedException : RestClientException
    {
        public UnauthorizedException() : base() { }

        public UnauthorizedException(string message, Exception innerException) : base(message, innerException) { }

        public UnauthorizedException(string message, Exception innerException, DefaultErrorResponse defaultErrorResponse) : base(message, innerException, defaultErrorResponse)
        {
        }
    }
}
