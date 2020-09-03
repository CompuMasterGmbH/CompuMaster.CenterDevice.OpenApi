using System;

namespace CenterDevice.Rest.Exceptions
{
    [Serializable]
    public class TooManyRequestsException : TemporaryException
    {
        public TooManyRequestsException(TimeSpan? retryAfter)
        {
            RetryAfter = retryAfter;
        }

        public TimeSpan? RetryAfter { get; }
    }
}
