using CenterDevice.Rest.Clients;
using CenterDevice.Rest.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace CenterDevice.Rest.Utils
{
    class RestClientExceptionUtils
    {
        private const string WRONG_STATUS_CODE_MESSAGE = "Expected status code \"{0}\" but got \"{1}\"";


        public static RestClientException CreateDefaultException(List<HttpStatusCode> expected, HttpStatusCode? statusCode, string content, Exception errorException)
        {
            var data = GetDefaultErrorResponse(content);

            var message = GetErrorMessage(expected, data, statusCode);
            if (statusCode == HttpStatusCode.NotFound)
            {
                return new NotFoundException(message, errorException, data);
            }
            if (statusCode == HttpStatusCode.InternalServerError)
            {
                return new InternalServerErrorException(message, errorException, data);
            }
            if (statusCode == HttpStatusCode.Forbidden)
            {
                return new ForbiddenException(message, errorException, data);
            }
            if (statusCode == HttpStatusCode.Unauthorized)
            {
                return new UnauthorizedException(message, errorException, data);
            }
            if (statusCode == HttpStatusCode.BadRequest)
            {
                return new BadRequestException(message, errorException, data);
            }

            return new RestClientException(message, errorException, data);
        }

        protected static string GetErrorMessage(List<HttpStatusCode> expected, DefaultErrorResponse data, HttpStatusCode? result)
        {
            var statusCodeMessage = string.Format(WRONG_STATUS_CODE_MESSAGE, GetExpectedStatusCodeText(expected), GetResponseStatusCodeText(result));

            if (data != null)
            {
                return data.ToErrorMessage() + " (" + statusCodeMessage + ")";
            }

            return statusCodeMessage;
        }

        private static string GetExpectedStatusCodeText(List<HttpStatusCode> expected)
        {
            if (expected.Count == 0)
            {
                return "?"; // No valid status code has been defined, basically invalid case.
            }
            else if (expected.Count == 1)
            {
                return expected[0].ToString();
            }
            else
            {
                return string.Join(", ", expected);
            }
        }

        private static string GetResponseStatusCodeText(HttpStatusCode? statusCode)
        {
            if (statusCode.HasValue)
            {
                if (statusCode == 0)
                {
                    return "NoResponse";
                }

                return statusCode.ToString();
            }

            return "Unknown";
        }

        public static DefaultErrorResponse GetDefaultErrorResponse(string response)
        {
            try
            {
                if (response != null)
                {
                    return JsonConvert.DeserializeObject<DefaultErrorResponse>(response);
                }
            }
            catch (Exception) { }

            return null;
        }
    }
}
