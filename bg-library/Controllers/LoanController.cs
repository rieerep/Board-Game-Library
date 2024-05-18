using bg_library.Data;
using bg_library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bg_library.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoanController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoanController(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET api/loan/id
        [HttpGet("get-loan-by-id/")]
        public List<Loan> GetLoanByUserId(int userId)
        {
            var userLoan = _context.Loans.Include(l => l.User).Include(l => l.BoardGame).Where(u => u.UserId == userId).ToList();
            

            return userLoan;
        }

        [HttpPost("RegisterLoan")]
        public IActionResult Loan([FromBody] LoanRequest loanRequest)
        {
        
            var user = _context.User.FirstOrDefault(e => e.Email == loanRequest.Email);
            var boardGame = _context.BoardGame.FirstOrDefault(b => b.BoardGameId == loanRequest.BoardgameId);

            if (user == null || boardGame == null)
            {
                return BadRequest("User or Board game not found");
            }

            var newLoan = new Loan() { BoardGame = boardGame, User = user, UserId = user.Id, BoardGameId = boardGame.BoardGameId };

            _context.Loans.Add(newLoan);
            _context.SaveChanges();
            return Ok();
        }

        //GET api/user/{id}
        //[HttpGet("{id}")]
        //public User GetUserById(int id)
        //{
        //    var user = _context.User.FirstOrDefault(u => u.Id == id);

        //    return user;
        //}

        //GET api/user/{email}
        //[HttpGet("login/{email}")]
        //public User GetUserByEmail(string email)
        //{
        //    var user = _context.User.FirstOrDefault(u => u.Email == email);

        //    return user;
        //}
    }
}
