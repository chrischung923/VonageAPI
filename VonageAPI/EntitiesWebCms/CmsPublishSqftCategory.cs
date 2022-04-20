using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsPublishSqftCategory
    {
        public CmsPublishSqftCategory()
        {
            InverseParentCat = new HashSet<CmsPublishSqftCategory>();
        }

        public uint Id { get; set; }
        public string Name { get; set; }
        public string NameEng { get; set; }
        public string Type { get; set; }
        public string Addr { get; set; }
        public string AddrEng { get; set; }
        public uint? ParentCatId { get; set; }

        public virtual CmsPublishSqftCategory ParentCat { get; set; }
        public virtual ICollection<CmsPublishSqftCategory> InverseParentCat { get; set; }
    }
}
