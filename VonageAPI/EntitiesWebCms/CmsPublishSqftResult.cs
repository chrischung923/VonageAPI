using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsPublishSqftResult
    {
        public ulong Id { get; set; }
        public string StockNo { get; set; }
        public string Type { get; set; }
        public int? AdId { get; set; }
        public string AdUrl { get; set; }
        public string Content { get; set; }
        public string AdStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? PublishedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? ExpiredAt { get; set; }
        public string Grade { get; set; }
        public string PublishStatus { get; set; }
        public string PublishError { get; set; }
    }
}
