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
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDon = await _context.HoaDon
                .Include(h => h.MaKhNavigation)
                .Include(h => h.MaTrangThaiNavigation)
                .FirstOrDefaultAsync(m => m.MaHd == id);
            if (hoaDon == null)
            {
                return NotFound();
            }

            return View(hoaDon);
        }

        // GET: Admin/HoaDons/Create
        [HttpGet("/admin/HoaDons/Create")]
        public IActionResult Create()
        {
            ViewData["MaKh"] = new SelectList(_context.KhachHang, "MaKh", "Email");
            ViewData["MaTrangThai"] = new SelectList(_context.TrangThai, "MaTrangThai", "TenTrangThai");
            return View();
        }

        // POST: Admin/HoaDons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaHd,MaKh,NgayDat,NgayGiao,HoTen,DiaChi,SdtNguoinhan,GhiChu,PhiVanChuyen,MaTrangThai,MaNv")] HoaDon hoaDon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hoaDon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaKh"] = new SelectList(_context.KhachHang, "MaKh", "Email", hoaDon.MaKh);
            ViewData["MaTrangThai"] = new SelectList(_context.TrangThai, "MaTrangThai", "TenTrangThai", hoaDon.MaTrangThai);
            return View(hoaDon);
        }

        // GET: Admin/HoaDons/Edit/5
        [HttpGet("/admin/HoaDons/Edit")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDon = await _context.HoaDon.FindAsync(id);
            if (hoaDon == null)
            {
                return NotFound();
            }
            ViewData["MaKh"] = new SelectList(_context.KhachHang, "MaKh", "Email", hoaDon.MaKh);
            ViewData["MaTrangThai"] = new SelectList(_context.TrangThai, "MaTrangThai", "TenTrangThai", hoaDon.MaTrangThai);
            return View(hoaDon);
        }

        // POST: Admin/HoaDons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaHd,MaKh,NgayDat,NgayGiao,HoTen,DiaChi,SdtNguoinhan,GhiChu,PhiVanChuyen,MaTrangThai,MaNv")] HoaDon hoaDon)
        {
            if (id != hoaDon.MaHd)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hoaDon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HoaDonExists(hoaDon.MaHd))
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
            ViewData["MaKh"] = new SelectList(_context.KhachHang, "MaKh", "Email", hoaDon.MaKh);
            ViewData["MaTrangThai"] = new SelectList(_context.TrangThai, "MaTrangThai", "TenTrangThai", hoaDon.MaTrangThai);
            return View(hoaDon);
        }

        // GET: Admin/HoaDons/Delete/5
        [HttpGet("/admin/HoaDons/Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDon = await _context.HoaDon
                .Include(h => h.MaKhNavigation)
                .Include(h => h.MaTrangThaiNavigation)
                .FirstOrDefaultAsync(m => m.MaHd == id);
            if (hoaDon == null)
            {
                return NotFound();
            }

            return View(hoaDon);
        }
        // DELETE: api/HangHoas/5
        [HttpDelete("/api/HangHoas/{id}")]
        public async Task<IActionResult> DeleteHoaDon(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var hh = await _context.HangHoa.FindAsync(id);
            if (hh == null)
            {
                return NotFound();
            }

            _context.HangHoa.Remove(hh);
            await _context.SaveChangesAsync();

            return Ok(hh);
        }

        // POST: Admin/HoaDons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hoaDon = await _context.HoaDon.FindAsync(id);
            _context.HoaDon.Remove(hoaDon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet("/admin/HoaDons/ChangeStatus")]
        public IActionResult ChangeStatus(int id)
        {
            var kh = _context.HoaDon.Find(id);
            if (kh != null)
            {
                kh.MaTrangThai = 1;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        private bool HoaDonExists(int id)
        {
            return _context.HoaDon.Any(e => e.MaHd == id);
        }
    }
}
