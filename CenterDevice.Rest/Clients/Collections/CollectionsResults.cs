using CenterDevice.Model.Collection;
using CenterDevice.Rest.Clients.Common;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.Collections
{
    public class CollectionsResults
    {
        public List<Collection> Collections { get; set; }
    }

    public class Collection : CollectionBaseData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public bool Public { get; set; }
        [DeserializeAs(Name = RestApiConstants.FILTER_PARAMS)]
        public object filter_params { get; set; }
        public Sharings Users { get; set; }
        public Sharings Groups { get; set; }
        public bool Auditing { get; set; }
        [DeserializeAs(Name = RestApiConstants.NEED_TO_OPT_IN)]
        public bool NeedToOptIn { get; set; }
        [DeserializeAs(Name = RestApiConstants.HAS_FOLDERS)]
        public bool HasFolders { get; set; }
        [DeserializeAs(Name = RestApiConstants.ARCHIVED_DATE)]
        public DateTime? ArchivedDate { get; set; }

        public bool Shared
        {
            get
            {
                return Public || HasLink || (Users != null && Users.HasSharing) || (Groups != null && Groups.HasSharing);
            }
        }

        public bool IsIntelligent
        {
            get
            {
                return filter_params != null;
            }
        }

        public bool HasLink
        {
            get
            {
                return Link != null;
            }
        }

        public bool Archived => ArchivedDate != null;
    }
}
