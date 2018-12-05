using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASPCore_Final.Areas.Admin.Controllers
{
    [Area("admin")]
    public class HomeController : CheckLoginController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}