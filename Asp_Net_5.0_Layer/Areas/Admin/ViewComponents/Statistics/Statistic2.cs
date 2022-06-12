using BuisnessLayer.Concrete;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Asp_Net_5._0_Layer.Areas.Admin.ViewComponents.Statistics
{
    public class Statistic2:ViewComponent
    {
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            //ViewBag.v1 = bm.TGetList().Count();
            ViewBag.v1 = c.Blogs.OrderByDescending(x => x.BlogID).Select(x => x.BlogTitle)
                .Take(1).FirstOrDefault();
            ViewBag.v2 = c.Comments.Count();
            return View();
        }
    }
}
