using Lab09.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Lab09.Controllers
{
    public class HomeController : Controller
    {

        private readonly DevXuongMocContext _scontext;

        public HomeController(DevXuongMocContext _context)
        {
            _scontext = _context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var products = await _scontext.Products.ToListAsync();
            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> Product(int id)
        {
            var product = await _scontext.Products.FindAsync(id);
            return View(product);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}