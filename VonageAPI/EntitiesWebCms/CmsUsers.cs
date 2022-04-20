using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsUsers
    {
        public uint Uid { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Gmail { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public uint CompanyId { get; set; }
        public string Branches { get; set; }
        public string Salt { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
