using Asp_Net_5._0_Layer.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Asp_Net_5._0_Layer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();

            list.Add(new CategoryClass
            {
                categoryname = "Tecnology",
                categorycount=10
            });

            list.Add(new CategoryClass
            {
                categoryname = "Programming",
                categorycount = 14
            });

            list.Add(new CategoryClass
            {
                categoryname = "Sport",
                categorycount = 7
            });
            return Json(new {jsonlist=list});
        }
    }
}
