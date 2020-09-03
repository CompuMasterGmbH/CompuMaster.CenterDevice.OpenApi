using CenterDevice.Rest.Clients;
using System;

namespace CenterDevice.Rest.Exceptions
{
    [Serializable]
    public class BadRequestException : RestClientException
    {
        public BadRequestException() : base() { }

        public BadRequestException(string message, Exception innerException) : base(message, innerException) { }

        public BadRequestException(string message, Exception innerException, DefaultErrorResponse defaultErrorResponse) : base(message, innerException, defaultErrorResponse)
        {
        }
    }
}
