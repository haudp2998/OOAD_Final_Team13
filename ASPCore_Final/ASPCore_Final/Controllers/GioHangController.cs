using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using ASPCore_Final.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCore_Final.Controllers
{
    public class GioHangController : Controller
    {
        private readonly ESHOPContext db;
        public GioHangController(ESHOPContext ctx)
        {
            db = ctx;
        }
        public IActionResult Index()
        {
            return View(Carts);
        }

        public List<CartItem> Carts
        {
            get
            {
                List<CartItem> myCart = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if (myCart == default(List<CartItem>))
                {
                    myCart = new List<CartItem>();
                }

                return myCart;
            }
        }
        [HttpPost]
        public IActionResult AddToCart(int mahh,string size, int soluongsp)
        {
            if (HttpContext.Session.Get<string>("mess") != null)
                HttpContext.Session.Remove("mess");
            List<CartItem> gioHang = Carts;
            //tìm xem có chưa
            CartItem item = gioHang.SingleOrDefault(p => p.MaHh == mahh && p.KichCo == size);
            if (item != null) //có rồi
            {
                item.SoLuong++;
            }
            else
            {
                HangHoa hh = db.HangHoa.SingleOrDefault(p => p.MaHh == mahh);
                item = new CartItem
                {
                    MaHh = hh.MaHh,
                    TenHh = hh.TenHh,
                    Hinh = hh.Hinh,
                    SoLuong = soluongsp,
                    KichCo = size,
                    GiaBan = hh.DonGia * (1 - hh.GiamGia)
                };
                gioHang.Add(item);
            }
            //lưu session
            HttpContext.Session.Set("GioHang", gioHang);
            return RedirectToAction("Index");
        }

        public IActionResult XoaCartItem(int cartitem)
        {
            List<CartItem> giohang = Carts;
            // lấy hang hóa muốn xóa
            CartItem hh = giohang.SingleOrDefault(p => p.MaHh == cartitem);
            giohang.Remove(hh);
            HttpContext.Session.Set("GioHang", giohang);
            return RedirectToAction("Index");
        }

      
        public IActionResult CapNhatSL(int mahh, string kichco, int soluongmoi)
        {
            List<CartItem> giohang = Carts;
            CartItem hh = giohang.SingleOrDefault(p => p.MaHh == mahh && p.KichCo == kichco);
            hh.SoLuong = soluongmoi;
            HttpContext.Session.Set("GioHang", giohang);
            return RedirectToAction("Index");
        }

        public IActionResult TaoHoaDon(int makh,string hotenkh,string diachi,string hoten_ngnhan,string dc_nguoinhan,string ghichu,string sdt)
        {
            // tạo hóa đơn
            HoaDon hd = new HoaDon
            {
                MaKh = makh,
                HoTen = hoten_ngnhan,
                DiaChi = dc_nguoinhan,
                NgayDat = DateTime.Now,
                GhiChu = ghichu,
                SdtNguoinhan = sdt,
                MaTrangThai = 0,
                PhiVanChuyen = 35000
            };
            
            db.HoaDon.Add(hd);
            // tạo chi tiết hóa đơn
          //  double tt = 0;
            KhachHang kh = db.KhachHang.SingleOrDefault(p => p.MaKh == makh);
            foreach (var item in Carts)
            {
                HangHoa hh = db.HangHoa.SingleOrDefault(p => p.MaHh == item.MaHh);
             //   tt = item.SoLuong * hh.DonGia * (1 - hh.GiamGia);
                ChiTietHd cthd = new ChiTietHd
                {
                    MaHd = hd.MaHd,
                    MaHh = item.MaHh,
                    DonGia = hh.DonGia,
                    GiamGia = hh.GiamGia,
                    SoLuong = item.SoLuong,
                    KichCo = item.KichCo
                };
              
                db.ChiTietHd.Add(cthd);
                db.SaveChanges();
                // trừ sản phẩm từ kho
                SanPhamKho spk = db.SanPhamKho.SingleOrDefault(p => p.MaHh == cthd.MaHh && p.KichCo == cthd.KichCo);
                if(spk.SoLuong >= cthd.SoLuong)
                {
                    if (HttpContext.Session.Get<string>("ErrorGH") != null)
                    {
                        HttpContext.Session.Remove("ErrorGH");
                    }
                    spk.SoLuong = spk.SoLuong - cthd.SoLuong;
                }
                else
                {
                    HangHoa hangHoa = db.HangHoa.SingleOrDefault(p => p.MaHh == cthd.MaHh);
                    string loi = "Hàng hóa có mã " + hangHoa.TenHh + " chỉ còn : " + spk.SoLuong + " sản phẩm";
                    HttpContext.Session.Set("ErrorGH",loi);
                    db.ChiTietHd.Remove(cthd);
                    db.HoaDon.Remove(hd);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            HttpContext.Session.Set<string>("mess", "Hóa đơn của bạn đã được gửi tới cửa hàng vui lòng chờ kiểm tra mail để biết trạng thái đơn hàng của bạn . ESHOP");
            HttpContext.Session.Remove("GioHang");
            return RedirectToAction("Index");
        }

        public IActionResult HoaDon()
        {
            return View();
        }
    }
}