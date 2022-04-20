using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VonageAPI.EntitiesWebCms
{
    public partial class CmsNotificationMatch
    {
        public string Email { get; set; }
        public string RegistrationId { get; set; }
        public string Device { get; set; }
        public DateTime Created { get; set; }
    }
}
