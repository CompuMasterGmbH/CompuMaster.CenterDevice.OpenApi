namespace CenterDevice.Rest.Clients.Link
{
    public interface ILinksRestClient
    {
        LinkCreationResponse CreateDocumentLink(string userId, string id, LinkAccessControl accessControl);

        LinkCreationResponse CreateFolderLink(string userId, string id, LinkAccessControl accessControl);

        LinkCreationResponse CreateCollectionLink(string userId, string id, LinkAccessControl accessControl);
    }
}
