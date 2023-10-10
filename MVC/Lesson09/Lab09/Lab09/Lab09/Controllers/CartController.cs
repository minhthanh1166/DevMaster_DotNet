using Lab09.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Data.SqlClient.DataClassification;
using Newtonsoft.Json;

namespace Lab09.Controllers
{
    public class CartController : Controller
    {
        private readonly DevXuongMocContext _context;

        public CartController(DevXuongMocContext context)
        {
            _context = context;
        }

        private List<Cart> carts = new List<Cart>();
        private List<Customer> customers = new List<Customer>();

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var cartInSession = HttpContext.Session.GetString("My-Cart");
            if (cartInSession != null)
            {
                /// Nếu cartInSession không null thì gán dữ liệu cho biến carts 
                /// Chuyển sang dữ liệu là json
                carts = JsonConvert.DeserializeObject<List<Cart>>(cartInSession);
            }
            base.OnActionExecuting(context);
        }

        private float GetTotals()
        {
            return (float)carts.Select(x => x.Total).ToList().Sum();
        }

        [HttpGet]
        public IActionResult Index()
        {
            //var cartTotal = carts.Select(x => x.Total).ToList().Sum();

            var orderCart = new OrderCart()
            {
                ListCarts = carts,
                Carts = GetTotals(),
            };
            return View(orderCart);
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
                if (objProductId != null)
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


        public IActionResult Update(int id, int quantity)
        {
            if (carts.Any(x => x.Id == id))
            {
                // Tìm phần tử có Id trùng với id
                var cartItem = carts.FirstOrDefault(x => x.Id == id);

                // Kiểm tra xem phần tử có tồn tại không
                if (cartItem != null)
                {
                    // Cập nhật Quantity
                    cartItem.Quantity = quantity;
                  
                    // Cập nhật Total dựa trên giá trị mới của Quantity
                    cartItem.Total = cartItem.Quantity * cartItem.Price;
                }
            }
            HttpContext.Session.SetString("My-Cart", JsonConvert.SerializeObject(carts));

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Remove(int id)
        {
            if (carts.Any(x => x.Id == id))
            {
                // Tìm sản phẩm trong giỏ hàng 
                var item = carts.Where(x => x.Id == id).First();
                carts.Remove(item);
            }

            HttpContext.Session.SetString("My-Cart", JsonConvert.SerializeObject(carts));
            if (carts.Count() == 0)
            {
                return RedirectToAction(nameof(Index), "Home");
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
        }

        public IActionResult Clear()
        {
            HttpContext.Session.Remove("My-Cart");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer model)
        {
            try
            {
                int id = 0;
                var item = new Customer()
                {
                    Id = id += 1,
                    Name = model.Name,
                    Email = model.Email,
                    Phone = model.Phone,
                    City = model.City,
                    Address = model.Address,
                    District = model.District,
                    Description = model.Description,
                };

                customers.Add(item);
                return RedirectToAction(nameof(Pay));
            }
            catch
            {
                return View(model);
            }
        }

        public IActionResult Pay()
        {
            ViewBag.Total = GetTotals();
            return View();
        }
    }
}
