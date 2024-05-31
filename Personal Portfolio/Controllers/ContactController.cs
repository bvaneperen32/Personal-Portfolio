using Microsoft.AspNetCore.Mvc;
using Personal_Portfolio.Data;
using Personal_Portfolio.Models;
using System.Globalization;

namespace Personal_Portfolio.Controllers
{
	public class ContactController : Controller
	{
		private readonly ContactContext _context;

		public ContactController(ContactContext context)
		{
			_context = context;
		}

		public IActionResult Contact()
		{
			return View(); 
		}

		public async Task<IActionResult> SubmitContactForm(ContactInfo contact)
		{
			if (ModelState.IsValid)
			{
				_context.Contacts.Add(contact);
				await _context.SaveChangesAsync();

				ViewBag.Message = "Your message was sent, thank you!"; 
				return View("Contact");
			}

			return View("Contact", contact);
		}
	}
}
