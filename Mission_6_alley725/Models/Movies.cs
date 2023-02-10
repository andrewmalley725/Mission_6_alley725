using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("rating")]
        [Required]
        public int ratingId { get; set; }
        public virtual Ratings rating { get; set; }


        [ForeignKey("category")]
        [Required]
        public int categoryId { get; set; }
        public virtual Category category { get; set; }

        [Required]
        public int year { get; set; }
        public bool edited { get; set; }
        public string lentTo { get; set; }

        [MaxLength(25)]
        public string notes { get; set; }


    }
}
