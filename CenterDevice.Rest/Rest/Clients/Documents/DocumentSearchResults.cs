using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.Documents
{
    public class DocumentSearchResults<T>
    {
        public int Hits { get; set; }
        public List<T> Documents { get; set; }
    }
}
