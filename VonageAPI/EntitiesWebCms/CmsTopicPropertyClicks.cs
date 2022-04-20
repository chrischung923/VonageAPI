using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsTopicPropertyClicks
    {
        public ulong Id { get; set; }
        public uint? TopicId { get; set; }
        public string Template { get; set; }
        public string ClientIp { get; set; }
        public string ClientAgent { get; set; }
        public string ClientReferrer { get; set; }
        public string ClientPlatform { get; set; }
        public byte IsMobile { get; set; }
        public string StockNo { get; set; }
        public string CompaignReferrer { get; set; }
        public DateTime Created { get; set; }
    }
}
