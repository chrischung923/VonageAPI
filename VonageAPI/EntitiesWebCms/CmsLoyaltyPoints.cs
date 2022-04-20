using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsLoyaltyPoints
    {
        public uint Id { get; set; }
        public string Email { get; set; }
        public string Action { get; set; }
        public uint Points { get; set; }
        public string Url { get; set; }
        public string StockNo { get; set; }
        public DateTime Created { get; set; }
        public string Remark { get; set; }
    }
}
