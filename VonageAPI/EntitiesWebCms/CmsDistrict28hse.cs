using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsDistrict28hse
    {
        public uint Id { get; set; }
        public uint? Area { get; set; }
        public string NameTc { get; set; }
        public string NameEn { get; set; }
        public string NameSc { get; set; }
        public uint Priority { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string RefId { get; set; }
        public string RefPath { get; set; }
    }
}
