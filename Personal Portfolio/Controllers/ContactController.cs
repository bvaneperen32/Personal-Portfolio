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

		[HttpGet]
		public IActionResult Contact()
		{
			return View("~/Views/Home/Contact.cshtml"); 
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> SubmitContactForm(ContactInfo contactInfo)
		{
			if (ModelState.IsValid) {
				_context.Add(contactInfo);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Contact));
			}

			return View("~/Views/Home/Contact.cshtml", contactInfo);
		}


	}
}
