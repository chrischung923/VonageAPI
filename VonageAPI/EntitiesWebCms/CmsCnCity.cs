using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsCnCity
    {
        public uint Id { get; set; }
        public string Code { get; set; }
        public string Country { get; set; }
        public string NameTc { get; set; }
        public string NameSc { get; set; }
        public string NameEn { get; set; }
        public string MetaTitleTc { get; set; }
        public string MetaTitleSc { get; set; }
        public string MetaTitleEn { get; set; }
        public string MetaDescTc { get; set; }
        public string MetaDescSc { get; set; }
        public string MetaDescEn { get; set; }
        public string PageDescTc { get; set; }
        public string PageDescSc { get; set; }
        public string PageDescEn { get; set; }
        public string PageDescMoreTc { get; set; }
        public string PageDescMoreSc { get; set; }
        public string PageDescMoreEn { get; set; }
        public string Status { get; set; }
        public uint Priority { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
