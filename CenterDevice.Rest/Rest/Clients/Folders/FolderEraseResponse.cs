using RestSharp.Deserializers;
using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.Folders
{
    public class FolderEraseResponse
    {
        [DeserializeAs(Name = RestApiConstants.DOCUMENTS_NOT_DELETED)]
        public List<string> DocumentsRemainedInCollection { get; set; }

        [DeserializeAs(Name = RestApiConstants.FOLDERS_NOT_DELETED)]
        public List<string> FoldersRemainedCollection { get; set; }
    }
}
