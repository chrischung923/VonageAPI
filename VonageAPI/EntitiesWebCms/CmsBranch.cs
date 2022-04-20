using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsBranch
    {
        public uint Id { get; set; }
        public uint CompanyId { get; set; }
        public string Type { get; set; }
        public string NameTc { get; set; }
        public string NameEn { get; set; }
        public string NameSc { get; set; }
        public string AddressTc { get; set; }
        public string AddressEn { get; set; }
        public string AddressSc { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string C21Code { get; set; }
        public string District { get; set; }
        public int Priority { get; set; }
        public decimal MapLat { get; set; }
        public decimal MapLon { get; set; }
        public byte MapZoom { get; set; }
        public uint? Manager { get; set; }
        public uint? WhatsappNumber { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public uint RefSourceId { get; set; }

        public virtual CmsWhatsappNumber WhatsappNumberNavigation { get; set; }
    }
}
