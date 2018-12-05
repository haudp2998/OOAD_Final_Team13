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

namespace ASPCore_Final.Controllers
{
    public class EditProfileController : Controller
    {
        private readonly ESHOPContext _context;

        public EditProfileController(ESHOPContext context)
        {
            _context = context;
        }

        // GET: EditProfile
        public async Task<IActionResult> Index()
        {
            return View(await _context.KhachHang.ToListAsync());
        }

        // GET: EditProfile/Details/5
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

        // GET: EditProfile/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EditProfile/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaKh,TaiKhoan,MatKhau,HoTen,GioiTinh,NgaySinh,DiaChi,DienThoai,Email,Hinh,TrangThaiHd")] KhachHang khachHang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(khachHang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(khachHang);
        }

        // GET: EditProfile/Edit/5
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

        // POST: EditProfile/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaKh,TaiKhoan,MatKhau,HoTen,GioiTinh,NgaySinh,DiaChi,DienThoai,Email,Hinh,TrangThaiHd")] KhachHang khachHang, IFormFile fHinh)
        {
            if (id != khachHang.MaKh)
            {
                return NotFound();
            }
            KhachHang k = HttpContext.Session.Get<KhachHang>("user");
            if (ModelState.IsValid)
            {
                if (fHinh != null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "UserAvatar", fHinh.FileName);
                    using (var file = new FileStream(path, FileMode.Create))
                    {
                        fHinh.CopyTo(file);
                    }
                    khachHang.Hinh = fHinh.FileName;
                }
                _context.Update(khachHang);
                await _context.SaveChangesAsync();
                HttpContext.Session.Remove("user");
                HttpContext.Session.Set("user", khachHang);
                return RedirectToAction(nameof(Index));
            }
            return View(khachHang);
        }

        // GET: EditProfile/Delete/5
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

        // POST: EditProfile/Delete/5
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
