using CenterDevice.Rest.Clients.Folders;
using CenterDevice.Rest.Utils;
using RestSharp;
using System.Collections.Generic;
using System.Net;

namespace CenterDevice.Rest.ResponseHandler
{
    public class GetFoldersResponseHandler : BaseResponseHandler, DataResponseHandler<FoldersResponse>
    {
        public FoldersResponse UnwrapResponse(IRestResponse<FoldersResponse> result)
        {
            if (result.StatusCode == HttpStatusCode.NoContent)
            {
                var foldersResponse = new FoldersResponse();
                foldersResponse.Folders = new List<Folder>();
                return foldersResponse;
            }

            if (result.StatusCode == HttpStatusCode.OK)
            {
                return result.Data;
            }

            if (RestClientExceptionUtils.GetDefaultErrorResponse(result?.Content)?.Code == (int)ReturnCode.INVALID_STATE)
            {
                throw new FolderParentNotFoundException();
            }

            throw CreateDefaultException(HttpStatusCode.OK, result);
        }
    }
}
