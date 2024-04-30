using System.ComponentModel.DataAnnotations;

namespace bg_library.Models
{
    public class User
    {

        [Key]
        public Guid UserId { get; set; }

        [MaxLength(20, ErrorMessage = "Name  must be 20 characters or less"), MinLength(1)]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public DateTime? Registration_date { get; set; } 

    }
}
