using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsAgentAward
    {
        public uint Id { get; set; }
        public uint AgentId { get; set; }
        public string Year { get; set; }
        public string Type { get; set; }
        public string Icon { get; set; }
        public string TitleTc { get; set; }
        public string TitleEn { get; set; }
        public string TitleSc { get; set; }
        public ushort Count { get; set; }
        public uint? AwardArticleId { get; set; }
        public uint Priority { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
