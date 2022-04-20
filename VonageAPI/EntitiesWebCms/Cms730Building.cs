using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class Cms730Building
    {
        public ulong Id { get; set; }
        public string NameTc { get; set; }
        public string NameEn { get; set; }
        public string AddressTc { get; set; }
        public string AddressEn { get; set; }
        public string DistrictCode { get; set; }
        public string DistrictName { get; set; }
    }
}
