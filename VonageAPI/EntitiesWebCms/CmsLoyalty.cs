using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsLoyalty
    {
        public int Id { get; set; }
        public string No { get; set; }
        public string Name { get; set; }
        public string NameTc { get; set; }
        public string Age { get; set; }
        public string ExpectInfo { get; set; }
        public string Education { get; set; }
        public string LivingArea { get; set; }
        public string District { get; set; }
        public string Phone { get; set; }
        public string Hkid { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public byte? EmailValidated { get; set; }
        public byte? Email2Validated { get; set; }
        public string EmailVcode { get; set; }
        public string Password { get; set; }
        public string Addr { get; set; }
        public string Income { get; set; }
        public string FamilyIncome { get; set; }
        public string TheclubId { get; set; }
        public string Present { get; set; }
        public bool? AcceptAd { get; set; }
        public bool? IsReadPolicy { get; set; }
        public string IsCustomer { get; set; }
        public string CustomerName { get; set; }
        public short? CustomerYear { get; set; }
        public byte? CustomerMonth { get; set; }
        public string Src { get; set; }
        public string Referer { get; set; }
        public string Campain { get; set; }
        public string Agent { get; set; }
        public string Ip { get; set; }
        public DateTime? DateReg { get; set; }
        public DateTime? DateUpdate { get; set; }
        public bool? IsOpened { get; set; }
        public byte GoodwinplusUpdated { get; set; }
        public byte GoodwinplusSent { get; set; }
        public byte EmailInvalid { get; set; }
        public string QtySent { get; set; }
        public string Status { get; set; }
    }
}
