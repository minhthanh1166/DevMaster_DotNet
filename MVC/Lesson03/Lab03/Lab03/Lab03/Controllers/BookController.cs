using Lab03.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab03.Controllers
{
    public class BookController : Controller
    {
        private Book book = new Book();
        public IActionResult Index()
        {
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;
            List<Book> books = book.GetBookLists();
            return View(books);
        }
    }
}
