using RestSharp;

namespace CenterDevice.Rest.ResponseHandler
{
    public interface DataResponseHandler<T>
    {
        void ValidateResponse(IRestResponse result);

        T UnwrapResponse(IRestResponse<T> result);
    }
}
