using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_6_alley725.Models
{
    public class Movies
    {
        [Key]
        [Required]
        public int movieId { get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        public string rating { get; set; }

        [Required]
        public string category { get; set; }

        [Required]
        public int year { get; set; }
        public bool edited { get; set; }
        public string lentTo { get; set; }

        [MaxLength(25)]
        public string notes { get; set; }


    }
}
