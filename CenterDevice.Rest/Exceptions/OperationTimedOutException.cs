using System;

namespace CenterDevice.Rest.Exceptions
{
    [Serializable]
    public class OperationTimedOutException : TemporaryException
    {
        public OperationTimedOutException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
