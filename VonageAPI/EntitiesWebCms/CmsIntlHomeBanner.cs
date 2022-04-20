using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsIntlHomeBanner
    {
        public uint Id { get; set; }
        public uint PropertyId { get; set; }
        public uint ImageDesktop { get; set; }
        public uint ImageMobile { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public int Priority { get; set; }
        public string Status { get; set; }
    }
}
