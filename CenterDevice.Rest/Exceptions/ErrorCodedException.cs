using CenterDevice.Model.Registry;

namespace CenterDevice.Rest.Exceptions
{
    public interface ErrorCodedException
    {
        RegistryStatus GetErrorCode();
    }
}
