using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsErpTransaction
    {
        public uint Id { get; set; }
        public string BuildingTc { get; set; }
        public string BuildingEn { get; set; }
        public string BuildingSc { get; set; }
        public string StreetTc { get; set; }
        public string StreetSc { get; set; }
        public string StreetEn { get; set; }
        public string District { get; set; }
        public string DocumentNature { get; set; }
        public ulong Price { get; set; }
        public string Usage { get; set; }
        public string Floor { get; set; }
        public string Unit { get; set; }
        public uint? GrossArea { get; set; }
        public uint? SaleableArea { get; set; }
        public uint? GrossPrice { get; set; }
        public uint? SaleablePrice { get; set; }
        public string YearBuilt { get; set; }
        public string YearExpire { get; set; }
        public DateTime? RegDate { get; set; }
        public DateTime? DocumentDate { get; set; }
        public string Facing { get; set; }
        public string Layout { get; set; }
        public string MemoNo { get; set; }
        public string Remark { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Mls2By { get; set; }
        public string RefSource { get; set; }
        public string RefSourceId { get; set; }
    }
}
