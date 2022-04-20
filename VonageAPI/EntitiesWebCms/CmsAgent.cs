using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsAgent
    {
        public uint Id { get; set; }
        public string Code { get; set; }
        public uint CompanyId { get; set; }
        public uint BranchId { get; set; }
        public string NameTc { get; set; }
        public string NameSc { get; set; }
        public string NameEn { get; set; }
        public string DisplayName { get; set; }
        public string Tel { get; set; }
        public string TelCn { get; set; }
        public string Email { get; set; }
        public string LicenseNo { get; set; }
        public uint? Avatar { get; set; }
        public string Role { get; set; }
        public string Gender { get; set; }
        public decimal? Score { get; set; }
        public uint? ScoreTimes { get; set; }
        public uint? UpManager { get; set; }
        public uint? UpDmanager { get; set; }
        public uint? UpDirector { get; set; }
        public string Awards { get; set; }
        public string Languages { get; set; }
        public string LabelTc { get; set; }
        public string LabelSc { get; set; }
        public string LabelEn { get; set; }
        public ulong? ViewCount { get; set; }
        public uint? PropertyTotal { get; set; }
        public string SalesleadTags { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string RefSource { get; set; }
        public string RefSourceId { get; set; }
    }
}
