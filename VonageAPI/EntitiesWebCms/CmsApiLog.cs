using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsApiLog
    {
        public uint Id { get; set; }
        public string Party { get; set; }
        public string Entity { get; set; }
        public string Action { get; set; }
        public string Parameters { get; set; }
        public string Ip { get; set; }
        public byte Result { get; set; }
        public string Remark { get; set; }
        public DateTime Created { get; set; }
    }
}
