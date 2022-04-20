using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsFiles
    {
        public uint Id { get; set; }
        public uint? Uid { get; set; }
        public string Username { get; set; }
        public string Title { get; set; }
        public string Filename { get; set; }
        public string Folder { get; set; }
        public string Extension { get; set; }
        public string Mime { get; set; }
        public uint Filesize { get; set; }
        public string Md5 { get; set; }
        public uint? Width { get; set; }
        public uint? Height { get; set; }
        public uint? ThumbFid { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public uint? RefId { get; set; }
        public string RefPath { get; set; }
    }
}
