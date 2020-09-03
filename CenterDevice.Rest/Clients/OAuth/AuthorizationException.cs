using CenterDevice.Rest.Exceptions;

namespace CenterDevice.Rest.Clients.OAuth
{
    public class AuthorizationException : TemporaryException
    {
        public AuthorizationException(string message) : base(message) { }
    }
}
