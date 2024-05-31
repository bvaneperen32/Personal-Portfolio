using System.ComponentModel.DataAnnotations;

namespace Personal_Portfolio.Models
{
	public class ContactInfo
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Name is required.")]
		[StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
		[RegularExpression(@"[a-zA-Z\s]+$", ErrorMessage ="Name can only contain letters")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Email is required")]
		[EmailAddress(ErrorMessage = "Invalid Email Address")]
		[StringLength(100, ErrorMessage ="Email cannot be longer thatn 100 characters.")]
		public string Email {  get; set; }

		[Required(ErrorMessage = "Subject is required.")]
		[StringLength(200, ErrorMessage = "Subject cannot be longer than 200 characters.")]
		public string Subject { get; set; }

		[Required(ErrorMessage = "Message is required.")]
		[StringLength(1000, ErrorMessage = "Message cannot be longer than 1000 characters.")]
		public string Message { get; set; }
	}
}
