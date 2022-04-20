using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsLogLogin
    {
        public uint Id { get; set; }
        public string Email { get; set; }
        public uint Uid { get; set; }
        public string Ip { get; set; }
        public string Browser { get; set; }
        public string Token { get; set; }
        public byte Result { get; set; }
        public DateTime Created { get; set; }
    }
}
