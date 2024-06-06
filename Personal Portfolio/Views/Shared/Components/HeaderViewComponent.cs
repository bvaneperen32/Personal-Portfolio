using Microsoft.AspNetCore.Mvc;

namespace Personal_Portfolio.Views.Shared.Components
{
	public class HeaderViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
