using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsIntlBrochureUser
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string InterestCountry { get; set; }
        public uint ProjectId { get; set; }
        public uint FileId { get; set; }
        public string Ip { get; set; }
        public string AgentString { get; set; }
        public string UtmData { get; set; }
        public byte Subscribe { get; set; }
        public DateTime Created { get; set; }
    }
}
