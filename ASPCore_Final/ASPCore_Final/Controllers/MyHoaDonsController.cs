using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCore_Final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;

namespace ASPCore_Final.Controllers
{
    public class MyHoaDonsController : Controller
    {
        private readonly ESHOPContext db;
        public MyHoaDonsController(ESHOPContext ctx)
        {
            db = ctx;
        }
        public async Task<IActionResult> Index(int page = 1, string sortExpression = "MaHd")
        {

            if (HttpContext.Session.Get<KhachHang>("user") != null)
            {
                KhachHang kh = HttpContext.Session.Get<KhachHang>("user");
                var eSHOPContext = db.HoaDon.Where(p => p.MaKh == kh.MaKh).OrderByDescending(p=>p.NgayDat).AsNoTracking().AsQueryable();
                var model = await PagingList.CreateAsync(eSHOPContext, 5, page, sortExpression, "MaHd");
                return View(model);
            }
            else
            {
                var eSHOPContexts = db.HoaDon.Where(p => p.MaKh == 0).AsNoTracking().AsQueryable();
                var models = await PagingList.CreateAsync(eSHOPContexts, 5, page, sortExpression, "MaHd");
                return View(models);
            }
        }

        public IActionResult HuyHoaDon(int mahd)
        {
            // xóa các chi tiết hóa đơn liên quan
            List<ChiTietHd> listCT_Xoa = db.ChiTietHd.Where(p => p.MaHd == mahd).ToList();
            foreach (var item in listCT_Xoa)
            {
                SanPhamKho spk = db.SanPhamKho.SingleOrDefault(p => p.MaHh == item.MaHh && p.KichCo == item.KichCo);
                spk.SoLuong += item.SoLuong;
                db.ChiTietHd.Remove(item);
            }
            db.SaveChanges();
            // xóa hóa đơn
            HoaDon hd = db.HoaDon.Find(mahd);
            db.HoaDon.Remove(hd);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult XoaCTHD(int mact)
        {
            ChiTietHd ct = db.ChiTietHd.Find(mact);
            SanPhamKho spk = db.SanPhamKho.SingleOrDefault(p => p.MaHh == ct.MaHh && p.KichCo == ct.KichCo);
            if(spk!= null)
            {
                spk.SoLuong += ct.SoLuong;
                db.ChiTietHd.Remove(ct);
            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}