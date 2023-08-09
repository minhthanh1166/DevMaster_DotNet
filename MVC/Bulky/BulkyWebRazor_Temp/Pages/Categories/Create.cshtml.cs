using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly MyDBContext _context;

        public CreateModel(MyDBContext context)
        {
            _context = context;
        }

        public Category category { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _context.Categorys.Add(category);
            _context.SaveChanges();
            TempData["success"] = "Category created successfully";
            return RedirectToPage("Index");
        }
    }
}
