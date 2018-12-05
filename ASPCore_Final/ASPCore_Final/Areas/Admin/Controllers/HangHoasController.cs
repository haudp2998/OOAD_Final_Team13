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
    public class HangHoasController : CheckLoginController
    {
        private readonly ESHOPContext _context;

        public HangHoasController(ESHOPContext context)
        {
            _context = context;
        }

        // GET: Admin/HangHoas
        [HttpGet("/admin/HangHoas")]
        public async Task<IActionResult> Index(string searchString, int page = 1, string sortExpression = "MaHh")
        {
            var eSHOPContext = _context.HangHoa.AsNoTracking().Include(h => h.MaLoaiNavigation).Include(h => h.MaNccNavigation).AsQueryable();
            if (!string.IsNullOrEmpty(searchString))
            {
                eSHOPContext = eSHOPContext.Where(p => p.TenHh.Contains(searchString) || p.MaNcc.Contains(searchString) || p.MaLoai.Contains(searchString));
            }
            var model = await PagingList.CreateAsync(eSHOPContext, 5, page, sortExpression, "MaHh");
            model.RouteValue = new RouteValueDictionary {
                { "searchString", searchString}
            };
           // var eSHOPContext = _context.HangHoa.Include(h => h.MaLoaiNavigation).Include(h => h.MaNccNavigation);
            return View(model); //(await eSHOPContext.ToListAsync());
        }

        // GET: Admin/HangHoas/Details/5
        [HttpGet("/admin/HangHoas/Details")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hangHoa = await _context.HangHoa
                .Include(h => h.MaLoaiNavigation)
                .Include(h => h.MaNccNavigation)
                .FirstOrDefaultAsync(m => m.MaHh == id);
            if (hangHoa == null)
            {
                return NotFound();
            }

            return View(hangHoa);
        }

        // GET: Admin/HangHoas/Create
        [HttpGet("/admin/HangHoas/Create")]
        public IActionResult Create()
        {
            ViewData["MaLoai"] = new SelectList(_context.Loai, "MaLoai", "MaLoai");
            ViewData["MaNcc"] = new SelectList(_context.NhaCungCap, "MaNcc", "MaNcc");
            return View();
        }

        // POST: Admin/HangHoas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaHh,TenHh,MaLoai,Hinh,DonGia,GiamGia,MoTa,MaNcc,SoLuongHang")] HangHoa hangHoa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hangHoa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaLoai"] = new SelectList(_context.Loai, "MaLoai", "MaLoai", hangHoa.MaLoai);
            ViewData["MaNcc"] = new SelectList(_context.NhaCungCap, "MaNcc", "MaNcc", hangHoa.MaNcc);
            return View(hangHoa);
        }

        // GET: Admin/HangHoas/Edit/5
        [HttpGet("/admin/HangHoas/Edit")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hangHoa = await _context.HangHoa.FindAsync(id);
            if (hangHoa == null)
            {
                return NotFound();
            }
            ViewData["MaLoai"] = new SelectList(_context.Loai, "MaLoai", "MaLoai", hangHoa.MaLoai);
            ViewData["MaNcc"] = new SelectList(_context.NhaCungCap, "MaNcc", "MaNcc", hangHoa.MaNcc);
            return View(hangHoa);
        }

        // POST: Admin/HangHoas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaHh,TenHh,MaLoai,Hinh,DonGia,GiamGia,MoTa,MaNcc,SoLuongHang")] HangHoa hangHoa)
        {
          
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hangHoa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HangHoaExists(hangHoa.MaHh))
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
            ViewData["MaLoai"] = new SelectList(_context.Loai, "MaLoai", "MaLoai", hangHoa.MaLoai);
            ViewData["MaNcc"] = new SelectList(_context.NhaCungCap, "MaNcc", "MaNcc", hangHoa.MaNcc);
            return View(hangHoa);
        }
        // DELETE: api/HangHoas/5
        [HttpDelete("/api/HangHoas/{id}")]
        public async Task<IActionResult> DeleteHangHoa(int id)
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
        // GET: Admin/HangHoas/Delete/5
        [HttpGet("/admin/HangHoas/Delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hangHoa = await _context.HangHoa
                .Include(h => h.MaLoaiNavigation)
                .Include(h => h.MaNccNavigation)
                .FirstOrDefaultAsync(m => m.MaHh == id);
            if (hangHoa == null)
            {
                return NotFound();
            }

            return View(hangHoa);
        }

        // POST: Admin/HangHoas/Delete/5
        [HttpPost("/admin/HangHoas/Delete/{id}"), ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hangHoa = await _context.HangHoa.FindAsync(id);
            _context.HangHoa.Remove(hangHoa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HangHoaExists(int id)
        {
            return _context.HangHoa.Any(e => e.MaHh == id);
        }
    }
}
