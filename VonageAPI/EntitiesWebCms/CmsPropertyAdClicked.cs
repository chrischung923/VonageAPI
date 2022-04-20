using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsPropertyAdClicked
    {
        public ulong Id { get; set; }
        public string StockNo { get; set; }
        public string Campaign { get; set; }
        public string CampaignReferer { get; set; }
        public string Ip { get; set; }
        public string Platform { get; set; }
        public string RefererUrl { get; set; }
        public DateTime Created { get; set; }
    }
}
