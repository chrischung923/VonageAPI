using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsBanner
    {
        public uint Id { get; set; }
        public string Type { get; set; }
        public string TitleTc { get; set; }
        public string TitleSc { get; set; }
        public string TitleEn { get; set; }
        public ulong Image { get; set; }
        public string Url { get; set; }
        public string Target { get; set; }
        public int Priority { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
