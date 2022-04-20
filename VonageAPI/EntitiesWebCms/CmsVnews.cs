using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsVnews
    {
        public uint Id { get; set; }
        public string FbTitle { get; set; }
        public string FbDesc { get; set; }
        public uint? FbImage { get; set; }
        public string Category { get; set; }
        public string District { get; set; }
        public string TitleTc { get; set; }
        public string TitleEn { get; set; }
        public string TitleSc { get; set; }
        public string SubtitleTc { get; set; }
        public string SubtitleSc { get; set; }
        public string SubtitleEn { get; set; }
        public string VideoUrl { get; set; }
        public long ThumbFid { get; set; }
        public uint Duration { get; set; }
        public string ContentTc { get; set; }
        public string ContentSc { get; set; }
        public string ContentEn { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
