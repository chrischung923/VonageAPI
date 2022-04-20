using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsIntlContact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Company { get; set; }
        public string Message { get; set; }
        public string KnownFrom { get; set; }
        public string Ip { get; set; }
        public string AgentString { get; set; }
        public string UtmData { get; set; }
        public byte NotificationEmailSent { get; set; }
        public string FromSite { get; set; }
        public DateTime Created { get; set; }
    }
}
