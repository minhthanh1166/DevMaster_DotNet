using HelloWord.Models;
using System.Web.Mvc;

namespace HelloWord.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var msg = new MessageModel();
            msg.Welcome = "Hello thanh!";
            return View(msg);
        }
    }
}