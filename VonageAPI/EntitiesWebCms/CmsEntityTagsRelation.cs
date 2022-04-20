using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsEntityTagsRelation
    {
        public string Entity { get; set; }
        public ulong EntityId { get; set; }
        public ulong TagId { get; set; }
        public uint Priority { get; set; }
    }
}
