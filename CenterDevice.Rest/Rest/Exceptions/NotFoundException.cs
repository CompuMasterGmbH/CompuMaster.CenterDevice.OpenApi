using CenterDevice.Model.Registry;
using CenterDevice.Rest.Clients;
using System;

namespace CenterDevice.Rest.Exceptions
{
    [Serializable]
    public class NotFoundException : PermanentException
    {
        public NotFoundException() : base() { }

        public NotFoundException(string message, Exception innerException) : base(message, innerException) { }

        public NotFoundException(string message, Exception e, DefaultErrorResponse data) : base(message, e, data)
        {
        }

        public override RegistryStatus GetErrorCode()
        {
            return RegistryStatus.ERROR_NOT_FOUND;
        }
    }
}
