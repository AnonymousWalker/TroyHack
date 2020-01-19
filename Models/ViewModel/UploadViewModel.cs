using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TroyHack.Models.ViewModel
{
    public class UploadViewModel
    {
        public UploadViewModel()
        {
            var lastId = TroyHack.MvcApplication.AllPostings.Max(posting => posting.PostingId);
            PostingId = lastId++;
            Images = new Dictionary<int, string>();
        }

        public int PostingId { get; set; }
        public IDictionary<int, string> Images { get; set; }
        public string Status = "";
        public string Story = "";
        public int Age { get; set; }
        public string Breed = "";
        public string SpecialNeeds = "";
        public string Health = "";
        public string Characteristic = "";
    }
}