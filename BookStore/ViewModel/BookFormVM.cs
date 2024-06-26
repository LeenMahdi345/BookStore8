﻿using BookStore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace BookStore.ViewModel
{
	public class BookFormVM
	{
		public int Id { get; set; }
		[MaxLength(50)]
		public string Title { get; set; }

		[Display(Name = "Author")]
		public int AuthorId { get; set; }
		
		public List<SelectListItem>?Authors { get; set; }
		public string Publisher { get; set; }

		[Display(Name = "Publish Date")]
		public DateTime PublishDate { get; set; }= DateTime.Now; 
		public IFormFile? ImageUrl { get; set; }
		public DateTime CreatedAt { get; set; } = DateTime.Now;
		public DateTime? UpdatedAt { get; set; } = DateTime.Now;
		public string Description { get; set; } = null!;
		public List<int> SelectedCategories { get; set; }=new List<int>(); 
		public List<SelectListItem>? Categories { get; set; }
	}
}
