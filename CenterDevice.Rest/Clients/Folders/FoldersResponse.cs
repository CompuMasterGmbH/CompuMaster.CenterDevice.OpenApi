using System;
using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.Folders
{
    public class FoldersResponse
    {
        public List<Folder> Folders { get; set; }

        public void Select(object toFileSystemElement)
        {
            throw new NotImplementedException();
        }
    }
}
