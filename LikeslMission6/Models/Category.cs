using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LikeslMission6.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }
    }
}
