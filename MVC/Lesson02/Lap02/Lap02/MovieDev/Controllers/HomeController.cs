using Microsoft.AspNetCore.Mvc;
using MovieDev.Models;
using System.Diagnostics;

namespace MovieDev.Controllers
{
    public class HomeController : Controller
    {
        List<Category> ListCategory()
        {
            List<Category> categories = new List<Category>()
            {
                new Category
                {
                    Id = 1,
                    Name = "Phim hành động"
                },
                new Category
                {
                    Id = 1,
                    Name = "Phim viễn tưởng"
                }
            };
            return categories;
        }
        List<Product> ListProduct()
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name = "Highly recommend",
                    createAt = DateTime.Now,
                    categoryId = 1,
                    Description = "Phim rất hay",
                    Image = "https://i.mpcdn.top/c/KWbOgDZ/ninja-rua-hon-loan-tuoi-day-thi.jpg?",
                    Price = 25000,
                    SalePrice = 30000,
                    status = true
                },
                new Product
                {
                    Id = 2,
                    Name = "The acting incredible",
                    createAt = DateTime.Now,
                    categoryId = 2,
                    Description = "Phim rất hay",
                    Image = "https://i.mpcdn.top/c/A4rZ0py/toi-mong-giua-ban-ngay.jpg?",
                    Price = 45000,
                    SalePrice = 82000,
                    status = true
                },
                new Product
                {
                    Id = 3,
                    Name = "I have ever seen",
                    createAt = DateTime.Now,
                    categoryId = 2,
                    Description = "Phim rất hay",
                    Image = "https://i.mpcdn.top/poster/the-gioi-hoan-my-9380.jpg?",
                    Price = 15000,
                    SalePrice = 37000,
                    status = true
                }
            };
            return products;
        }

        public IActionResult Index()
        {
            var products = ListProduct();
            var categories = ListCategory();


            var categoryAndProduct = new CategoryAndProduct
            {
                Product = products,
                Category = categories
            };

            return View(categoryAndProduct);
        }

        public IActionResult Profile(int? id)
        {
            if(id != null)
            {
                var objProduct = ListProduct().Find(x => x.Id == id);
                ViewBag.product = objProduct;
                return View();
            }
                
            return RedirectToAction("Index");
        }
    }
}