using System;

namespace CenterDevice.Rest.Exceptions
{
    [Serializable]
    public class InvalidResponseDataException : RestClientException
    {
        public InvalidResponseDataException(string message, Exception innerException) : base(message, innerException) { }
    }
}
