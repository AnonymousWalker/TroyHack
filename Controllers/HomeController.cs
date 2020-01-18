using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TroyHack.Models.ViewModel;

namespace TroyHack.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<string> images = new List<string>();
            images.Add("/Content/img/cat.jpg");
            PostViewModel vm = new PostViewModel { Images = images };
            return View(vm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}