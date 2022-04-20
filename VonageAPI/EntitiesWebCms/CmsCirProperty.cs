using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsCirProperty
    {
        public uint Id { get; set; }
        public string StockNo { get; set; }
        public uint RefNo { get; set; }
        public uint CompanyId { get; set; }
        public string Zone { get; set; }
        public string NameTc { get; set; }
        public string NameEn { get; set; }
        public string NameSc { get; set; }
        public string DescriptionTc { get; set; }
        public string DescriptionEn { get; set; }
        public string DescriptionSc { get; set; }
        public string AddressTc { get; set; }
        public string AddressSc { get; set; }
        public string AddressEn { get; set; }
        public ulong? BuildingId { get; set; }
        public string BuildingTc { get; set; }
        public string BuildingEn { get; set; }
        public string BuildingSc { get; set; }
        public string Phase { get; set; }
        public string Block { get; set; }
        public string Floor { get; set; }
        public string Unit { get; set; }
        public uint? AgentId { get; set; }
        public uint? AgentId2 { get; set; }
        public uint? EstateId { get; set; }
        public string EstateTc { get; set; }
        public string EstateSc { get; set; }
        public string EstateEn { get; set; }
        public uint? DistrictId { get; set; }
        public string DistrictTc { get; set; }
        public string DistrictSc { get; set; }
        public string DistrictEn { get; set; }
        public string Photos { get; set; }
        public uint? SaleableArea { get; set; }
        public uint? GrossArea { get; set; }
        public decimal? PriceSale { get; set; }
        public uint? PriceRent { get; set; }
        public string PropertyUsage { get; set; }
        public byte? FloorLevel { get; set; }
        public uint Year { get; set; }
        public decimal AveragePriceSaleable { get; set; }
        public decimal AveragePriceGross { get; set; }
        public decimal AverageRentSaleable { get; set; }
        public decimal AverageRentGross { get; set; }
        public decimal Yield { get; set; }
        public decimal MapLat { get; set; }
        public decimal MapLon { get; set; }
        public byte MapZoom { get; set; }
        public string ViewTags { get; set; }
        public string FacilityTags { get; set; }
        public string FeatureTags { get; set; }
        public string HitTags { get; set; }
        public byte SoleAgency { get; set; }
        public byte WithTenancy { get; set; }
        public byte Recommended { get; set; }
        public ulong ViewCount { get; set; }
        public ulong ViewCountCookie { get; set; }
        public string Status { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string DataRaw { get; set; }
        public string RefDb { get; set; }
    }
}
