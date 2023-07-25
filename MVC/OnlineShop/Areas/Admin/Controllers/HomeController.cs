using System.Web.Mvc;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Authorize]
    //[AllowAnonymous] lạc danh
    public class HomeController : Controller
    {
        // GET: Admin/Home

        public ActionResult Index()
        {
            return View();
        }
    }
}