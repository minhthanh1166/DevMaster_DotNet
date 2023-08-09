using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly MyDBContext _context;

        public List<Category> CategoryList { get; set; }

        public IndexModel(MyDBContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            CategoryList = _context.Categorys.ToList();
        }


    }
}
