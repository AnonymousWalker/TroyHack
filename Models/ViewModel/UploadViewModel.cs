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
            Images = new Dictionary<int, string>();
        }

        public int PostingId { get; set; }
        public IDictionary<int, string> Images { get; set; }
        public string Status { get; set; } = "";
        public string Story { get; set; } = "";
        public int Age { get; set; }
        public string Breed { get; set; } = "";
        public string SpecialNeeds { get; set; } = "";
        public string Health { get; set; } = "";
        public string Characteristic { get; set; } = "";
    }
}