namespace CenterDevice.Rest.Clients.User
{
    public interface IUserSettingsRestClient
    {
        UserSettings GetUserSettings(string userId);
    }
}
