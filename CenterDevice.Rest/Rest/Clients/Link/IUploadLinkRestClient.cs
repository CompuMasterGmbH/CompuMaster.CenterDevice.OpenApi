using System;
using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.Link
{
    public interface IUploadLinkRestClient
    {
        UploadLink GetLink(string userId, string linkId);

        void DeleteLink(string userId, string linkId);

        void UpdateLink(string userId, string linkId, string collectionId, string name, List<string> tags, DateTime? expiryDate, int? maxDocuments, string password, bool? emailCreatorOnUpload);
    }
}
