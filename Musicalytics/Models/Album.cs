using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
namespace Musicalytics.Models
{
    public class Album
    {
        public Album()
        {
        }

        public string name { get; set; }
        public string artist { get; set; }
        public string url { get; set; }
<<<<<<< HEAD
        public string image  { get; set; }

=======
        public string image { get; set; }
        public string artistUrl { get; set; }
>>>>>>> 116471637901cfedf0f992508f5b489c255a9a30
    }
}
