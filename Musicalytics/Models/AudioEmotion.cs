using System;
namespace Musicalytics.Models
{
    public class AudioEmotion
    {
        public AudioEmotion()
        {
        }

        public double emotionValue { get; set; }
        public string emotionName { get; set; }
        public string songName { get; set; }
        public string artistName { get; set; }
        public string albumName { get; set; }
        public string preview { get; set; }
        public int albumYear { get; set; }
    }
}
