using Microsoft.AspNetCore.Mvc; 

namespace Personal_Portfolio.Controllers
{
	public class HomeController : Controller
	{
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
