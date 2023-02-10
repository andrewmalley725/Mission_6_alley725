using System;
using System.ComponentModel.DataAnnotations;

namespace Mission_6_alley725.Models
{
	public class Ratings
	{
		[Key]
		[Required]
		public int ratingId { get; set; }

		public string rating { get; set; }
	}
}

