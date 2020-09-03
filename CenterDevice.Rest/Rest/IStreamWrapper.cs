using System.IO;

namespace CenterDevice.Rest
{
    /// <summary>
    /// The common interface for a stream wrapper, allowing custom implementations for download/upload transfer limit
    /// </summary>
    public interface IStreamWrapper
    {
        Stream WrapDownloadStream(Stream stream);

        Stream WrapUploadStream(Stream stream);
    }
}
