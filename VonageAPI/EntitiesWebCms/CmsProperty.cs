using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsProperty
    {
        public uint Id { get; set; }
        public string StockNo { get; set; }
        public string MlsRefno { get; set; }
        public uint CompanyId { get; set; }
        public string NameTc { get; set; }
        public string NameEn { get; set; }
        public string NameSc { get; set; }
        public string DescriptionTc { get; set; }
        public string DescriptionEn { get; set; }
        public string DescriptionSc { get; set; }
        public string AddressTc { get; set; }
        public string AddressSc { get; set; }
        public string AddressEn { get; set; }
        public string BuildingTc { get; set; }
        public string BuildingSc { get; set; }
        public string BuildingEn { get; set; }
        public string BuildingOriginalTc { get; set; }
        public string BuildingOriginalSc { get; set; }
        public string BuildingOriginalEn { get; set; }
        public string Phase { get; set; }
        public string Block { get; set; }
        public string Floor { get; set; }
        public string Unit { get; set; }
        public uint? AgentId { get; set; }
        public uint? AgentId2 { get; set; }
        public string ContactPerson { get; set; }
        public string ContactTel { get; set; }
        public uint? EstateId { get; set; }
        public string District { get; set; }
        public string Photos { get; set; }
        public string Photos360 { get; set; }
        public uint? Photos360Agent { get; set; }
        public uint? SaleableArea { get; set; }
        public uint? GrossArea { get; set; }
        public decimal? PriceSale { get; set; }
        public decimal? PriceHos { get; set; }
        public uint? PriceRent { get; set; }
        public uint? Bedrooms { get; set; }
        public uint? Bathrooms { get; set; }
        public uint? Ensuites { get; set; }
        public byte? PropertyType { get; set; }
        public string PropertyUsage { get; set; }
        public byte? FlatType { get; set; }
        public byte? FloorLevel { get; set; }
        public byte? Direction { get; set; }
        public decimal? MapLat { get; set; }
        public decimal? MapLon { get; set; }
        public byte? MapZoom { get; set; }
        public string ViewTags { get; set; }
        public string FacilityTags { get; set; }
        public string FeatureTags { get; set; }
        public string HitTags { get; set; }
        public string SkTags { get; set; }
        public string _28happyTags { get; set; }
        public uint? SkDistrict { get; set; }
        public byte? SoleAgency { get; set; }
        public byte? WithTenancy { get; set; }
        public string VideoVr { get; set; }
        public string MewmeVr { get; set; }
        public string Url360 { get; set; }
        public uint? Url360Agent { get; set; }
        public string UrlVr { get; set; }
        public uint? VrThumb { get; set; }
        public uint? VrAgent { get; set; }
        public string UrlVideo { get; set; }
        public uint? UrlVideoThumb { get; set; }
        public uint? UrlVideoAgent { get; set; }
        public uint? CombinedFid { get; set; }
        public byte? OverrideRules { get; set; }
        public ulong? ViewCount { get; set; }
        public ulong? ViewCountCookie { get; set; }
        public string Status { get; set; }
        public string Mls2Status { get; set; }
        public DateTime? Mls2StatusTime { get; set; }
        public DateTime? InputDate { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string LogicErrors { get; set; }
        public string Mls2Eaa { get; set; }
        public DateTime? Mls2EaaExpiry { get; set; }
        public string Mls2AgmtVend { get; set; }
        public DateTime? Mls2DateExpiry { get; set; }
        public string Mls2AgmtRent { get; set; }
        public DateTime? Mls2DateExpiryRent { get; set; }
        public uint? Mls2BuildingId { get; set; }
        public string RefSource { get; set; }
        public uint? RefSourceId { get; set; }
        public string RefSourcePhotos { get; set; }
        public string MlsAgtcode { get; set; }
        public string Mls2InstanceId { get; set; }
        public sbyte SkipPublish { get; set; }
    }
}
