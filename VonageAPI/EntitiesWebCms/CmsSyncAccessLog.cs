using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsSyncAccessLog
    {
        public uint Id { get; set; }
        public string Party { get; set; }
        public string Data { get; set; }
        public string Ip { get; set; }
        public byte Result { get; set; }
        public string Error { get; set; }
        public DateTime Created { get; set; }
    }
}
