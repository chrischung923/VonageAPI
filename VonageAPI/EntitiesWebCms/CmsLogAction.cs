using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsLogAction
    {
        public uint Id { get; set; }
        public string Model { get; set; }
        public string Action { get; set; }
        public string DataOld { get; set; }
        public string DataNew { get; set; }
        public string DataId { get; set; }
        public string User { get; set; }
        public string Ip { get; set; }
        public DateTime Created { get; set; }
    }
}
