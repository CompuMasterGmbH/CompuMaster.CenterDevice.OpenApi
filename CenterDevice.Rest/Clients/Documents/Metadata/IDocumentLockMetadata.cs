using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.Documents.Metadata
{
    public interface IDocumentLockMetadata
    {
        List<string> Locks { get; set; }

        string LockedBy { get; set; }
    }
}
