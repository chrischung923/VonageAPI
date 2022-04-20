using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsTopicProperties
    {
        public ulong Id { get; set; }
        public uint TopicId { get; set; }
        public string StockNo { get; set; }
        public string Title { get; set; }
        public uint CoverFid { get; set; }
        public byte Score { get; set; }
        public uint Clicks { get; set; }
        public byte Hidden { get; set; }
        public uint Priority { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
