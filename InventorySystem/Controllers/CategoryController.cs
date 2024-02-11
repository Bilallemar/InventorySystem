using InventorySystem.Controllers.Data;
using InventorySystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objList = _db.Categories;
            return View(objList);
        }
        //GET
        public IActionResult Create()
        {
           
            return View();
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category cat)
        {
            if(ModelState.IsValid)
            { 
            _db.Categories.Add(cat);
            _db.SaveChanges();
                TempData["success"] = "Category Created Successfuly";
            return RedirectToAction("Index");

            }
            return View(cat);
        }

        public IActionResult Edit(int? id)
        {
            if(id == null)

            return NotFound();
            var getData = _db.Categories.Find(id);
            if(getData == null)
            {
                return NotFound();
            }
            return View(getData);
        }
        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category cat)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(cat);
                _db.SaveChanges();
                TempData["success"] = "Category Updated Successfuly";
                return RedirectToAction("Index");

            }
            return View(cat);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)

                return NotFound();
            var getData = _db.Categories.Find(id);
            if (getData == null)
            {
                return NotFound();
            }
            return View(getData);
        }
        //POST
        [HttpPost,ActionName ("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var getData = _db.Categories.Find(id);
            if (getData == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(getData);
                _db.SaveChanges();
            TempData["success"] = "Category Deleted Successfuly";
            return RedirectToAction("Index");

           
           
        }
    }
}
