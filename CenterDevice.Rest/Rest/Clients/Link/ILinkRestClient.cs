namespace CenterDevice.Rest.Clients.Link
{
    public interface ILinkRestClient
    {
        Link GetLink(string userId, string linkId);

        void DeleteLink(string userId, string linkId);

        void UpdateLink(string userId, string linkId, LinkAccessControl accessControl);
    }
}
