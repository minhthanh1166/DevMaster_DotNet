using Lab04.Models;
using Lab04.Models.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Lab04.Controllers
{
    public class PeopleController : Controller
    {
        // GET: PeopleController
        public ActionResult Index()
        {
            return View(PeopleData.GetPeople());
        }


        public IActionResult NotFounds()
        {
            return View();
        }

        // GET: PeopleController/Details/5
        public ActionResult Details(int id)
        {
            if (PeopleData.GetPeopleById(id) != null)
            {
                return View(PeopleData.GetPeopleById(id));
            }
            return RedirectToAction(nameof(NotFounds));
        }

        // GET: PeopleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PeopleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(People model)
        {
            try
            {
                // Up load file vào thư mục wwwroot
                var files = HttpContext.Request.Form.Files;
                if (files.Count() > 0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var fileName = file.FileName;
                    // Nhớ tạo thư mục avatars trong thư mục wwwroot/images
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\avatars", fileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        model.Avatar = "/images/avatars/" + fileName;
                    }
                }

                // Thêm People vào danh sách data local
                if(PeopleData.Add(model))
                {
                    return RedirectToAction(nameof(Index));
                }
                return View(model);
            }
            catch(Exception ex)
            {
                ViewBag.error = ex;
                return View(model);
            }
        }

        // GET: PeopleController/Edit/5
        public ActionResult Edit(int id)
        {
            if (PeopleData.GetPeopleById(id) != null)
            {
                return View(PeopleData.GetPeopleById(id));
            }
            return RedirectToAction(nameof(NotFounds));
        }

        // POST: PeopleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, People model)
        {
            try
            {
                var files = HttpContext.Request.Form.Files;
                if (files.Count() > 0 && files[0].Length > 0)
                {
                    var file = files[0];
                    var fileName = file.FileName;
                    // Nhớ tạo thư mục avatars trong thư mục wwwroot/images
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\avatars", fileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        file.CopyTo(stream);
                        model.Avatar = "/images/avatars/" + fileName;
                    }
                }
                if(PeopleData.Edit(id, model))
                {
                    return RedirectToAction(nameof(Index));
                }

                return View(model);
            }
            catch
            {
                return View();
            }
        }

        // GET: PeopleController/Delete/5
        public ActionResult Delete(int id)
        {
            // Kiểm tra xem tệp ảnh có tồn tại không
            if (System.IO.File.Exists("wwwroot/" + PeopleData.GetPeopleById(id).Avatar))
            {
                // Xóa tệp ảnh
                System.IO.File.Delete("wwwroot/" + PeopleData.GetPeopleById(id).Avatar);
            }

            PeopleData.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        // POST: PeopleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
