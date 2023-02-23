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

        [Required (ErrorMessage ="You must enter a Movie Title duh!!")]
        public string MovieName { get; set; }

        public int Year { get; set; }
        public string Rating { get; set; }
        public string DirectorName { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }

        //Build Foreign Key relationship 
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}
