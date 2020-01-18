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

            var img = new Dictionary<int, string>();
            img.Add(1, @"/Content/img/cat.jpg");
            AllPostings.Add(new PostViewModel
            {
                PostingId = 1,
                Age = 2,
                Breed = "Domestic Shorthair",
                Characteristic = "Cuddle & Child friendly",
                Health = "Good",
                SpecialNeeds = "Wet food only",
                Images = img,
                Status = "Emergency",
                Story = "Yoko is a loving 2-year-old girl who was found behind the dumpster of a restaurant. She has been in the shelter for 3 months now and loves to cuddle everyone she meets! Yoko is ready for a forever person to snuggle with."

            });

            img = new Dictionary<int, string>();
            img.Add(1, @"/Content/img/yoko-cat.png");
            AllPostings.Add(new PostViewModel
            {
                PostingId = 2,
                Age = 110,
                Breed = "Test",
                Characteristic = "Test",
                Health = "Test",
                SpecialNeeds = "Test",
                Images = img,
                Status = "Test",
                Story = "TestTestTestTestTest"
            });
        }
    }
}
