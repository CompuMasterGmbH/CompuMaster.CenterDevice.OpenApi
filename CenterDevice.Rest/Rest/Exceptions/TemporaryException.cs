using System;

namespace CenterDevice.Rest.Exceptions
{
    [Serializable]
    public class TemporaryException : RestClientException
    {
        public TemporaryException() : base() { }

        public TemporaryException(string message) : base(message) { }

        public TemporaryException(string message, Exception innerException) : base(message, innerException) { }
    }
}
