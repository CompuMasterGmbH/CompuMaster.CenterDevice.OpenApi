﻿using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.Tenant
{
    public class TenantSettings
    {
        public SettingsValue Unarchiving { get; set; }
    }

    public class SettingsValue
    {
        public UsersAndRoles Value { get; set; }
        public bool Enabled { get; set; }
    }

    public class UsersAndRoles
    {
        public List<string> Roles { get; set; }
        public List<string> Users { get; set; }
    }
}
