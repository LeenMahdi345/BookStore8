﻿using System.ComponentModel.DataAnnotations;

namespace BookStore.ViewModel
{
    public class CategoryVM
    {
		public int Id { get; set; }
		[Required(ErrorMessage = "plz insert name")]
        [MaxLength(3, ErrorMessage = "30")]
        public string Name { get; set; } = null!;
		public DateTime CreatedOn { get; set; } = DateTime.Now;
		public DateTime UpdatedOn { get; set; } = DateTime.Now;
	}
}
