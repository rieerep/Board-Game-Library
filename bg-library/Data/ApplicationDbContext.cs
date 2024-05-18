using bg_library.Models;
using Microsoft.EntityFrameworkCore;

namespace bg_library.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }
        public DbSet<User> User { get; set; }
        public DbSet<BoardGame> BoardGame { get; set; }
        public DbSet<Loan> Loans { get; set; }
    }

}
