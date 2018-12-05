using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCore_Final.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCore_Final.Controllers
{
    public class ActivateController : Controller
    {
        private readonly ESHOPContext db;
        public ActivateController(ESHOPContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Activate()
        {
            KhachHang k = HttpContext.Session.Get<KhachHang>("kh");
            if (k != null)
            {
                k.TrangThaiHd = true;
                db.Update(k);
                db.SaveChangesAsync();
                HttpContext.Session.Remove("kh");
                return RedirectToAction("Index", "Login");
            }
            else
            {
                ModelState.AddModelError("Lỗi", "Không tìm thấy tài khoản");
            }
            return View();
        }
    }
}