using System.Net;
using RestSharp;
using CenterDevice.Rest.Clients.Documents;

namespace CenterDevice.Rest.ResponseHandler
{
    public class RenameDocumentResponseHandler: BaseResponseHandler, DataResponseHandler<NewVersionUploadResponse>
    {
        public NewVersionUploadResponse UnwrapResponse(IRestResponse<NewVersionUploadResponse> result)
        {
            if (result.StatusCode == HttpStatusCode.NoContent)
            {
                throw new NameUnchangedException("The document has not been renamed as it already has the requested name");
            }

            if (result.StatusCode == HttpStatusCode.Created)
            {
                return result.Data;
            }

            throw CreateDefaultException(HttpStatusCode.Created, result);
        }
    }
}
