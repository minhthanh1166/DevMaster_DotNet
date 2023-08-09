using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly MyDBContext _context;
        public DeleteModel(MyDBContext context)
        {
            _context = context;
        }

        public Category category { get; set; }

        public void OnGet(int? id)
        {
            if (id != null || id != 0)
            {
                category = _context.Categorys.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            try
            {
                _context.Categorys.Remove(category);
                _context.SaveChanges();
                TempData["success"] = "Category deleted successfully";
                return RedirectToPage("Index");
            }
            catch
            {
                return Page();
            }
        }
    }
}
