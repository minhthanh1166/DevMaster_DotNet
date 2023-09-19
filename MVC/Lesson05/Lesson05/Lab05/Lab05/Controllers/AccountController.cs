using System.Text.RegularExpressions;
using Lab05.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab05.Controllers
{
    public class AccountController : Controller
    {
        // GET: AccountController   
        private List<Account> accounts = new List<Account>();
        public ActionResult Index()
        {
            
            return View(accounts);
        }

        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountController/Create
        public ActionResult Create()
        {
            Account account = new Account();
            return View(account);
        }

        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Account model)
        {
            try
            {
                if (ModelState.IsValid)
                {

                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [AcceptVerbs("GET", "POST")]
        public ActionResult VarifyPhone(string phone)
        {
            Regex regex = new Regex("/(84|0[3|5|7|8|9])+([0-9]{8})\b/g");
            if(regex.IsMatch(phone))
            {
                return Json($"Số điện thoại {phone} không đúng định dạng, VD: 0829936692 hoặc 0966979351");
            }

            return Json(true);
        }
    }
}
