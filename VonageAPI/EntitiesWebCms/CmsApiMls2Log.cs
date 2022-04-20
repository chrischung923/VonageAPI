using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsApiMls2Log
    {
        public ulong Id { get; set; }
        public string StockNo { get; set; }
        public string Action { get; set; }
        public byte Result { get; set; }
        public string Data { get; set; }
        public DateTime Created { get; set; }
    }
}
