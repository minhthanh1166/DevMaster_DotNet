using Microsoft.AspNetCore.Mvc;

namespace Lesson08_LabDemo.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
