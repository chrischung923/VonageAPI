using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsYahooKeyword
    {
        public uint Id { get; set; }
        public string DisplayZh { get; set; }
        public string DisplayCn { get; set; }
        public string DisplayEn { get; set; }
        public string FileImg { get; set; }
        public uint? Weight { get; set; }
        public int? QtyShown { get; set; }
        public int? QtySelected { get; set; }
    }
}
