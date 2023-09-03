using Lap02.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.WebSockets;

namespace Lap02.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        List<Account> ListAccount()
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id = 1,Name="Hoàng Anh",
                    Email="anh@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/images/avatar/Bui Minh Thanh.jpg"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                    Id = 2,Name="Trường Giang",
                    Email="giang@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/images/avatar/Doan Hoai Vinh.jpg"),
                    Gender=1, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
                new Account()
                {
                    Id = 3,Name="Hoàng Thúy",
                    Email="thuy@gmail.com",
                    Phone="0986456789",
                    Address="Hà Nội",
                    Avatar= Url.Content("~/images/avatar/Nguyen Thi Doan Trang.jpg"),
                    Gender=0, Bio="My name is small",
                    Birthday= new DateTime(1998,7,15)
                },
            };
            return accounts;
        }

        [Route("")]
        public IActionResult Index()
        {
            ViewBag.account = ListAccount();

            return View();
        }

        [Route("ho-so-cua-toi/{id?}")]
        public ActionResult Profile(int? id)
        {
            var results = ListAccount().Find(x => x.Id == id);
            ViewBag.profile = results;
            return View();
        }
    }
}