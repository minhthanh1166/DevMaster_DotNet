using ChatOnlne.Entity;
using ChatOnlne.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChatOnlne.Controllers
{
    [Route("chat/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly MyDBContext _context;
        public MessageController(MyDBContext context)
        {
            _context = context;
        }

        // GET: api/<MessageController>
        [HttpGet]
        public IActionResult GetAll()
        {
            // Lấy ra các trường ID_MSG, Text và USER_ID từ bảng Message
            var messagesWithUserNames = _context.MESSAGES
                .Join(
                    _context.USERS,
                    message => message.ID_USER,
                    user => user.ID_USER,
                    (message, user) => new
                    {
                        message.ID_MSG,
                        message.Text,
                        Name = user.Name,
                        UserName = user.UserName
                    })
                .ToList();

            return Ok(messagesWithUserNames);
        }


        // POST api/<MessageController>
        [HttpPost]
        public IActionResult Post(MessageModel model)
        {
            try
            {
                var Msg = new Message()
                {
                    Text = model.Text,
                    ID_USER = model.ID_USER
                };

                _context.Add(Msg);
                _context.SaveChanges();
                return Ok(model);
            }
            catch
            {
                return BadRequest();
            }
        }



        // DELETE api/<MessageController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var MSG_Id = _context.MESSAGES.SingleOrDefault(x => x.ID_MSG == id);
                if (MSG_Id != null)
                {
                    _context.Remove(MSG_Id);
                    _context.SaveChanges();
                    return Ok(new
                    {
                        success = true,
                        Data = _context.MESSAGES.ToList()
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
