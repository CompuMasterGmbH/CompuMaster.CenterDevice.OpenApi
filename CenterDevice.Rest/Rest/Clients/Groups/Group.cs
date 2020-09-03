using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.Groups
{
    public class Group
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Color { get; set; }
        public List<string> Users { get; set; }
    }
}
