using System.Collections.Generic;

namespace CenterDevice.IO
{
    public class CenterDeviceIOClient : IOClientBase
    {
        public CenterDeviceIOClient(CenterDevice.Rest.Clients.CenterDeviceClient centerDeviceClient) : this(centerDeviceClient, centerDeviceClient.Token.UserId)
        {
        }

        public CenterDeviceIOClient(CenterDevice.Rest.Clients.CenterDeviceClient centerDeviceClient, string userID) : base(centerDeviceClient, userID)
        {
            this.centerDeviceClient = centerDeviceClient;
        }

        private readonly CenterDevice.Rest.Clients.CenterDeviceClient centerDeviceClient;
        public CenterDevice.Rest.Clients.CenterDeviceClient CenterDeviceClient
        {
            get
            {
                return this.centerDeviceClient;
            }
        }
    }
}