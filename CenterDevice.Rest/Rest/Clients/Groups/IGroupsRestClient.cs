using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.Groups
{
    public interface IGroupsRestClient
    {
        GroupList GetAllGroups(string userId, CenterDevice.Model.Groups.GroupsFilter filter);
    }
}
