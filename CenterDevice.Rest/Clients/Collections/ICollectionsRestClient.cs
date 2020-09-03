using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.Collections
{
    public interface ICollectionsRestClient
    {
        CollectionsResults GetCollections(string userId);

        CollectionsResults GetCollections(string userId, IEnumerable<string> ids, bool includeHasFolders);

        IEnumerable<string> GetCollectionIds(string userId, bool includePublic);

        CreateCollectionResponse CreateCollection(string userId, string collectionName);
    }
}
