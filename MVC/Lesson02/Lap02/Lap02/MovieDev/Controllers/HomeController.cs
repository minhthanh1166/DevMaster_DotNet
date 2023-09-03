using Microsoft.AspNetCore.Mvc;
using MovieDev.Models;
using System.Diagnostics;

namespace MovieDev.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}