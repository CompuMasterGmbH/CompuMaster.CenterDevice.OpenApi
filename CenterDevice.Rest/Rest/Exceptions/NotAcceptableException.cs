using System;

namespace CenterDevice.Rest.Exceptions
{
    public class NotAcceptableException : RestClientException
    {
        public NotAcceptableException() : base() { }

        public NotAcceptableException(string message) : base(message) { }

        public NotAcceptableException(string message, Exception cause) : base(message, cause) { }
    }
}
