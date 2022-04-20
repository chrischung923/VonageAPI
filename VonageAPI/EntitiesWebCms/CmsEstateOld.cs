using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsEstateOld
    {
        public uint Id { get; set; }
        public string NameTc { get; set; }
        public string NameEn { get; set; }
        public string NameSc { get; set; }
        public string AddressTc { get; set; }
        public string AddressEn { get; set; }
        public string AddressSc { get; set; }
        public string District { get; set; }
        public string DistrictGeneral { get; set; }
        public uint DistrictGohome { get; set; }
        public uint District28hse { get; set; }
        public decimal MapLat { get; set; }
        public decimal MapLon { get; set; }
        public byte MapZoom { get; set; }
        public string Photos { get; set; }
        public string FloorPlans { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public uint? IdGohome { get; set; }
        public string Source { get; set; }
        public uint RefSourceId { get; set; }
        public string RefSourcePath { get; set; }
        public string Developer { get; set; }
        public string BlockTotal { get; set; }
        public string UnitTotal { get; set; }
        public string SchoolNet { get; set; }
        public string Facility { get; set; }
        public DateTime? OccupationDate { get; set; }
        public byte Featured { get; set; }
    }
}
