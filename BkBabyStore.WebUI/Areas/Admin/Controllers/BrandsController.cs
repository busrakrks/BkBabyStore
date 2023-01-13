using Microsoft.AspNetCore.Mvc;

namespace BkBabyStore.WebUI.Areas.Admin.Controllers
{
	public class BrandsController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
