using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InventorySystem.Controllers.Data;
using InventorySystem.Models;

namespace InventorySystem.Controllers
{
    public class CustomarsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomarsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customars
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customars.ToListAsync());
        }

        // GET: Customars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customar = await _context.Customars
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customar == null)
            {
                return NotFound();
            }

            return View(customar);
        }

        // GET: Customars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Customar_Image,Mobile_no,Email,Address,Status")] Customar customar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customar);
        }

        // GET: Customars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customar = await _context.Customars.FindAsync(id);
            if (customar == null)
            {
                return NotFound();
            }
            return View(customar);
        }

        // POST: Customars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Customar_Image,Mobile_no,Email,Address,Status")] Customar customar)
        {
            if (id != customar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomarExists(customar.Id))
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
            return View(customar);
        }

        // GET: Customars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customar = await _context.Customars
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customar == null)
            {
                return NotFound();
            }

            return View(customar);
        }

        // POST: Customars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customar = await _context.Customars.FindAsync(id);
            if (customar != null)
            {
                _context.Customars.Remove(customar);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomarExists(int id)
        {
            return _context.Customars.Any(e => e.Id == id);
        }
    }
}
