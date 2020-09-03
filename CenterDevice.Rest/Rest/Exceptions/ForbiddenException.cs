using CenterDevice.Model.Registry;
using CenterDevice.Rest.Clients;
using System;

namespace CenterDevice.Rest.Exceptions
{
    [Serializable]
    public class ForbiddenException : PermanentException
    {
        public ForbiddenException() : base() { }

        public ForbiddenException(string message, Exception innerException) : base(message, innerException) { }

        public ForbiddenException(string message, Exception innerException, DefaultErrorResponse data) : base(message, innerException, data) { }

        public override RegistryStatus GetErrorCode()
        {
            return RegistryStatus.ERROR_FORBIDDEN;
        }
    }
}
