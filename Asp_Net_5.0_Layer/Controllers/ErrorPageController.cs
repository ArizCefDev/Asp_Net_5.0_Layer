using Microsoft.AspNetCore.Mvc;

namespace Asp_Net_5._0_Layer.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1(int code)
        {
            return View();
        }
    }
}
