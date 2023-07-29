using Microsoft.AspNetCore.Mvc;
using MyWEB_API_Web.Data;
using MyWEB_API_Web.Models;

namespace MyWEB_API_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiController : ControllerBase
    {
        private readonly MyDBContext _context;

        public LoaiController(MyDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var dsLoai = _context.Loais.ToList();
            return Ok(dsLoai);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var loaiId = _context.Loais.SingleOrDefault(x => x.MaLoai == id);
            if (loaiId != null)
            {
                return Ok(loaiId);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Create(LoaiModel model)
        {
            try
            {
                var loai = new Loai
                {
                    TenLoai = model.TenLoai
                };
                _context.Add(loai);
                _context.SaveChanges();
                return Ok(loai);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateItemById(int id, LoaiModel model)
        {
            try
            {
                var loaiId = _context.Loais.SingleOrDefault(x => x.MaLoai == id);
                if (loaiId != null)
                {
                    loaiId.TenLoai = model.TenLoai;

                    _context.SaveChanges();
                    return Ok(loaiId);
                }
                return NotFound();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteItemById(int id)
        {
            try
            {
                var loaiId = _context.Loais.SingleOrDefault(x => x.MaLoai == id);
                if (loaiId != null)
                {
                    _context.Remove(loaiId);
                    _context.SaveChanges();
                    return Ok(new { success = true, Data = _context.Loais.ToList() });
                }
                return NotFound();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
