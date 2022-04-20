using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsGwHomeLuxury
    {
        public uint Id { get; set; }
        public string StockNo { get; set; }
        public string District { get; set; }
        public uint? Fid { get; set; }
        public uint Priority { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
