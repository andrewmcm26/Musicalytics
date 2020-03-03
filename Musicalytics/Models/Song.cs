using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Musicalytics.Models
{
    public class Song
    {
        public Song()
        {
        }

        public void LoadJson()
        {
            using (StreamReader r = new StreamReader("SgtPepperTracks.json"))
            {
                string json = r.ReadToEnd();
                List<Song> items = JsonConvert.DeserializeObject<List<Song>>(json);
            }
        }

        public double valence { get; set; }
        public double energy { get; set; }
        public string id { get; set; }
    }
}
