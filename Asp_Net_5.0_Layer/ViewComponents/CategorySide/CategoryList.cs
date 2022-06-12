using BuisnessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace Asp_Net_5._0_Layer.ViewComponents.CategorySide
{
    public class CategoryList:ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EFCategoryRepository());

        public IViewComponentResult Invoke()
        {
            var values = cm.TGetList();
            return View(values); 
        }
    }
}
