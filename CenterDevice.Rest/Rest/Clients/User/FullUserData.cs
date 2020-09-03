using CenterDevice.Rest.Clients.Collections;
using CenterDevice.Rest.Clients.Groups;
using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.User
{
    public class FullUserData : BaseUserData
    {
        public List<Collection> Collections { get; set; }

        public List<Group> Groups { get; set; }

    }
}
