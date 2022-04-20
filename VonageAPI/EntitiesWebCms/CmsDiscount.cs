using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsDiscount
    {
        public uint Id { get; set; }
        public DateTime? Date { get; set; }
        public string Title { get; set; }
        public uint? Logo { get; set; }
        public string Description { get; set; }
        public string Detail { get; set; }
        public int DetailImage { get; set; }
        public string MerchantTel { get; set; }
        public string MerchantUrl { get; set; }
        public string MerchantEmail { get; set; }
        public string Remark { get; set; }
        public string ExtraBtnTitle { get; set; }
        public string ExtraBtnUrl { get; set; }
        public string RemarkBtnTitle { get; set; }
        public string Status { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public string RefSource { get; set; }
        public int? RefSourceId { get; set; }
    }
}
