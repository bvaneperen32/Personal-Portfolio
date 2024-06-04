using Microsoft.AspNetCore.Mvc;

namespace Personal_Portfolio.Views.Shared.Components
{
	public class FooterViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View(); 
		}
	}
}
