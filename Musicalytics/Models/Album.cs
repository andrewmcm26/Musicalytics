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
        public string image { get; set; }

    }
}
