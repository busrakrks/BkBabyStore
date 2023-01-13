using Microsoft.AspNetCore.Mvc;

namespace BkBabyStore.WebUI.Areas.Admin.Controllers
{
    public class MainController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
