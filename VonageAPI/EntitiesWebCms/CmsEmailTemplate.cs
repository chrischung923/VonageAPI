using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsEmailTemplate
    {
        public uint Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Mailtype { get; set; }
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
        public string SenderPass { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }
        public int Created { get; set; }
        public int Updated { get; set; }
    }
}
