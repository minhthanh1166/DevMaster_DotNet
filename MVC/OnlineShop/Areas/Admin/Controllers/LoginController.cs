using OnlineShop.Areas.Admin.Models;
using System.Web.Mvc;
using System.Web.Security;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // Prevent CSRF
        public ActionResult Index(LoginModel model)
        {
            //var result = new AccountModel().Login(model.userName, model.passWord);
            if (Membership.ValidateUser(model.userName, model.passWord) && ModelState.IsValid)
            {
                //SessionHelper.SetSesstion(new UserSession() { UserName = model.userName });
                FormsAuthentication.SetAuthCookie(model.userName, model.rememBerMe);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập và mật khẩu không đúng!");
            }
            return View(model);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}