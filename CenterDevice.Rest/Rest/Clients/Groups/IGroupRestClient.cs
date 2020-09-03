namespace CenterDevice.Rest.Clients.Groups
{
    public interface IGroupRestClient
    {
        Group GetGroup(string userId, string groupId);
    }
}
