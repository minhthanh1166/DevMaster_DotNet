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
                    Id = 2,
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
                ListProduct = products,
                ListCategory = categories
            };

            return View(categoryAndProduct);
        }

        public IActionResult Profile(int? id)
        {
            if (id != null)
            {
                var objProduct = ListProduct().Find(x => x.Id == id);

                if (objProduct != null)
                {
                    var categoryId = objProduct.categoryId; // Lấy categoryId từ objProduct

                    var category = ListCategory().Find(x => x.Id == categoryId);

                    if (category != null)
                    {
                        var categoryAndProduct = new CategoryAndProduct
                        {
                            ListProduct = new List<Product> { objProduct }, // Đưa objProduct vào danh sách Product
                            ListCategory = new List<Category> { category }, // Đưa category vào danh sách Category
                            NameCategory = category.Name // Gán tên danh mục
                        };

                        return View(categoryAndProduct);
                    }
                }
            }

            return RedirectToAction("Index");
        }
    }
}