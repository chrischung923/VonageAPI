using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsIntlAgent
    {
        public int Id { get; set; }
        public string NameTc { get; set; }
        public string NameSc { get; set; }
        public string NameEn { get; set; }
        public string Title { get; set; }
        public ulong? Avatar { get; set; }
        public ulong? Image { get; set; }
        public uint? Signature { get; set; }
        public string UrlLinkedin { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Slug { get; set; }
        public string Projects { get; set; }
        public string WorksTc { get; set; }
        public string WorksSc { get; set; }
        public string WorksEn { get; set; }
        public string DescriptionTc { get; set; }
        public string DescriptionSc { get; set; }
        public string DescriptionEn { get; set; }
        public int? Priority { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
