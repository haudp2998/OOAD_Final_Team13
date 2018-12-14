using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPCore_Final.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Net.Mail;

namespace ASPCore_Final.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ESHOPContext _context;

        public RegisterController(ESHOPContext context)
        {
            _context = context;
        }

        // GET: Register
        public async Task<IActionResult> Index()
        {
            return View(await _context.KhachHang.ToListAsync());
        }

        // GET: Register/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachHang = await _context.KhachHang
                .FirstOrDefaultAsync(m => m.MaKh == id);
            if (khachHang == null)
            {
                return NotFound();
            }

            return View(khachHang);
        }

        // GET: Register/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Register/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("MaKh,TaiKhoan,MatKhau,HoTen,GioiTinh,NgaySinh,DiaChi,DienThoai,Email,Hinh")] KhachHang khachHang, IFormFile fHinh)
        {
            if (ModelState.IsValid)
            {
                KhachHang kh = _context.KhachHang.SingleOrDefault(p => p.Email == khachHang.Email);
                KhachHang khh = _context.KhachHang.SingleOrDefault(p => p.TaiKhoan == khachHang.TaiKhoan);
                if (khh != null)
                {
                    TempData["FailUser"] = "Tên đăng nhập đã tồn tại!";
                    if (kh != null)
                    {
                        TempData["FailEmail"] = "Email này đã được đăng kí!";
                    }
                    return View("Create");
                }
                else
                {
                    if (kh != null)
                    {
                        TempData["FailEmail"] = "Email này đã được đăng kí!";
                        return View("Create");
                    }
                }
                if(fHinh != null) {
                    var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot","UserAvatar", fHinh.FileName);
                    using (var file = new FileStream(path, FileMode.Create))
                    {
                        fHinh.CopyTo(file);
                    }
                    khachHang.Hinh = fHinh.FileName;
                }
                khachHang.MatKhau = Encryptor.MD5Hash(khachHang.MatKhau);
                khachHang.TrangThaiHd = false;
                khachHang.LoaiKH = false;
                _context.Add(khachHang);
                _context.SaveChanges();
                MailMessage mm = new MailMessage("eshoppingmanager@gmail.com", khachHang.Email);
                mm.Subject = "Kích hoạt tài khoản Eshop";
                mm.Body = string.Format("Xin chào: <h1>{0}</h1> <br/> <h3>Click vào <a href='https://localhost:44318/activate/index'>link</a> này để kích hoạt tài khoản.</h3>", khachHang.HoTen);
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential("eshoppingmanager@gmail.com", "eshop147258369");
                smtp.Send(mm);
                HttpContext.Session.Set("kh", khachHang);
                return RedirectToAction("Index", "Login");
            }
            return View(khachHang);
        }

        // GET: Register/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachHang = await _context.KhachHang.FindAsync(id);
            if (khachHang == null)
            {
                return NotFound();
            }
            return View(khachHang);
        }

        // POST: Register/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaKh,TaiKhoan,MatKhau,HoTen,GioiTinh,NgaySinh,DiaChi,DienThoai,Email,Hinh,TrangThaiHd")] KhachHang khachHang)
        {
            if (id != khachHang.MaKh)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(khachHang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhachHangExists(khachHang.MaKh))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(khachHang);
        }

        // GET: Register/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachHang = await _context.KhachHang
                .FirstOrDefaultAsync(m => m.MaKh == id);
            if (khachHang == null)
            {
                return NotFound();
            }

            return View(khachHang);
        }

        // POST: Register/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var khachHang = await _context.KhachHang.FindAsync(id);
            _context.KhachHang.Remove(khachHang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KhachHangExists(int id)
        {
            return _context.KhachHang.Any(e => e.MaKh == id);
        }
    }
}
