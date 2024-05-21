using System.ComponentModel.DataAnnotations;

namespace bg_library.Models
{
    public class BoardGame
    {
        [Key]
        public int BoardGameId { get; set;}

        [MaxLength(50, ErrorMessage="Name must be 1 character or more"),MinLength(1)]        
        public string Name { get; set; }

        [MaxLength(25, ErrorMessage = "Category name must be 25 characters or less"), MinLength(2)]
        public string Category { get; set; }
        public decimal Complexity { get; set; }

        [MaxLength(50, ErrorMessage = "Publisher name must be max 50 characters or less"), MinLength(2)]
        public string Publisher { get; set; }
        public string Image { get; set; }
        public int Minimum_age { get; set; }
    }
}
