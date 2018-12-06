using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPCore_Final.Models;
using ReflectionIT.Mvc.Paging;
using Microsoft.AspNetCore.Routing;
using System.Net.Mail;

namespace ASPCore_Final.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HoaDonsController : Controller
    {
        private readonly ESHOPContext _context;

        public HoaDonsController(ESHOPContext context)
        {
            _context = context;
        }

        // GET: Admin/HoaDons
        [HttpGet("/admin/HoaDons")]
        public async Task<IActionResult> Index(string searchString, int page = 1, string sortExpression = "MaHd")
        {
            var eSHOPContext = _context.HoaDon.AsNoTracking().Include(h => h.MaKhNavigation).Include(h => h.MaTrangThaiNavigation).AsQueryable();
            if (!string.IsNullOrEmpty(searchString))
            {
                eSHOPContext = eSHOPContext.Where(p => p.HoTen.Contains(searchString) || p.SdtNguoinhan.Contains(searchString) || p.MaHd.ToString().Contains(searchString));
            }
            var model = await PagingList.CreateAsync(eSHOPContext, 5, page, sortExpression, "MaHd");
            model.RouteValue = new RouteValueDictionary {
                { "searchString", searchString}
            };
           // var eSHOPContext = _context.HoaDon.Include(h => h.MaKhNavigation).Include(h => h.MaTrangThaiNavigation);
            return View(model);
        }

        // GET: Admin/HoaDons/Details/5
        [HttpGet("/admin/HoaDons/Details")]
        public  IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ct = _context.ChiTietHd.Where(p => p.MaHd == id).ToList();
            if (ct == null)
            {
                return NotFound();
            }

            return View(ct);
        }
        
        [HttpGet("/admin/HoaDons/ChangeStatus")]
        public IActionResult ChangeStatus(int id)
        {
            var hd = _context.HoaDon.Find(id);
            if (hd != null)
            {
                hd.MaTrangThai = 1;
                _context.SaveChanges();
                KhachHang kh = _context.KhachHang.SingleOrDefault(p=>p.MaKh==hd.MaKh);
                MailMessage mm = new MailMessage("eshoppingmanager@gmail.com", kh.Email);
                mm.Subject = "Thông báo đơn hàng";
                string content = "<h1>{0}</h1> <br/> <div class='text text-success'><h2>Chào mừng bạn đến với ESHOP.</h2></div> <br> <h5>Bạn vừa tạo một đơn hàng ở ESHOP. Đơn hàng của bạn đã được gửi tới cửa hàng : <br/> Thông tin đơn hàng : <br/>";
                content = content + "<table border='1px' style='font-size:15px;border-collapse: collapse;text-align:center'><tr><th>Tên sản phẩm</th><th>Kích cở</th><th>Số lượng</th><th>Đơn giá</th><th>Thành tiền</th></tr>";
                double tongtien = 0;
                List<ChiTietHd> cthd = _context.ChiTietHd.Where(p => p.MaHd == hd.MaHd).ToList();
                foreach (var item in cthd)
                {
                    HangHoa hangHoa = _context.HangHoa.SingleOrDefault(p => p.MaHh == item.MaHh);
                    var giamgia = item.DonGia - item.DonGia * item.GiamGia;
                    CartItem ct = new CartItem
                    {
                        MaHh = hangHoa.MaHh,
                        TenHh = hangHoa.TenHh,
                        Hinh = hangHoa.Hinh,
                        KichCo = item.KichCo,
                        GiaBan = Convert.ToDouble(giamgia),
                        SoLuong = item.SoLuong
                    };

                    tongtien += ct.ThanhTien;
                    content = content + "<tr><td>" + hangHoa.TenHh + "</td><td>" + item.KichCo + "</td><td>" + item.SoLuong + "</td><td>" + ct.GiaBan.ToString("#,##0") +"</td><td>" + ct.ThanhTien.ToString("#,##0") + "</td></tr>";
                }
                content = content + "<tr><td colspan='4'>Tông thanh toán : </td><td>" + tongtien.ToString("#,##0") + "</td></tr></table><br />";
                content = content + "<div>Đơn hàng của bạn sẽ được chuyển đến trong vài ngày tới . Cảm ơn bạn đã ủng hộ ESHOP. Thân</div>";
                mm.Body = string.Format(content, kh.HoTen);
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential("eshoppingmanager@gmail.com", "eshop147258369");
                smtp.Send(mm);
            }
            return RedirectToAction("Index");
        }


        private bool HoaDonExists(int id)
        {
            return _context.HoaDon.Any(e => e.MaHd == id);
        }
    }
}
