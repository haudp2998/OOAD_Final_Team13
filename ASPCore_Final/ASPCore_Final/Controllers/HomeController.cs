using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPCore_Final.Models;

namespace ASPCore_Final.Controllers
{
    public class HomeController : Controller
    {
        private readonly ESHOPContext db;
        public HomeController(ESHOPContext ctx)
        {
            db = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(string cauhoi)
        {
            if (HttpContext.Session.Get<KhachHang>("user") != null)
            {
                HoiDap hd = new HoiDap
                {
                    CauHoi = cauhoi,
                    NgayDua = DateTime.Now,
                    MaKh = HttpContext.Session.Get<KhachHang>("user").MaKh
                };
                db.HoiDap.Add(hd);
                db.SaveChanges();
                ViewData["MessContact"] = "Thông tin phản hồi của bạn đã gửi đi thành công.";
            }
            else {
                ViewData["MessContact"] = "Vui lòng đăng nhập để gửi phản hồi";
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
