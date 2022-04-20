using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsLoyaltyOwner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool? IsReadPolicy { get; set; }
        public string Referer { get; set; }
        public string Campaign { get; set; }
        public string Agent { get; set; }
        public string Ip { get; set; }
        public byte EmailValidated { get; set; }
        public string EmailVcode { get; set; }
        public sbyte AutoRegister { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public string Status { get; set; }
    }
}
