using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPCore_Final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;

namespace ASPCore_Final.Areas
{
    [Area("Admin")]
    public class PhieuNhapHangController : Controller
    {
        private readonly ESHOPContext db;
        public PhieuNhapHangController(ESHOPContext ctx)
        {
            db = ctx;
        }
        [HttpGet("/admin/PhieuNhapHang")]

        public async Task<IActionResult> Index(int page = 1, string sortExpression = "MaPn")
        {
            var eSHOPContext = db.PhieuNhapHang.AsNoTracking().AsQueryable();
            var model = await PagingList.CreateAsync(eSHOPContext, 5, page, sortExpression, "MaHd");
            return View(model);
        }

        [HttpGet("/admin/PhieuNhapHang/ThemMoi")]
        public IActionResult ThemMoi()
        {
            return View(ListNhaps);
        }

        public List<HangHoaNhap> ListNhaps
        {
            get
            {
                List<HangHoaNhap> mylist = HttpContext.Session.Get<List<HangHoaNhap>>("ListNhap");
                if (mylist == default(List<HangHoaNhap>))
                {
                    mylist = new List<HangHoaNhap>();
                }

                return mylist;
            }
        }


        [HttpGet("/admin/PhieuNhapHang/TimKiem")]
        public IActionResult TimKiem(string keyword)
        {
            List<HangHoa> hh = new List<HangHoa>();
            if (keyword != null)
            {
                hh = db.HangHoa.Where(p => p.TenHh.ToLower().Contains(keyword.ToLower())).Take(6).ToList();
            }
            return View(hh);
        }
        [HttpGet("/admin/PhieuNhapHang/LayThongTin")]
        public IActionResult LayThongTin(int mahh)
        {
            List<HangHoaNhap> listnhap = ListNhaps;
            //tìm xem có chưa
            HangHoaNhap hhn = listnhap.SingleOrDefault(p => p.MaHh == mahh);
            HangHoa hh = db.HangHoa.SingleOrDefault(p => p.MaHh == mahh);
            if(hhn == null)
            {
                HangHoaNhap item1 = new HangHoaNhap();
                item1.MaHh = hh.MaHh;
                item1.TenHh = hh.TenHh;
                item1.Hinh = hh.Hinh;
                item1.SoLuongNhap = 0;
                item1.DonGiaNhap = hh.DonGia;
                item1.KichCo = "S";

                HangHoaNhap item2 = new HangHoaNhap();
                item2.MaHh = hh.MaHh;
                item2.TenHh = hh.TenHh;
                item2.Hinh = hh.Hinh;
                item2.SoLuongNhap = 0;
                item2.DonGiaNhap = hh.DonGia;
                item2.KichCo = "M";

                HangHoaNhap item3 = new HangHoaNhap();
                item3.MaHh = hh.MaHh;
                item3.TenHh = hh.TenHh;
                item3.Hinh = hh.Hinh;
                item3.SoLuongNhap = 0;
                item3.DonGiaNhap = hh.DonGia;
                item3.KichCo = "L";

                listnhap.Add(item1);
                listnhap.Add(item2);
                listnhap.Add(item3);
            }
            //lưu session
            HttpContext.Session.Set("ListNhap", listnhap);
            return RedirectToAction("Index");

        }
        [HttpPost]
        public IActionResult LayThongTin(int mahh,string size,int soluongnhap,double dongianhap)
        {
            List<HangHoaNhap> ListNhap = new List<HangHoaNhap>(); 

            HangHoaNhap hh = ListNhaps.SingleOrDefault(p=>p.MaHh == mahh && p.KichCo == size);
            // cập nhật thông tin mới
            hh.KichCo = size;
            hh.SoLuongNhap = soluongnhap;
            hh.DonGiaNhap = dongianhap;
            //
            foreach (var item in ListNhaps)
            {
                if(item.MaHh != hh.MaHh)
                {
                    ListNhap.Add(item);
                }
                else
                {
                    if(item.KichCo != size)
                    {
                        ListNhap.Add(item);
                    }
                }
            }
            ListNhap.Add(hh);
            HttpContext.Session.Set("ListNhap", ListNhap);
            return RedirectToAction("Index");
        }
        [HttpGet("/admin/PhieuNhapHang/LuuPhieuNhapKho")]
        public IActionResult LuuPhieuNhapKho()
        {
            double TongTien = 0;
            PhieuNhapHang pnh = new PhieuNhapHang
            {
                NgayNhap = DateTime.Now,
                TongTien = TongTien
            };
            db.PhieuNhapHang.Add(pnh);
            db.SaveChanges();
            
            foreach (var item in ListNhaps)
            {
                TongTien += item.DonGiaNhap * item.SoLuongNhap;
                ChiTietPhieuNhap ct = new ChiTietPhieuNhap
                {
                    MaPn = pnh.MaPn,
                    MaHh = item.MaHh,
                    KichCo = item.KichCo,
                    SoLuongNhap = item.SoLuongNhap,
                    DonGiaNhap = item.DonGiaNhap
                };
                SanPhamKho spk = db.SanPhamKho.SingleOrDefault(p => p.MaHh == ct.MaHh && p.KichCo == ct.KichCo);
                spk.SoLuong += ct.SoLuongNhap;
                db.ChiTietPhieuNhap.Add(ct);
                db.SaveChanges();
            }
            pnh.TongTien = TongTien;
            db.SaveChanges();
            HttpContext.Session.Remove("ListNhap");
            return View("Index");
        }
        [HttpGet("/admin/PhieuNhapHang/XoaChiTiet")]
        public IActionResult XoaChiTiet(int mahh,string size) 
        {
            List<HangHoaNhap> res = ListNhaps;
            HangHoaNhap hhn = res.SingleOrDefault(p => p.MaHh == mahh && p.KichCo == size);
            res.Remove(hhn);
            HttpContext.Session.Set("ListNhap", res);
            return RedirectToAction("Index");
        }
        [HttpGet("/admin/PhieuNhapHang/ChitietPhieuHang")]
        public IActionResult ChitietPhieuHang(int mapn)
        {
            List<ChiTietPhieuNhap> list = db.ChiTietPhieuNhap.Where(p => p.MaPn == mapn).ToList();
            return View(list);
        }
    }
}