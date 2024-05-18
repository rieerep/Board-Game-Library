using bg_library.Data;
using bg_library.Models;
using Microsoft.AspNetCore.Mvc;

namespace bg_library.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET api/user
        [HttpGet]
        public User GetUser()
        {
            var user = _context.User.FirstOrDefault(u => u.Id == 1);

            return user;
        }

        //GET api/user/{id}
        [HttpGet("{id}")]
        public User GetUserById(int id)
        {
            var user = _context.User.FirstOrDefault(u => u.Id == id);

            return user;
        }

        //GET api/user/{email}
        [HttpGet("login/{email}")]
        public IActionResult GetUserByEmail(string email)
        {
            try
            {
                var user = _context.User.FirstOrDefault(u => u.Email == email);

                if (user == null)
                {
                    return NotFound();
                }

                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
