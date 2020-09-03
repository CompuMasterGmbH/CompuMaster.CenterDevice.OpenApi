using Newtonsoft.Json.Linq;

namespace CenterDevice.Rest.Clients.Link
{
    static class AccessControlConverter
    {
        public static JObject ToJsonObject(LinkAccessControl accessControl)
        {
            var access = new JObject();
            if (accessControl.ExpiryDate != null)
            {
                access[RestApiConstants.EXPIRY_DATE] = accessControl.ExpiryDate;
            }

            if (accessControl.MaxDownloads != null)
            {
                access[RestApiConstants.MAX_DOWNLOADS] = accessControl.MaxDownloads;
            }

            if (accessControl.Password != null)
            {
                access[RestApiConstants.PASSWORD] = accessControl.Password;
            }

            access[RestApiConstants.VIEW_ONLY] = accessControl.ViewOnly;
            return access;
        }
    }
}
