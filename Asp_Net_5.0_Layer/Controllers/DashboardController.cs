using BuisnessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Asp_Net_5._0_Layer.Controllers
{
    public class DashboardController : Controller
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        
        public IActionResult Index()
        {
            Context c = new Context();
            var usermail = User.Identity.Name;
            var writerid = c.Writers.Where(x => x.WriterMail == usermail).
                Select(y => y.WriterID).FirstOrDefault();
            ViewBag.v1 = c.Blogs.Count().ToString();
            ViewBag.v2 = c.Blogs.Where(x => x.WriterID == writerid).Count();
            ViewBag.v3 = c.Categories.Count();
            return View();
        }
    }
}
