using System.ComponentModel.DataAnnotations;

namespace BookStore.ViewModel
{
	public class AuthorVM
	{
		public int Id { get; set; }
		[MaxLength(30)]
		public string Name { get; set; }
		public DateTime CreatedOn { get; set; }
		public DateTime UpdatedOn { get; set; }
	}
}
