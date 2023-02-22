using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LikeslMission6.Models
{
    public class MovieResponse
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string MovieName { get; set; }

        [Required]
        public int MovieCategoryId { get; set; }
        public Category Category { get; set; }
        public int Year { get; set; }
        public string Rating { get; set; }
        public string DirectorName { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }
        
    }
}
