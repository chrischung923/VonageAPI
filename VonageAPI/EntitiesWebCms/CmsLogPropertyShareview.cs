using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsLogPropertyShareview
    {
        public uint Id { get; set; }
        public string StockNo { get; set; }
        public uint AgentId { get; set; }
        public string Agent { get; set; }
        public string Party { get; set; }
        public string Ip { get; set; }
        public string Lang { get; set; }
        public string Url { get; set; }
        public DateTime Datetime { get; set; }
    }
}
