using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsGwPropertyFavourite
    {
        public ulong Id { get; set; }
        public string MemberId { get; set; }
        public string StockNo { get; set; }
        public DateTime Created { get; set; }
    }
}
