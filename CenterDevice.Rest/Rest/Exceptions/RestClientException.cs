using CenterDevice.Rest.Clients;
using System;

#pragma warning disable CS1591 // Fehledes XML-Kommentar für öffentlich sichtbaren Typ oder Element
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
#pragma warning restore CS1591 // Fehledes XML-Kommentar für öffentlich sichtbaren Typ oder Element