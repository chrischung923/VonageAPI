using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsPublish28hse
    {
        public string StockNo { get; set; }
        public string AgentEmail { get; set; }
        public uint? AgentId { get; set; }
        public bool GoldTop { get; set; }
        public bool Top { get; set; }
        public byte Normal { get; set; }
        public byte Rerank { get; set; }
        public ulong Seq { get; set; }
        public DateTime? TopDatetime { get; set; }
        public DateTime? NormalDatetime { get; set; }
        public DateTime? SetDatetime { get; set; }
    }
}
