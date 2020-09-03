namespace CenterDevice.Rest.Clients.HealthCheck
{
    public interface IHealthCheckRestClient
    {
        bool IsConnectionWorking(bool useDefaultProxy, string userName, string password);
    }
}
