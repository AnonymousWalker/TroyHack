using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TroyHack.Models;
using TroyHack.Models.ViewModel;

namespace TroyHack.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = TroyHack.MvcApplication.AllPostings;
            return View(new HomeViewModel { Posts = model});
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

        public string GetImage(int postingId, int imgIndex)
        {
            string imgAddress = "";
            var posting = TroyHack.MvcApplication.AllPostings.FirstOrDefault(p => p.PostingId == postingId);
            if (posting == null) 
                return imgAddress;
            imgAddress = posting.Images[imgIndex];
            return imgAddress;
        }


        //private HomeViewModel InitData()
        //{
        //    var postings = new List<PostViewModel>();

        //    postings.Add(new PostViewModel
        //    {
        //        Age = 2, 
        //        Breed = "Domestic Shorthair",
        //        Characteristic = "Cuddle & Child friendly",
        //        Health = "Good",
        //        SpecialNeeds = "Wet food only",
        //        Images = new List<string>(){ @"/Content/img/yoko-cat.png" },
        //        Status = "Emergency",
        //        Story = "Yoko is a loving 2-year-old girl who was found behind the dumpster of a restaurant. She has been in the shelter for 3 months now and loves to cuddle everyone she meets! Yoko is ready for a forever person to snuggle with."

        //    });

        //    postings.Add(new PostViewModel
        //    {
        //        Age = 110,
        //        Breed = "Test",
        //        Characteristic = "Test",
        //        Health = "Test",
        //        SpecialNeeds = "Test",
        //        Images = new List<string>() { @"/Content/img/cat.jpg" },
        //        Status = "Test",
        //        Story = "TestTestTestTestTest"

        //    });

        //    return new HomeViewModel { Posts = postings };
        //}
    }
}