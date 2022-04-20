using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsLineReply
    {
        public uint Id { get; set; }
        public uint LogId { get; set; }
        public string ReplyTo { get; set; }
        public string Content { get; set; }
        public string Result { get; set; }
        public DateTime Created { get; set; }
    }
}
