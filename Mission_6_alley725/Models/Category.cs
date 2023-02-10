using System;
using System.ComponentModel.DataAnnotations;

namespace Mission_6_alley725.Models
{
	public class Category
	{
		[Key]
		[Required]
		public int categoryId { get; set; }
		public string category { get; set; }
	}
}

