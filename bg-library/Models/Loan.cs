using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Numerics;
using System.Xml;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

namespace bg_library.Models
{
    public class Loan
    {
        [Key] 
        public int Id { get; set; }

        [Required]
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Required]
        [ForeignKey("BoardGameId")]
        public int BoardGameId { get; set; }
        public virtual BoardGame BoardGame { get; set; }

        //public string? Title { get; set; } Fix this later after fixing the database

        public DateTime LoanDate { get; set; } = DateTime.UtcNow;

        // Look up default values for DueDate and ReturnDate
        public DateTime DueDate { get; set; } = DateTime.Now + TimeSpan.FromDays(14);

        public DateTime ReturnDate { get; set; }

    }


}
