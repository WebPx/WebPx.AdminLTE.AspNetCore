using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPx.AdminLTE.AspNetCore.MVC.Template.Areas.Admin.Models;

namespace WebPx.AdminLTE.AspNetCore.MVC.Template.Areas.Admin
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new HomeModel());
        }
    }
}
