namespace CenterDevice.Rest.Clients.Documents.Metadata
{
    public interface IDocumentSharingMetadata
    {
        SharingInfo Collections { get; set; }

        CenterDevice.Rest.Clients.Common.Sharings Groups { get; set; }

        CenterDevice.Rest.Clients.Common.Sharings Users { get; set; }
    }
}
