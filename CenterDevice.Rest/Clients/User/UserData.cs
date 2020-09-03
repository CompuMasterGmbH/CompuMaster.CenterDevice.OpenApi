﻿using RestSharp.Deserializers;

namespace CenterDevice.Rest.Clients.User
{
    public class UserData
    {
        public const string ROLE_GUEST = "guest";

        public string Id { get; set; }

        public string Email { get; set; }

        [DeserializeAs(Name = "tenant-id")]
        public string TenantId { get; set; }

        public bool IsDefault { get; set; }

        public bool Syncing { get; set; }

        public string LastTimelineId { get; set; }

        public string Status { get; set; }

        public string Role { get; set; }

        public bool IsGuest()
        {
            return Role == ROLE_GUEST;
        }

        public bool IsBlocked()
        {
            return Status == UserStatus.BLOCKED;
        }

        public bool IsDeleted()
        {
            return Status == UserStatus.DELETED;
        }

        public bool IsLogout()
        {
            return Status == UserStatus.LOGOUT;
        }
    }

    public sealed class UserStatus
    {
        public const string ACTIVE = "active";

        public const string BLOCKED = "blocked";

        public const string DELETED = "deleted";

        public const string LOGOUT = "logout";
    }
}
