using RestSharp.Deserializers;
using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.User
{
    public class UserList<T> where T : UserData
    {
        public List<T> Users { get; set; }
    }
}
