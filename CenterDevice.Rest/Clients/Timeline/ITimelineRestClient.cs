using System;
using System.Collections.Generic;

namespace CenterDevice.Rest.Clients.Timeline
{
    public interface ITimelineRestClient
    {
        int MaxRows { get; }

        TimelineSearchResults Scroll(string userId, string previousId, List<string> types, int rows = 500);

        TimelineSearchResults GetTimelineEvents(string userId, DateTime startDate, int offset, int rows, List<string> types);
    }
}
