using BuisnessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace Asp_Net_5._0_Layer.ViewComponents.Comment
{
    public class CommentListByBlog:ViewComponent
    {
        CommentManager cm = new CommentManager(new EFCommentRepository());

        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetList(id);
            return View(values);
        }
    }
}
