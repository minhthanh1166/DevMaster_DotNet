using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using BulkyBook.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Category> objCategoryList = _unitOfWork.Category.GetAll().ToList();
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
                _unitOfWork.Category.Add(obj);
                _unitOfWork.Save();
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

            Category? categoryFromDb = _unitOfWork.Category.Get(x => x.Id == Id);
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
                _unitOfWork.Category.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Category update successfully";
                return RedirectToAction("Index", "Category");
            }
            return View();
        }


        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Category> objCategoryList = _unitOfWork.Category.GetAll().ToList();
            return Json(new { data = objCategoryList });
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var categoryToBeDeleted = _unitOfWork.Category.Get(x => x.Id == id);
            if (categoryToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error white deleting" });
            }
            _unitOfWork.Category.Remove(categoryToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Deleted successfully" });
        }
        #endregion
    }
}
