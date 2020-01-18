using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TroyHack.Models.ViewModel
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            Posts = new List<PostViewModel>();
        }
        public IList<PostViewModel> Posts { get; set; }
    }
}