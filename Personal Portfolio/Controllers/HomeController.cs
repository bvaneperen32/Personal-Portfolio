using Microsoft.AspNetCore.Mvc;
using Personal_Portfolio.Data;

namespace Personal_Portfolio.Controllers
{
	public class HomeController : Controller
	{
		private readonly ContactContext _context;

		public HomeController(ContactContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult About()
		{
			return View();
		}

		public IActionResult Resume()
		{
			return View();
		}

		public IActionResult Portfolio()
		{
			return View();
		}

		public IActionResult Services()
		{
			return View();
		}

		public IActionResult Contact()
		{
			return View();
		}
	}
	
}
