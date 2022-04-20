using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsUrl
    {
        public ulong Id { get; set; }
        public string Title { get; set; }
        public string Source { get; set; }
        public string OtherSource { get; set; }
        public string Campaign { get; set; }
        public uint? CampaignId { get; set; }
        public string UtmMedium { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public string Destination { get; set; }
        public string Message { get; set; }
        public string ShortKey { get; set; }
        public string PostUrl { get; set; }
        public uint? UserEmail { get; set; }
        public string AgentEmail { get; set; }
        public uint? BranchId { get; set; }
        public string StockNo { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
