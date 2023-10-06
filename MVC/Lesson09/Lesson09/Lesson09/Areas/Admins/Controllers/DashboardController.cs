using Microsoft.AspNetCore.Mvc;

namespace Lesson09.Areas.Admins.Controllers
{
    [Area(nameof(Admins))]
    public class DashboardController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
