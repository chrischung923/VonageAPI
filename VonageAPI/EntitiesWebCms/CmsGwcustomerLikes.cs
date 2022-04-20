using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsGwcustomerLikes
    {
        public uint Id { get; set; }
        public DateTime Date { get; set; }
        public string Customer { get; set; }
        public string Content { get; set; }
        public string Agents { get; set; }
        public string AgentsName { get; set; }
        public string Photos { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
