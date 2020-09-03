using CenterDevice.Rest.Exceptions;

namespace CenterDevice.Rest.Clients
{
    public class OfflineModeSimulator
    {
        public static bool SimulateOfflineMode { get; set; } = false;

        public void ThrowIfOffline()
        {
            if (SimulateOfflineMode)
            {
                throw new NotConnectedException("Simulating offline mode", null);
            }
        }
    }
}
