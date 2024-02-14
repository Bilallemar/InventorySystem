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
    public class Invoice_DetailController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Invoice_DetailController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Invoice_Detail
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Invoice_Details.Include(i => i.Invoice).Include(i => i.Product);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Invoice_Detail/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice_Detail = await _context.Invoice_Details
                .Include(i => i.Invoice)
                .Include(i => i.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invoice_Detail == null)
            {
                return NotFound();
            }

            return View(invoice_Detail);
        }

        // GET: Invoice_Detail/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            ViewData["InvoiceId"] = new SelectList(_context.Invoices, "Id", "Id");
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name");
            return View();
        }

        // POST: Invoice_Detail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,InvoiceId,CategoryId,ProductId,SellingQty,UnitPrice,SellingPrice,Status")] Invoice_Detail invoice_Detail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(invoice_Detail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InvoiceId"] = new SelectList(_context.Invoices, "Id", "Id", invoice_Detail.InvoiceId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", invoice_Detail.ProductId);
            return View(invoice_Detail);
        }

        // GET: Invoice_Detail/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice_Detail = await _context.Invoice_Details.FindAsync(id);
            if (invoice_Detail == null)
            {
                return NotFound();
            }
            ViewData["InvoiceId"] = new SelectList(_context.Invoices, "Id", "Id", invoice_Detail.InvoiceId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", invoice_Detail.ProductId);
            return View(invoice_Detail);
        }

        // POST: Invoice_Detail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,InvoiceId,CategoryId,ProductId,SellingQty,UnitPrice,SellingPrice,Status")] Invoice_Detail invoice_Detail)
        {
            if (id != invoice_Detail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(invoice_Detail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Invoice_DetailExists(invoice_Detail.Id))
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
            ViewData["InvoiceId"] = new SelectList(_context.Invoices, "Id", "Id", invoice_Detail.InvoiceId);
            ViewData["ProductId"] = new SelectList(_context.Products, "Id", "Name", invoice_Detail.ProductId);
            return View(invoice_Detail);
        }

        // GET: Invoice_Detail/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice_Detail = await _context.Invoice_Details
                .Include(i => i.Invoice)
                .Include(i => i.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invoice_Detail == null)
            {
                return NotFound();
            }

            return View(invoice_Detail);
        }

        // POST: Invoice_Detail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var invoice_Detail = await _context.Invoice_Details.FindAsync(id);
            if (invoice_Detail != null)
            {
                _context.Invoice_Details.Remove(invoice_Detail);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Invoice_DetailExists(int id)
        {
            return _context.Invoice_Details.Any(e => e.Id == id);
        }
    }
}
