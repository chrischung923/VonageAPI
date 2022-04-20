using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsVideoUrl
    {
        public uint Id { get; set; }
        public string Url { get; set; }
        public uint? ThumbFid { get; set; }
        public string Entity { get; set; }
        public uint EntityId { get; set; }
        public uint Priority { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
