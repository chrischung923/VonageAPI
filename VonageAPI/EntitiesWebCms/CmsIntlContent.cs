using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsIntlContent
    {
        public uint Id { get; set; }
        public string Code { get; set; }
        public string TitleTc { get; set; }
        public string TitleSc { get; set; }
        public string TitleEn { get; set; }
        public string ContentTc { get; set; }
        public string ContentSc { get; set; }
        public string ContentEn { get; set; }
        public string Status { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Created { get; set; }
    }
}
