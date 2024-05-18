using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Numerics;
using System.Xml;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

namespace bg_library.Models
{
    public class LoanRequest
    {
        public string Email { get; set; }
        public int BoardgameId { get; set; }
    }


}
