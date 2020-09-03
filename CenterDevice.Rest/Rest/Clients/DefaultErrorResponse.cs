
using System.Collections.Generic;

namespace CenterDevice.Rest.Clients
{
    public class DefaultErrorResponse
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public Dictionary<string, object> Data { get; set; }

        public string ToErrorMessage()
        {
            var message = "Got status code \"" + Code + "\" with message \"" + Message + "\"";
            if (Data != null && Data.ContainsKey("explanation"))
            {
                message += " and explanation \"" + Data["explanation"] + "\"";
            }
            return message;
        }
    }
}
