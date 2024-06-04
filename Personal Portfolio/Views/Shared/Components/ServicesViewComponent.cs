using Microsoft.AspNetCore.Mvc;

namespace Personal_Portfolio.Views.Shared.Components
{
	public class ServicesViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync(bool isQualities)
		{
			if (!isQualities)
			{
				return View("NotQualities");
			}
			return View();
		}
	}
}
