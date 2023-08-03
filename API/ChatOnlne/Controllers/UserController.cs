using ChatOnlne.Entity;
using ChatOnlne.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChatOnlne.Controllers
{
    [Route("chat/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly MyDBContext _context;

        public UserController(MyDBContext context)
        {
            _context = context;
        }

        // GET: api/<AccountController>
        [HttpGet]
        public IActionResult GetAll()
        {
            var dsAcc = _context.USERS.ToList();
            return Ok(dsAcc);
        }

        // GET api/<AccountController>/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var accId = _context.USERS.SingleOrDefault(x => x.ID_USER == id);
                if (accId != null)
                {
                    return Ok(accId);
                }
                return NotFound();
            }
            catch
            {
                return BadRequest();
            }
        }

        // POST api/<AccountController>
        [HttpPost]
        public IActionResult Post(UserModel model)
        {
            try
            {
                var acc = new User()
                {
                    Name = model.Name,
                    UserName = model.UserName,
                    Password = model.Password,
                    Email = model.Email
                };
                _context.Add(acc);
                _context.SaveChanges();
                return Ok(acc);
            }
            catch
            {
                return BadRequest();
            }

        }

        // PUT api/<AccountController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, UserModel model)
        {
            try
            {
                var accCode = _context.USERS.SingleOrDefault(x => x.ID_USER == id);
                if (accCode != null)
                {
                    accCode.Name = model.Name;
                    accCode.UserName = model.UserName;
                    accCode.Password = model.Password;
                    accCode.Email = model.Email;

                    _context.SaveChanges();
                    return Ok(accCode);
                }
                return NotFound();
            }
            catch
            {
                return BadRequest();
            }
        }

        // DELETE api/<AccountController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var accCode = _context.USERS.SingleOrDefault(x => x.ID_USER == id);
                if (accCode != null)
                {
                    _context.Remove(accCode);
                    _context.SaveChanges();
                    return Ok(new
                    {
                        success = true,
                        Data = _context.USERS.ToList()
                    });
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
