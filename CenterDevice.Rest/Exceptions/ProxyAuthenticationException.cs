using System;

namespace CenterDevice.Rest.Exceptions
{
    [Serializable]
    public class ProxyAuthenticationException : Exception
    {
        public ProxyAuthenticationException(string message) : base(message) { }
    }
}
