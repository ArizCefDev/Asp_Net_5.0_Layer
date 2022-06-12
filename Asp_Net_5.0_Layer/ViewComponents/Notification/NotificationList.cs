using BuisnessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace Asp_Net_5._0_Layer.ViewComponents.Notification
{
    public class NotificationList:ViewComponent
    {
        NotificationManager nm = new NotificationManager(new EFNotificationRepository());

        public IViewComponentResult Invoke()
        {
            var values = nm.TGetList();
            return View(values);
        }
    }
}
