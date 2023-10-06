using Lesson09.Areas.Admins.Data;
using Lesson09.Areas.Admins.Models;
using Microsoft.AspNetCore.Mvc;


namespace Lesson09.Areas.Admins.Controllers
{
    [Area(nameof(Admins))]
    public class LoginController : Controller
    {
        private ApplicationDbContext _context;
        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Login model)
        {
            if (!ModelState.IsValid)
            {
                return View(model); // Tra ve trang thai loi
            }
            // Su ly login phan dang nhap tai day
            var pass = Commons.GetSHA256Hash(model.Password);
            var dataLogin = _context.Accounts.Where(x => x.Email.Equals(model.Email) && x.Password.Equals(pass)).FirstOrDefault();

            if (dataLogin != null)
            {
                // Luu session khi dang nhap thanh cong
                HttpContext.Session.SetString("AdminLogin", model.Email);
                return RedirectToAction("Index", "Dashboard");
            }
            return View(model); // Trả về trạng thái lỗi
        }

        

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("AdminLogin"); // Hủy session với key AdminLogin trước đó

            return RedirectToAction("Index");
        }
    }
}
