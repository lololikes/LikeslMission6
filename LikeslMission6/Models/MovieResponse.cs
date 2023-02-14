using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LikeslMission6.Models
{
    public class MovieResponse
    {
        [Key]
        [Required]
        public int ApplicatioId { get; set; }
        public string MovieName { get; set; }
        public string Category { get; set; }
        public int Year { get; set; }
        public string Rating { get; set; }
        public string DirectorName  { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }
    }
}
