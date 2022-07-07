using Microsoft.AspNetCore.Mvc;

namespace WebPx.AdminLTE.AspNetCore.MVC.Template.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
