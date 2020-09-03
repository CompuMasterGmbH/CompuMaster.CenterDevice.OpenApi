namespace CenterDevice.Rest.Clients.OAuth
{
    public class OAuthInfo
    {
        public string UserId { get; set; }
        public string Email { get; set; }
        public string TenantId { get; set; }
        public string token_type { get; set; }
        public string access_token { get; set; }
        public long expires_in { get; set; }
        public string refresh_token { get; set; }
    }
}
