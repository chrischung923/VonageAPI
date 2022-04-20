using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsWebConversion
    {
        public uint Id { get; set; }
        public string Type { get; set; }
        public uint? UrlId { get; set; }
        public string UrlCode { get; set; }
        public string Tel { get; set; }
        public string AgentName { get; set; }
        public uint? AgentId { get; set; }
        public uint? BranchId { get; set; }
        public string Referer { get; set; }
        public string Redirect { get; set; }
        public string StockNo { get; set; }
        public string Ip { get; set; }
        public string Platform { get; set; }
        public string Campaign { get; set; }
        public string CampaignReferer { get; set; }
        public string UtmCampaign { get; set; }
        public string UtmSource { get; set; }
        public string UtmMedium { get; set; }
        public DateTime Created { get; set; }
    }
}
