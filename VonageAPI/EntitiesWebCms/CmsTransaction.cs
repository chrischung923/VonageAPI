using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsTransaction
    {
        public uint Id { get; set; }
        public string BuildingTc { get; set; }
        public string BuildingEn { get; set; }
        public string BuildingSc { get; set; }
        public string District { get; set; }
        public string DistrictGroup { get; set; }
        public ulong Price { get; set; }
        public string Type { get; set; }
        public string EstateType { get; set; }
        public byte? PremiumPaid { get; set; }
        public string Floor { get; set; }
        public byte? FloorNum { get; set; }
        public string Unit { get; set; }
        public uint? GrossArea { get; set; }
        public uint? SaleableArea { get; set; }
        public uint? GrossPrice { get; set; }
        public uint? SaleablePrice { get; set; }
        public uint? YearBuilt { get; set; }
        public DateTime? Date { get; set; }
        public uint? SkDistrict { get; set; }
        public byte? SkVillage { get; set; }
        public string Remark { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string Mls2By { get; set; }
        public string RefSource { get; set; }
        public string RefSourceId { get; set; }
    }
}
