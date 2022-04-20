using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsIntlSubscriber
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Ip { get; set; }
        public string UtmData { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
