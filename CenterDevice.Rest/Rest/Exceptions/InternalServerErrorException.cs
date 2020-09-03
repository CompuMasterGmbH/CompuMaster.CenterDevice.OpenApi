using CenterDevice.Rest.Clients;
using System;

namespace CenterDevice.Rest.Exceptions
{
    [Serializable]
    public class InternalServerErrorException : RestClientException
    {
        public InternalServerErrorException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public InternalServerErrorException(string message, Exception innerException, DefaultErrorResponse defaultErrorResponse) : base(message, innerException, defaultErrorResponse)
        {
        }
    }
}
