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
    public class LoaisController : CheckLoginController
    {
        private readonly ESHOPContext _context;

        public LoaisController(ESHOPContext context)
        {
            _context = context;
        }

        // GET: Admin/Loais
        [HttpGet("/admin/Loais")]
        public async Task<IActionResult> Index(string searchString, int page = 1, string sortExpression = "GioiTinh")
        {
            var eSHOPContext = _context.Loai.AsNoTracking().AsQueryable();
            if (!string.IsNullOrEmpty(searchString))
            {
                eSHOPContext = eSHOPContext.Where(p => p.TenLoai.Contains(searchString) || p.MaLoai.Contains(searchString));
            }
            var model = await PagingList.CreateAsync(eSHOPContext, 5, page, sortExpression, "ID");
            model.RouteValue = new RouteValueDictionary {
                { "searchString", searchString}
            };
            return View(model);//await _context.Loai.ToListAsync());
        }

        // GET: Admin/Loais/Details/5
        [HttpGet("/admin/Loais/Details")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loai = await _context.Loai
                .FirstOrDefaultAsync(m => m.MaLoai == id);
            if (loai == null)
            {
                return NotFound();
            }

            return View(loai);
        }

        // GET: Admin/Loais/Create
        [HttpGet("/admin/Loais/Create")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Loais/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaLoai,GioiTinh,TenLoai")] Loai loai)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loai);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loai);
        }

        // GET: Admin/Loais/Edit/5
        [HttpGet("/admin/Loais/Edit")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loai = await _context.Loai.FindAsync(id);
            if (loai == null)
            {
                return NotFound();
            }
            return View(loai);
        }

        // POST: Admin/Loais/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaLoai,GioiTinh,TenLoai")] Loai loai)
        {
            if (id != loai.MaLoai)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loai);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoaiExists(loai.MaLoai))
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
            return View(loai);
        }
     
       
        // DELETE: api/NhanViens/5
        [HttpDelete("/api/Loais/{id}")]
        public async Task<IActionResult> DeleteLoai(string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var loai = await _context.Loai.FirstOrDefaultAsync(m => m.MaLoai == id);
            if (loai == null)
            {
                return NotFound();
            }

            _context.Loai.Remove(loai);
            await _context.SaveChangesAsync();

            return Ok(loai);
        }

        private bool LoaiExists(string id)
        {
            return _context.Loai.Any(e => e.MaLoai == id);
        }
    }
}
