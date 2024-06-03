using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace BookStore.ViewModel
{
	public class AuthorFormVM
	{
		public int Id { get; set; }
		[MaxLength(30)]
		public string Name { get; set; }
	 
	}
}
