using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsFirsthand
    {
        public uint Id { get; set; }
        public string NameTc { get; set; }
        public string NameSc { get; set; }
        public string NameEn { get; set; }
        public string Region { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Developer { get; set; }
        public string Url { get; set; }
        public string YoutubeId { get; set; }
        public uint? Image { get; set; }
        public uint? ImageHomefan { get; set; }
        public string Attachment { get; set; }
        public DateTime? PublishDate { get; set; }
        public byte Priority { get; set; }
        public string Status { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public string RefSource { get; set; }
        public uint? RefSourceId { get; set; }
    }
}
