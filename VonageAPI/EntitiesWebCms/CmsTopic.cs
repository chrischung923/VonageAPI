using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsTopic
    {
        public uint Id { get; set; }
        public string Title { get; set; }
        public uint Banner { get; set; }
        public string Content { get; set; }
        public string Filter { get; set; }
        public string FilterExclude { get; set; }
        public string LiveUpdate { get; set; }
        public string Privacy { get; set; }
        public string ShareBranches { get; set; }
        public sbyte ShareModify { get; set; }
        public string OrderBy { get; set; }
        public string Creator { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
