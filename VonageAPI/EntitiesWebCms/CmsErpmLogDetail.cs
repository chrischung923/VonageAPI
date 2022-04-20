using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsErpmLogDetail
    {
        public ulong Id { get; set; }
        public string Email { get; set; }
        public string Ip { get; set; }
        public string UserAgent { get; set; }
        public string StockNo { get; set; }
        public DateTime Datetime { get; set; }
    }
}
