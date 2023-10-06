using Lab09.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Data.SqlClient.DataClassification;
using Newtonsoft.Json;

namespace Lab09.Controllers
{
    public class CardController : Controller
    {
        private readonly DevXuongMocContext _context;

        private List<Cart> carts = new List<Cart>();

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var cartInSession = HttpContext.Session.GetString("My-Cart");
            if (cartInSession != null)
            {
                /// Nếu cartInSession không null thì gán dữ liệu cho biến carts 
                /// Chuyển sang dữ liệu là json
                try
                {
                    var carts = JsonConvert.DeserializeObject<List<Cart>>(cartInSession);
                }
                catch (JsonSerializationException ex)
                {
                    ViewBag.ErrorMessage = ex;
                }
            }
            base.OnActionExecuting(context);
        }

        public CardController(DevXuongMocContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Add(int id)
        {
            if (carts.Any(x => x.Id == id)) // Nếu sản phẩm này có trong giỏ hàng
            {
                carts.Where(x => x.Id == id).First().Quantity += 1; // Tăng số lượng lên 1 đơn vị
            }
            else
            {
                // Nếu sản phẩm chưa có trong giỏ hàng thì thêm sản phẩm vào giỏ hàng
                var objProductId = await _context.Products.FindAsync(id); // Tìm sản phẩm bằng id
                // Lấy data productId add vào giỏ hàng
                if(objProductId != null)
                {
                    var item = new Cart()
                    {
                        Id = objProductId.Id,
                        Name = objProductId.Title,
                        Price = (float)objProductId.PriceNew.Value,
                        Quantity = 1,
                        Image = objProductId.Image,
                        Total = (float)objProductId.PriceNew.Value * 1
                    };
                    // Thêm card vào giỏ hàng 
                    carts.Add(item);
                }
            }

            HttpContext.Session.SetString("My-Cart", JsonConvert.SerializeObject(carts));

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id, int quantity)
        {
            if(carts.Any(x=>x.Id == id))
            {
                // Tìm sản phẩm trong giỏ hang và cập nhật vào số lượng mới
                carts.Where(x => x.Id == id).First().Quantity = quantity;
                // Lưu card vào session và cần phải chuyển sang dữ liệu json
               
            }
            HttpContext.Session.SetString("My-Cart", JsonConvert.SerializeObject(carts));

            return View();
        }
    }
}
