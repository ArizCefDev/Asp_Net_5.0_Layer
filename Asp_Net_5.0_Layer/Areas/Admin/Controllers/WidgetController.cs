using Microsoft.AspNetCore.Mvc;

namespace Asp_Net_5._0_Layer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WidgetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
