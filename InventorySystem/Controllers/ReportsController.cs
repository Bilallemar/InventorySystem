using InventorySystem.Controllers.Data;
using InventorySystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace InventorySystem.Controllers
{
    public class ReportsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ReportsController(ApplicationDbContext db)
        {
            _db = db;
        }
        //View PurchaseReport
        public IActionResult PurchaseReport()
        {
            ViewBag.Reports = _db.Purchases.Include(x => x.Product).ToList();
            ViewData["ProductID"] = new SelectList(_db.Products, "Id", "Name");
            return View();
        }

        // POST: PurchaseReport
        [HttpPost]
        public async Task<IActionResult> PurchaseReport([Bind("ProductID")] Purchase purchase)
        {
            ViewBag.Reports = _db.Purchases.Where(x => (x.ProductID == purchase.ProductID || purchase.ProductID == 0)).Include(x => x.Product).ToList();

            ViewData["ProductID"] = new SelectList(_db.Products, "Id", "Name");
            return View();
        }
        //View SalesReport
        public IActionResult SalesReport()
        {
            ViewBag.Reports = _db.Sales.Include(x => x.Product).ToList();
            ViewData["ProductID"] = new SelectList(_db.Products, "Id", "Name");
            return View();
        }

        // POST: Sales Report
        [HttpPost]
        public async Task<IActionResult> SalesReport([Bind("ProductID")] Sale sale)
        {
            ViewBag.Reports = _db.Sales.Where(x => (x.ProductID == sale.ProductID || sale.ProductID == 0)).Include(x => x.Product).ToList();

            ViewData["ProductID"] = new SelectList(_db.Products, "Id", "Name");
            return View();
        }
        // POST: Prent PurchaseReport
        [HttpPost]
        public async Task<IActionResult> PrintPurchaseReport([Bind("ProductID")] Purchase purchase)
        {
            ViewBag.Reports = _db.Purchases.Where(x => (x.ProductID == purchase.ProductID || purchase.ProductID == 0)).Include(x => x.Product).ToList();

            ViewData["ProductID"] = new SelectList(_db.Products, "Id", "Name");
            return View();
        }
    }
}
