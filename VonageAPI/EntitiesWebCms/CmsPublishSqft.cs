using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsPublishSqft
    {
        public string StockNo { get; set; }
        public uint AgentId { get; set; }
        public string Grade { get; set; }
        public DateTime Datetime { get; set; }
    }
}
