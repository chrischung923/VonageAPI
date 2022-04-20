using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsWhatsappNumber
    {
        public CmsWhatsappNumber()
        {
            CmsBranch = new HashSet<CmsBranch>();
        }

        public uint Id { get; set; }
        public string Number { get; set; }
        public string Url { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ApiEndpoint { get; set; }
        public string ApiToken { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public virtual ICollection<CmsBranch> CmsBranch { get; set; }
    }
}
