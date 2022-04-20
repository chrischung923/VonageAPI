using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsSyncPropertyLog
    {
        public string StockNo { get; set; }
        public string Data { get; set; }
        public string DataHash { get; set; }
        public string Photo { get; set; }
        public string PhotoHash { get; set; }
        public string DataOld { get; set; }
        public string DataHashOld { get; set; }
        public string PhotoOld { get; set; }
        public string PhotoHashOld { get; set; }
        public DateTime Updated { get; set; }
    }
}
