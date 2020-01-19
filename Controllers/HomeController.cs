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
            var models = TroyHack.MvcApplication.AllPostings;
            return View(new HomeViewModel { Posts = models});
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult PostAPet()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PostAPet(UploadViewModel model, HttpPostedFileBase[] images = null)
        {
            if (model != null && images != null)
            {
                int i = 1; string imageFileString ="";
                var imgList = new Dictionary<int, string>();
                foreach (var image in images)
                {
                    var imgBin = new byte[image.ContentLength];
                    image.InputStream.Read(imgBin, 0, image.ContentLength);
                    var base64Img = Convert.ToBase64String(imgBin);
                    imageFileString = string.Format("data:image/jpg;base64,{0}", base64Img);
                    imgList.Add(i++, imageFileString);
                }

                var lastId = TroyHack.MvcApplication.AllPostings.Max(p => p.PostingId);

                var posting = new PostViewModel
                {
                    Age = model.Age,
                    Breed = model.Breed,
                    Characteristic = model.Characteristic,
                    Health = model.Health,
                    Images = imgList,
                    PostingId = lastId+1,
                    SpecialNeeds = model.SpecialNeeds,
                    Status = model.Status,
                    Story = model.Story
                };

                TroyHack.MvcApplication.AllPostings.Add(posting);
                return RedirectToAction("Index");
            }
            return RedirectToAction("PostAPet");
        }
        public string GetImage(int postingId, int imgIndex)
        {
            string imgAddress = "";
            try
            {
                var posting = TroyHack.MvcApplication.AllPostings.FirstOrDefault(p => p.PostingId == postingId);
                imgAddress = posting.Images[imgIndex];
            }
            catch (Exception e)
            {

            }
            return imgAddress;
        }

        public ActionResult Search(string searchInput = "")
        {
            if (searchInput != "")
            {
                var res = TroyHack.MvcApplication.AllPostings.Where(p => p.Breed.Contains(searchInput) || p.Characteristic.Contains(searchInput) || p.Status.Contains(searchInput));
                return View("Index", new HomeViewModel { Posts = res.ToList() });
            }
            return RedirectToAction("Index");
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