using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly MyDBContext _db;
        public CategoryController(MyDBContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categorys.ToList();
            return View(objCategoryList);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("DisplayOrder", "The Display Order cannot exactly match the Name.");
            }

            if (obj.Name.ToLower() == "test")
            {
                ModelState.AddModelError("Name", "Test is an invalid value.");
            }

            if (ModelState.IsValid)
            {
                _db.Categorys.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Category create successfully";
                return RedirectToAction("Index", "Category");
            }
            return View(obj);
        }

        public IActionResult Edit(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            Category? categoryFromDb = _db.Categorys.Find(Id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("DisplayOrder", "The Display Order cannot exactly match the Name.");
            }

            if (obj.Name.ToLower() == "test")
            {
                ModelState.AddModelError("Name", "Test is an invalid value.");
            }

            if (ModelState.IsValid)
            {
                _db.Categorys.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Category update successfully";
                return RedirectToAction("Index", "Category");
            }
            return View();
        }

        public IActionResult Delete(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            Category? CategoryFromDb = _db.Categorys.Find(Id);
            if (CategoryFromDb == null)
            {
                return NotFound();
            }
            return View(CategoryFromDb);
        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? Id)
        {
            Category? CategoryFromDb = _db.Categorys.Find(Id);
            if (CategoryFromDb == null)
            {
                return NotFound();
            }
            _db.Remove(CategoryFromDb);
            _db.SaveChanges();
            TempData["success"] = "Category delete successfully";

            return RedirectToAction("Index", "Category");
        }
    }
}
