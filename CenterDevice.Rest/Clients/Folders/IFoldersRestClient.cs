using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.Folders
{
    public interface IFoldersRestClient
    {
        FoldersResponse GetFolders(string userId, string collectionId, string parentId, string documentId, string path, IEnumerable<string> ids, bool onlySharedFolders, bool onlyTopMost, string[] fields);

        FoldersResponse GetFolders(string userId, string collectionId, string parentId, string documentId, string path, IEnumerable<string> ids, string[] fields);

        FoldersResponse GetFolders(string userId, string collectionId, string parentId, string documentId);

        FoldersResponse GetFolders(string userId, string collectionId, string path);

        FolderCreationResponse CreateFolder(string userId, string name, string collection, string parent);
    }
}
