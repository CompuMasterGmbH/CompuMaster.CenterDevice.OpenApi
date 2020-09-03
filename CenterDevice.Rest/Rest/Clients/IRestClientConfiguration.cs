namespace CenterDevice.Rest
{
    public interface IRestClientConfiguration
    {
        string BaseAddress { get; }

        string UserAgent { get; }
    }
}
