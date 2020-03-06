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
        public string audio = "https://audio-ssl.itunes.apple.com/itunes-assets/AudioPreview118/v4/79/4e/f4/794ef45b-f9e1-27c3-c143-d29061d6863f/mzaf_5008234458169035990.plus.aac.p.m4a";
    }
}
