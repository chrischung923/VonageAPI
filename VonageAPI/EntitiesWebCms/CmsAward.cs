using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsAward
    {
        public uint Id { get; set; }
        public string Title { get; set; }
        public uint? First { get; set; }
        public string FirstName { get; set; }
        public string FirstBranch { get; set; }
        public string FirstLicenseNo { get; set; }
        public uint? FirstAvatar { get; set; }
        public byte FirstPosition { get; set; }
        public uint? Second { get; set; }
        public string SecondName { get; set; }
        public string SecondBranch { get; set; }
        public string SecondLicenseNo { get; set; }
        public uint? SecondAvatar { get; set; }
        public byte SecondPosition { get; set; }
        public uint? Third { get; set; }
        public string ThirdName { get; set; }
        public string ThirdBranch { get; set; }
        public string ThirdLicenseNo { get; set; }
        public int? ThirdAvatar { get; set; }
        public byte ThirdPosition { get; set; }
        public DateTime? Date { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string RefSource { get; set; }
        public string RefSourceId { get; set; }
    }
}
