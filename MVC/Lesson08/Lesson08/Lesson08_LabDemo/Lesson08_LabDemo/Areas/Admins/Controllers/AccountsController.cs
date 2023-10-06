using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lesson08_LabDemo.Areas.Admins.Data;
using Lesson08_LabDemo.Areas.Admins.Models;
using X.PagedList;

namespace Lesson08_LabDemo.Areas.Admins.Controllers
{
    [Area("Admins")]
    public class AccountsController : Controller
    {
        public List<SelectListItem> StatusListItem { get; } = new List<SelectListItem>();

        private readonly ApplicationDbContext _context;

        public AccountsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admins/Accounts
        public async Task<IActionResult> Index(string name, int page = 1)
        {
            int limit = 5;
            var account = await _context.Accounts.OrderBy(x => x.Id).ToPagedListAsync(page, limit);

            if (!String.IsNullOrEmpty(name))
            {
                account = await _context.Accounts.OrderBy(x => x.Id).Where(x => x.Name.Contains(name)).ToPagedListAsync(page, limit);
            }

            ViewBag.keyword = name;
            return View(account);
        }

        // GET: Admins/Accounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Accounts == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // GET: Admins/Accounts/Create
        public async Task<IActionResult> Create()
        {
            var category = await _context.Categorys.ToListAsync();
            foreach(var item in category)
            {
                StatusListItem.Add(new SelectListItem { Value = item.Id.ToString(), Text = item.Status.ToString() });
            }
            return View();
        }

        // POST: Admins/Accounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,Image,Username,Password,Facebook,CreateDate,Status")] Account account)
        {
            if (ModelState.IsValid)
            {
                _context.Add(account);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(account);
        }

        // GET: Admins/Accounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Accounts == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }

        // POST: Admins/Accounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Image,Username,Password,Facebook,CreateDate,Status")] Account account)
        {
            if (id != account.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var resultObj = await _context.Accounts.FindAsync(id);

                    if (resultObj != null)
                    {
                        // Kiểm tra xem tệp ảnh có tồn tại không
                        if (System.IO.File.Exists("wwwroot/" + resultObj.Image))
                        {
                            // Xóa tệp ảnh
                            System.IO.File.Delete("wwwroot/" + resultObj.Image);
                        }
                    }

                    var files = HttpContext.Request.Form.Files;
                    if (files.Count > 0 && files[0].Length > 0)
                    {
                        var file = files[0];
                        var fileName = file.FileName;
                        // Nho tao thu muc
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\accounts\\" + fileName);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            file.CopyTo(stream);
                            account.Image = "/images/accounts/" + fileName;
                        }
                    }

                    _context.ChangeTracker.Clear();
                    _context.Update(account);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(account);
        }

        // GET: Admins/Accounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Accounts == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Admins/Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Accounts == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Accounts'  is null.");
            }
            var account = await _context.Accounts.FindAsync(id);
            if (account != null)
            {
                _context.Accounts.Remove(account);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountExists(int id)
        {
            return (_context.Accounts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
