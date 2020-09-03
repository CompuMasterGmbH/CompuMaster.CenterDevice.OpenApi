using System;

namespace CenterDevice.Rest.Exceptions
{
    [Serializable]
    public class NotConnectedException : TemporaryException
    {
        public NotConnectedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
