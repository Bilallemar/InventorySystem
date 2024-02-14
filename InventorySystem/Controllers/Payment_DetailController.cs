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
    public class Payment_DetailController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Payment_DetailController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Payment_Detail
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Payment_Details.Include(p => p.Invoice);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Payment_Detail/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payment_Detail = await _context.Payment_Details
                .Include(p => p.Invoice)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (payment_Detail == null)
            {
                return NotFound();
            }

            return View(payment_Detail);
        }

        // GET: Payment_Detail/Create
        public IActionResult Create()
        {
            ViewData["InvoiceId"] = new SelectList(_context.Invoices, "Id", "Id");
            return View();
        }

        // POST: Payment_Detail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,InvoiceId,CurrentPaidAmount,Date")] Payment_Detail payment_Detail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(payment_Detail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InvoiceId"] = new SelectList(_context.Invoices, "Id", "Id", payment_Detail.InvoiceId);
            return View(payment_Detail);
        }

        // GET: Payment_Detail/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payment_Detail = await _context.Payment_Details.FindAsync(id);
            if (payment_Detail == null)
            {
                return NotFound();
            }
            ViewData["InvoiceId"] = new SelectList(_context.Invoices, "Id", "Id", payment_Detail.InvoiceId);
            return View(payment_Detail);
        }

        // POST: Payment_Detail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,InvoiceId,CurrentPaidAmount,Date")] Payment_Detail payment_Detail)
        {
            if (id != payment_Detail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(payment_Detail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Payment_DetailExists(payment_Detail.Id))
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
            ViewData["InvoiceId"] = new SelectList(_context.Invoices, "Id", "Id", payment_Detail.InvoiceId);
            return View(payment_Detail);
        }

        // GET: Payment_Detail/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payment_Detail = await _context.Payment_Details
                .Include(p => p.Invoice)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (payment_Detail == null)
            {
                return NotFound();
            }

            return View(payment_Detail);
        }

        // POST: Payment_Detail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var payment_Detail = await _context.Payment_Details.FindAsync(id);
            if (payment_Detail != null)
            {
                _context.Payment_Details.Remove(payment_Detail);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Payment_DetailExists(int id)
        {
            return _context.Payment_Details.Any(e => e.Id == id);
        }
    }
}
