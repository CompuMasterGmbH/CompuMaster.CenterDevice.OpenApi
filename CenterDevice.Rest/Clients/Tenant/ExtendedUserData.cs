using CenterDevice.Rest.Clients.User;
using RestSharp.Deserializers;

namespace CenterDevice.Rest.Clients.Tenant
{
    public class ExtendedUserData : User.UserData
    {
        [DeserializeAs(Name = "first-name")]
        public string FirstName { get; set; }

        [DeserializeAs(Name = "last-name")]
        public string LastName { get; set; }
    }
}
