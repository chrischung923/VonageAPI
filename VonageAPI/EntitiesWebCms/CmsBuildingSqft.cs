using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsBuildingSqft
    {
        public uint Id { get; set; }
        public string DistrictTc { get; set; }
        public string DistrictSc { get; set; }
        public string DistrictEn { get; set; }
        public string DistrictCode { get; set; }
        public string Phase { get; set; }
        public string Estate { get; set; }
        public string Block { get; set; }
        public string BuildingName { get; set; }
        public string Name { get; set; }
        public string NameTc { get; set; }
        public string NameSc { get; set; }
        public string NameEn { get; set; }
        public string AddressTc { get; set; }
        public string AddressSc { get; set; }
        public string AddressEn { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
