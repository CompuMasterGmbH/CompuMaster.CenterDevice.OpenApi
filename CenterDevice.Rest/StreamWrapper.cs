using System.IO;

namespace CenterDevice.Rest
{
    public interface StreamWrapper
    {
        Stream WrapDownloadStream(Stream stream);

        Stream WrapUploadStream(Stream stream);
    }
}
