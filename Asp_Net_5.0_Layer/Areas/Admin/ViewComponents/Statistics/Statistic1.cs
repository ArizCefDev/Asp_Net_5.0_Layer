using BuisnessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Asp_Net_5._0_Layer.Areas.Admin.ViewComponents.Statistics
{
    public class Statistic1:ViewComponent
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = bm.TGetList().Count();
            ViewBag.v2 = c.Contacts.Count();
            ViewBag.v3 = c.Comments.Count();
            return View();
        }
    }
}
