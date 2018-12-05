using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPCore_Final.Models;

namespace ASPCore_Final.Controllers
{
    public class ChangePasswordController : Controller
    {
        private readonly ESHOPContext db;
        public ChangePasswordController(ESHOPContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Change(ChangePassword model)
        {
            if (ModelState.IsValid)
            {
                KhachHang kh = HttpContext.Session.Get<KhachHang>("user");
                if (model.MatKhauMoi != model.XacNhanMatKhauMoi)
                {
                    ModelState.AddModelError("Lỗi", "Mật khẩu xác nhận không khớp");
                    return View("Index");
                }
                else
                {
                    kh.MatKhau = Encryptor.MD5Hash(model.MatKhauMoi);
                    db.Update(kh);
                    db.SaveChangesAsync();
                    HttpContext.Session.Remove("user");
                    if (HttpContext.Session.Get<string>("mess") != null)
                        HttpContext.Session.Remove("mess");
                    return RedirectToAction("Index", "Login");
                }
            }
            return View("Index");
        }
    }
}