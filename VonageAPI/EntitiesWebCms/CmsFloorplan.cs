using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsFloorplan
    {
        public uint Id { get; set; }
        public ulong FileId { get; set; }
        public uint EstateId { get; set; }
        public string Phase { get; set; }
        public string PhaseValues { get; set; }
        public string Block { get; set; }
        public string BlockValues { get; set; }
        public string Floor { get; set; }
        public string FloorValues { get; set; }
        public string Unit { get; set; }
        public string UnitValues { get; set; }
        public uint Priority { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
