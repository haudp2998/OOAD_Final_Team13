using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using ASPCore_Final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;

namespace ASPCore_Final.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HoiDapController : Controller
    {
        private readonly ESHOPContext db;
        public HoiDapController(ESHOPContext ctx)
        {
            db = ctx;
        }
        [HttpGet("/admin/HoiDap")]
        public async Task<IActionResult> Index(int page = 1, string sortExpression = "MaHd")
        {
            var eSHOPContext = db.HoiDap.AsNoTracking().AsQueryable();
            var model = await PagingList.CreateAsync(eSHOPContext, 5, page, sortExpression, "MaHd");
            return View(model);
        }
        [HttpGet("/admin/HoiDap/Xem")]
        public IActionResult Xem(int id)
        {
            HoiDap hd = db.HoiDap.Find(id);
            return View(hd);
        }

        [HttpPost]
        public IActionResult Xem(int id,string traloi)
        {
            HoiDap hd = db.HoiDap.Find(id);
            hd.TrangThaiTl = true;
            hd.TraLoi = traloi;
            db.SaveChanges();
            ViewData["reply"] = "Tin nhắn đã được gửi đến khách hàng";
            KhachHang kh = db.KhachHang.SingleOrDefault(p => p.MaKh == hd.MaKh);
            MailMessage mm = new MailMessage("eshoppingmanager@gmail.com", kh.Email);
            mm.Subject = "Thông báo phản hồi";
            string content = "<h1>{0}</h1> <br/> <div class='text text-success'><h2>Chào mừng bạn đến với ESHOP.</h2></div> <br> <h5> Cảm ơn bạn đã phản hồi với lời nhắn : <br/> <br/>";
            content += "<h3 style='font-weight:bolder;color:red;'>" + hd.CauHoi + "</h3><br/><h3>Phản hồi từ ESHOP : </h3><br /><h3 style='color:blue;'>" + hd.TraLoi + "</h3><br />";
            mm.Body = string.Format(content, kh.HoTen);
            mm.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("eshoppingmanager@gmail.com", "eshop147258369");
            smtp.Send(mm);
            return View(hd);
        }
        [HttpGet("/admin/HoiDap/Xoa")]
        public IActionResult Xoa(int id) {
            HoiDap hd = db.HoiDap.Find(id);
            db.HoiDap.Remove(hd);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}