using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsCnFirsthand
    {
        public uint Id { get; set; }
        public string Type { get; set; }
        public string NameTc { get; set; }
        public string NameSc { get; set; }
        public string NameEn { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string StockNo { get; set; }
        public string AddressTc { get; set; }
        public string AddressSc { get; set; }
        public string AddressEn { get; set; }
        public string DescriptionTc { get; set; }
        public string DescriptionSc { get; set; }
        public string DescriptionEn { get; set; }
        public string DeveloperTc { get; set; }
        public string DeveloperSc { get; set; }
        public string DeveloperEn { get; set; }
        public string ManagementTc { get; set; }
        public string ManagementSc { get; set; }
        public string ManagementEn { get; set; }
        public string ManagementFee { get; set; }
        public string PriceAverage { get; set; }
        public decimal? PriceTotal { get; set; }
        public string UsageType { get; set; }
        public string Bedroom { get; set; }
        public string Bathroom { get; set; }
        public string DateStartTc { get; set; }
        public string DateStartSc { get; set; }
        public string DateStartEn { get; set; }
        public string DateDeliveryTc { get; set; }
        public string DateDeliverySc { get; set; }
        public string DateDeliveryEn { get; set; }
        public string DecorationTc { get; set; }
        public string DecorationSc { get; set; }
        public string DecorationEn { get; set; }
        public string AreaTc { get; set; }
        public string AreaSc { get; set; }
        public string AreaEn { get; set; }
        public string SellingPointTc { get; set; }
        public string SellingPointSc { get; set; }
        public string SellingPointEn { get; set; }
        public string FacilitiesTc { get; set; }
        public string FacilitiesSc { get; set; }
        public string FacilitiesEn { get; set; }
        public string TenureTc { get; set; }
        public string TenureSc { get; set; }
        public string TenureEn { get; set; }
        public string GroundRentTc { get; set; }
        public string GroundRentSc { get; set; }
        public string GroundRentEn { get; set; }
        public string TermsTc { get; set; }
        public string TermsSc { get; set; }
        public string TermsEn { get; set; }
        public string BuildingsTotal { get; set; }
        public string FloorsTotal { get; set; }
        public string CarparksTotal { get; set; }
        public string TransportTc { get; set; }
        public string TransportSc { get; set; }
        public string TransportEn { get; set; }
        public string FeatureTags { get; set; }
        public uint? Cover { get; set; }
        public string Photos { get; set; }
        public string Floorplans { get; set; }
        public string VideoUrls { get; set; }
        public string Attachments { get; set; }
        public decimal? MapLat { get; set; }
        public decimal? MapLon { get; set; }
        public byte? MapZoom { get; set; }
        public byte? Top { get; set; }
        public int? Priority { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
