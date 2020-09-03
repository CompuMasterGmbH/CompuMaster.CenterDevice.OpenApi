using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.User
{
    public interface IUsersRestClient
    {
        UserList<BaseUserData> GetAllUsers(string userId, string[] userStatuses);
    }
}
