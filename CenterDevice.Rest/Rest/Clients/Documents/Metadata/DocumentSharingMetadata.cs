namespace CenterDevice.Rest.Clients.Documents.Metadata
{
    public class DocumentSharingMetadata : IDocumentSharingMetadata
    {
        public SharingInfo Collections { get; set; }

        public CenterDevice.Rest.Clients.Common.Sharings Groups { get; set; }

        public CenterDevice.Rest.Clients.Common.Sharings Users { get; set; }
    }
}
