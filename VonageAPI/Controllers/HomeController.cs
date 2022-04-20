using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace VonageAPI.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet("Home")]
        public IActionResult Index()
        {
            return View("/Views/Home/Index.cshtml");
        }
    }
}
