using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TroyHack.Models.ViewModel;

namespace TroyHack
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static IList<PostViewModel> AllPostings;
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            InitData();
        }

        private void InitData()
        {
            AllPostings = new List<PostViewModel>();
            int i = 1;
            var img = new Dictionary<int, string>();
            img.Add(1, @"/Content/img/yoko-cat.png");
            img.Add(2, @"/Content/img/wildcat.jpg");
            AllPostings.Add(new PostViewModel
            {
                PostingId = i++,
                Age = 2,
                Breed = "Domestic Shorthair",
                Characteristic = "Cuddle & Child friendly",
                Health = "Good",
                SpecialNeeds = "Wet food only",
                Images = img,
                Status = "Emergency",
                Story = "Yoko is a loving 2-year-old girl who was found behind the dumpster of a restaurant. She has been in the shelter for 3 months now and loves to cuddle everyone she meets! Yoko is ready for a forever person to snuggle with."

            });
            //2---------------
            img = new Dictionary<int, string>();
            img.Add(1, @"/Content/img/chase.jpg");
            AllPostings.Add(new PostViewModel
            {
                PostingId = i++,
                Age = 110,
                Breed = "German Shepherd",
                Characteristic = "Good with dogs, full of energy, house-trained",
                Health = "Very Good",
                SpecialNeeds = "None",
                Images = img,
                Status = "Mild Priority",
                Story = "Chase is a 2-year-old neutered male German Shepherd Dog - the big strong guy at 80lbs. He is basically well mannered but can be strong so he needs an experienced handler who has plans for further obedience training. Chase is a young dog who requires daily off-leash exercise and playtime."
            });
            //3---------------
            img = new Dictionary<int, string>();
            img.Add(1, @"/Content/img/midnight-2.jpg");
            AllPostings.Add(new PostViewModel
            {
                PostingId = i++,
                Age = 110,
                Breed = "Dachshund/Beagle Mix",
                Characteristic = "Good with dogs, cats, and kids",
                Health = "Not neutered",
                SpecialNeeds = "Needs a little more training",
                Images = img,
                Status = "Emergency",
                Story = "Midnight came from an NC shelter where they were in danger of flooding from the recent Hurricane. She is young, about 1-2 years old. about 20 lbs - very sweet and friendly but scared at first. She is doing very well with training for walking nicely on a leash."
            });
        }
    }
}
