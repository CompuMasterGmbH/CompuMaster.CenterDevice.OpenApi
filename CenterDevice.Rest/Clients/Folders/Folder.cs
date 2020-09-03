
using CenterDevice.Model.Folder;
using CenterDevice.Rest.Clients.Common;
using RestSharp.Deserializers;
using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.Folders
{
    public class Folder : IFolderBaseData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Parent { get; set; }

        public string Collection { get; set; }

        [DeserializeAs(Name = RestApiConstants.PATH)]
        public List<string> Path { get; set; }

        [DeserializeAs(Name = RestApiConstants.HAS_SUBFOLDERS)]
        public bool? HasSubfolders { get; set; }

        public string Link { get; set; }

        public Sharings Users { get; set; }
        public Sharings Groups { get; set; }

        public bool IsRootFolder()
        {
            return Parent == RestApiConstants.NONE;
        }

        public bool Shared
        {
            get
            {
                return (Users != null && Users.HasSharing) || (Groups != null && Groups.HasSharing) || Link != null;
            }
        }
    }
}
