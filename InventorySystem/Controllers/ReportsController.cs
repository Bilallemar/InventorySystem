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
        public IActionResult Index()
        {
            ViewBag.Reports = _db.Purchases.Include(x => x.Product).ToList();
            ViewData["ProductId"] = new SelectList(_db.Products, "Id", "Name");
            return View();
        }

        // POST: PurchaseReport
        [HttpPost]
        public async Task<IActionResult> Index([Bind("ProductId")] Purchase purchase)
        {
            ViewBag.Reports = _db.Purchases.Where(x => (x.ProductId == purchase.ProductId || purchase.ProductId == 0)).Include(x =>x.Product).ToList();

            ViewData["ProductId"] = new SelectList(_db.Products, "Id", "Name");
            return View();
        }
        // POST: PurchaseReport
        [HttpPost]
        public async Task<IActionResult> PrintPurchaseReport([Bind("ProductId")] Purchase purchase)
        {
            ViewBag.Reports = _db.Purchases.Where(x => (x.ProductId == purchase.ProductId || purchase.ProductId == 0)).Include(x => x.Product).ToList();

            ViewData["ProductId"] = new SelectList(_db.Products, "Id", "Name");
            return View();
        }
    }
}
