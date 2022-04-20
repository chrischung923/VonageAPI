using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsAdvertisement
    {
        public uint Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string UtmSource { get; set; }
        public string UtmCampaign { get; set; }
        public string UtmMedium { get; set; }
        public string UtmContent { get; set; }
        public string Remark { get; set; }
        public string Status { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Created { get; set; }
    }
}
