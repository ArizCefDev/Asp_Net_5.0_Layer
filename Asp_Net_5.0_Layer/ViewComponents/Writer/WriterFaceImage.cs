using BuisnessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Asp_Net_5._0_Layer.ViewComponents.Writer
{
    public class WriterFaceImage : ViewComponent
    {
        WriterManager wm = new WriterManager(new EFWriterRepository());

        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var usermail = User.Identity.Name;
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).
                Select(y => y.WriterID).FirstOrDefault();
            var values = wm.GetWriterById(writerID);
            return View(values);
        }
    }
}
