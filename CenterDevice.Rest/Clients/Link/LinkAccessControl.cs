using RestSharp.Deserializers;
using System;

namespace CenterDevice.Rest.Clients.Link
{
    public class LinkAccessControl
    {
        [DeserializeAs(Name = RestApiConstants.EXPIRY_DATE)]
        public DateTime? ExpiryDate { get; set; }

        [DeserializeAs(Name = RestApiConstants.MAX_DOWNLOADS)]
        public int? MaxDownloads { get; set; }

        [DeserializeAs(Name = RestApiConstants.PASSWORD)]
        public string Password { get; set; }

        [DeserializeAs(Name = RestApiConstants.VIEW_ONLY)]
        public bool ViewOnly { get; set; }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + ExpiryDate?.GetHashCode() ?? 0;
            hash = (hash * 7) + MaxDownloads?.GetHashCode() ?? 0;
            hash = (hash * 7) + Password?.GetHashCode() ?? 0;
            hash = (hash * 7) + ViewOnly.GetHashCode();
            return hash;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = obj as LinkAccessControl;
            return ExpiryDate == other.ExpiryDate
                && MaxDownloads == other.MaxDownloads
                && Password == other.Password
                && ViewOnly == other.ViewOnly;
        }

        public static bool operator ==(LinkAccessControl a, LinkAccessControl b)
        {
            if (ReferenceEquals(a, null))
            {
                return ReferenceEquals(b, null);
            }

            return a.Equals(b);
        }

        public static bool operator !=(LinkAccessControl a, LinkAccessControl b)
        {
            return !(a == b);
        }
    }
}
