using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VonageAPI.Model
{
    public class inboundCallModel
    { 
        public string from { get; set; }
        public string to { get; set; }
        public string uuid { get; set; }
        public string conversation_uuid { get; set; }
    }
}
