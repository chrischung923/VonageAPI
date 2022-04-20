using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsErpSearchLog
    {
        public uint Id { get; set; }
        public string Email { get; set; }
        public string Ip { get; set; }
        public string Filters { get; set; }
        public string FiltersMd5 { get; set; }
        public bool? Result { get; set; }
        public string ResultNo { get; set; }
        public DateTime Datetime { get; set; }
    }
}
