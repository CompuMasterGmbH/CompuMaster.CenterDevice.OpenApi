using CenterDevice.Rest.Exceptions;
using System;

namespace CenterDevice.Rest.Clients.Documents
{
    [Serializable]
    public class NameUnchangedException : RestClientException
    {
        public NameUnchangedException(string message) : base(message, null)
        {

        }
    }
}
