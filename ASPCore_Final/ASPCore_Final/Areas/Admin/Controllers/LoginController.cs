using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCore_Final.Areas.Admin.Models;
using ASPCore_Final.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPCore_Final.Areas.Admin.Controllers
{
    [Area("admin")]
    public class LoginController : Controller
    {
        private readonly ESHOPContext db;
        public LoginController(ESHOPContext context)
        {
            db = context;
        }
        [HttpGet("/admin/Login")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                NhanVien nv = db.NhanVien.SingleOrDefault(p => p.Email == loginModel.Email && p.MatKhau == Encryptor.MD5Hash(loginModel.matKhau));
                if(nv.TrangThaiHd == true)
                {
                    if (nv == null)
                    {
                        ModelState.AddModelError("loi", "Sai email hoặc password");
                    }
                    //  HttpContext.Session.SetString("email", nv.Email);
                    else
                    {
                        HttpContext.Session.Set("email", nv);
                        return LocalRedirect("/admin");
                    }
                }

                else
                {
                    ModelState.AddModelError("loi", "Tài khoản của bạn đã bị khóa");
                }

                
               //return RedirectToAction("Index", "Home", routeValues: new { areas = "Admin" });
            }
            return View("Index");
        }
        public IActionResult Logout()
        {
            //xóa session
            HttpContext.Session.Remove("email");
            return LocalRedirect("/admin");
        }
    }
}