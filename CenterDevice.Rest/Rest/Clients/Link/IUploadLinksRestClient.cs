using System;
using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.Link
{
    public interface IUploadLinksRestClient
    {
        UploadLinkCreationResponse CreateCollectionLink(string userId, string collectionId, string name, List<string> tags, DateTime? expiryDate, int? maxDocuments, string password, bool? emailCreatorOnUpload);

        UploadLinks GetAllUploadLinks(string userId);
    }
}
