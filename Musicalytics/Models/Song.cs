using System;
namespace Musicalytics.Models
{
    public class Song
    {
        public Song()
        {
        }

        public double Valence { get; set; }
        public double Energy { get; set; }
        public string Id { get; set; }
    }
}
