namespace CenterDevice.Rest.Clients.OAuth
{
    public interface IOAuthClientConfiguration : IRestClientConfiguration
    {
        string ClientId { get; }

        string ClientSecret { get; }

        string RedirectUri { get; }
    }
}
