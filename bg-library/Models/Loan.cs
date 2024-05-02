using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Numerics;
using System.Xml;
using System.ComponentModel.DataAnnotations;

namespace bg_library.Models
{
    public class Loan
    {
        [Key] 
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int BoardGameId { get; set; }


        public DateTime LoanDate { get; set; } = DateTime.UtcNow;

        // Look up default values for DueDate and ReturnDate
        public DateTime DueDate { get; set; } = DateTime.Now + TimeSpan.FromDays(14);
        public DateTime ReturnDate { get; set; }
    }
    
}
