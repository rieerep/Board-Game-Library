using bg_library.Data;
using bg_library.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;


namespace bg_library.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BoardGameController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BoardGameController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IEnumerable<BoardGame> Get()
        {
            var boardGames = _context.BoardGame.ToList();
            return boardGames;
        }

        [HttpDelete("Loan/{id}")]
        public IActionResult DeleteLoan(int id)
        {
            var loan = _context.Loans.Find(id);
            if (loan == null)
            {
                return NotFound();
            }

            _context.Loans.Remove(loan);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPost("AddGame")]
        public IActionResult AddGame([FromBody] BoardGame boardGame)
        {
            _context.BoardGame.Add(boardGame);
            _context.SaveChanges();
            return Ok();
        }

    }
}